using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor.GUI
{
    public partial class Frm_Principal : Form
    {
        List<ENT.Terminal_ENT> Equipos = new List<ENT.Terminal_ENT>();

        //Obtenemos el nombre el equipo
        string Host;
        //Obtenemos las ip accesibles a este servidor
        public static IPAddress[] HostIp;
        //creamos el protocolo que recibira las solicitudes tcp
        public TcpListener Server;
        //establecemos el socket para envio y recepcion de mensajes
        Socket Sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        //creamos el hilo que se encargara de recibir el contenido
        Thread Recibir;
        //variable utilizada para validar si se sigue recibiendo mensajes
        bool Enviando = false;
        //contenido a actualizar en los mensajes
        string ContenidoaActualizar;
        //obtenemos el cliente actual
        TcpClient ClienteConectar = new TcpClient();

        //contenido que se recibe del cliente.
        String ContenidoRecibido = "";

        //trabajamos con un listado de puertos utilizados por la aplicacion
        List<int> PuertosUtilizados = new List<int>();

        //contiene los parametros de configuracion de la aplicacion.
        BLL.Configuraciones.AdminConfiguraciones_BLL Configuraciones;
        //clase que se encarga de facturar los tiempos.
        BLL.Facturador_BLL Factura = new BLL.Facturador_BLL();

        DateTime Hoy = DateTime.Today;
        ENT.Usuario_ENT Usuario;

        public Frm_Principal(ENT.Usuario_ENT UsuarioSel)
        {
            InitializeComponent();
            Usuario = UsuarioSel;
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            try
            {
                if (RegistrarEnInicio())
                {
                    InicializarVariablesNet();
                    HabilitarTimers();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region "Metodos & Funciones"

        private bool RegistrarEnInicio()
        {
            try
            {
                string RutaEjecutable = Application.ExecutablePath;
                string NombreApp = Application.ProductName;
                bool ExisteRegistro = false;

                if (!NombreApp.StartsWith("\"") && NombreApp.IndexOf(" ") > -1)
                {
                    NombreApp = "\"" + NombreApp + "\"";
                }

                RegistryKey Registro = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

                ExisteRegistro = Registro.GetValue(NombreApp) != null;

                if (!ExisteRegistro) { Registro.SetValue(NombreApp, RutaEjecutable); }

                return true;
            }
            catch(Exception)
            {
                MessageBox.Show("Error al registrar la aplicación en el inicio del sistema operativo. Seguramente no tienes privilegios suficiente. Cierre la aplicación y ejecutela como administrador");
                return false;
            }
        }

        private void LlenarComboEquipos()
        {
            try
            {
                Cmb_Equipos.Items.Clear();
                Equipos.ForEach(E => Cmb_Equipos.Items.Add(E.Equipo));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AgregarCliente(string Nombre, int Puerto = 0, TcpClient ClienteSel = null)
        {
            try
            {
                string Notificacion = "";
                ENT.Terminal_ENT Equipo = Equipos.Find(C => C.Equipo == Nombre);
                if (Equipo == null)
                {
                    Equipo = new ENT.Terminal_ENT();
                    Equipo.Equipo = Nombre;
                    Equipo.Estado = ENT.TiposAnidados_ENT.EstadoTerminal.Disponible;
                    Equipo.Puerto = Puerto;
                    Equipo.TCP = ClienteSel;
                    Equipos.Add(Equipo);
                    Ctrl_Terminales.AgregarControl(Equipo);
                    AsignarEventosControlesTerminales();
                    Notificacion = "El cliente " + Equipo.Equipo + " se ha conectado";
                }
                else
                {
                    CTRL.Terminal_CTRL Ctrl = Ctrl_Terminales.EncontrarControlXNombre(Nombre);
                    Equipo.Puerto = Puerto;
                    Equipo.TCP = ClienteSel;
                    Equipo.Estado = ENT.TiposAnidados_ENT.EstadoTerminal.Disponible;

                    Ctrl.Equipo.Puerto = Puerto;
                    Ctrl.Equipo.TCP = ClienteSel;
                    Ctrl.CambiarEstado(Equipo.Estado);
                    Notificacion = "El cliente " + Equipo.Equipo + " se ha reconectado";
                }
                MostrarNotificacion(Notificacion);
                LlenarComboEquipos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InicializarVariablesNet()
        {
            int PuertoEscuchaClientes = 5000;
            int PuertoEscuchaMensajes = 5103;

            Host = Dns.GetHostName();
            HostIp = Dns.GetHostAddresses(Dns.GetHostName());

            IPAddress Ip = ObtenerIp();
            if (Ip == null)
            {
                throw new Exception("El Equipo no posee una Ip válida");
            }

            Server = new TcpListener(Ip, PuertoEscuchaClientes);
            Sock.Bind(new IPEndPoint(Ip, PuertoEscuchaMensajes));
            Sock.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, true);

            Recibir = new Thread(GetDatos);
            Recibir.Start();

        }

        private void HabilitarTimers()
        {
            Tmr_Servidor.Enabled = true;
            Tmr_Estados.Enabled = true;
        }

        private IPAddress ObtenerIp()
        {
            return HostIp.ToList().FindAll(P => P.AddressFamily == AddressFamily.InterNetwork)
                                  .FirstOrDefault();
        }

        private void GetDatos()
        {
            while (!Enviando)
            {
                IPEndPoint IPRem = new IPEndPoint(IPAddress.Any, 0);
                EndPoint IPRec = (EndPoint)IPRem;
                byte[] RecBytes = new byte[256];
                string Datos = "";
                try
                {
                    Sock.ReceiveFrom(RecBytes, RecBytes.Length, SocketFlags.None, ref IPRec);
                    Datos = Encoding.Default.GetString(RecBytes);
                }
                catch (SocketException ex)
                {
                    if (ex.ErrorCode == 10040)
                    {
                        Datos += "[truncado]";
                    }
                    else
                    {
                        MessageBox.Show("Error '" + ex.ErrorCode + "' " + ex.Message, "Error al recibir los datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                IPRem = (IPEndPoint)IPRec;
                ContenidoaActualizar = Datos.ToString();
                Rtb_Mensajes.Invoke(new EventHandler(ActualizarMensajes));
            }
        }

        private int ObtenerPuertoDisponible()
        {
            try
            {
                for (int Puerto = 5001; Puerto < 5102; Puerto++)
                {
                    if (PuertosUtilizados.Contains(Puerto))
                    {
                        continue;
                    }
                    else
                    {
                        PuertosUtilizados.Add(Puerto);
                        return Puerto;
                    }
                }

                return 0;
            }
            catch(Exception )
            {
                throw;
            }
        }

        public void ConectarCon(int Puerto)
        {
            try
            {
                TcpClient Cliente;
                string Equipo = "";

                TcpListener Listen = new TcpListener(IPAddress.Any, Puerto);
                Listen.Start();
                while (true)
                {
                    if (Listen.Pending())
                    {
                        Cliente = Listen.AcceptTcpClient();
                        ContenidoRecibido = InterfazNet.Get(ClienteConectar);

                        if (ContenidoRecibido.StartsWith("H"))
                        {
                            Equipo = ContenidoRecibido.Substring(1);
                        }

                        AgregarCliente(Equipo, Puerto, Cliente);
                        break;
                    } 
                    Thread.Sleep(100);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede ocupar el mismo socket");
            }
        }

        private void EnviarOrdenaCliente(TcpClient ClienteSel, string Orden)
        {
            try
            {
                InterfazNet.Send(ClienteSel, Orden);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarConexionCliente(ENT.Terminal_ENT Equipo)
        {
            Equipo.TCP = null;
            //eliminamos el puerto utilizado
            PuertosUtilizados.Remove(Equipo.Puerto);
            Equipo.Puerto = 0;
            Equipo.ReiniciarFactura();
            //cambiamos el estado del equipo en el servidor
            Ctrl_Terminales.EncontrarControlXNombre(Equipo.Equipo)
            .CambiarEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Apagado);
            string Notificacion = "El cliente " + Equipo.Equipo + " se ha desconectado";
            MostrarNotificacion(Notificacion);
        }

        private void AsignarEventosControlesTerminales()
        {
            try
            {
                CTRL.Terminal_CTRL Ctrl = Ctrl_Terminales.Controls.Cast<CTRL.Terminal_CTRL>().Last();

                Ctrl.Btn_Apagar.Click -= Btn_ApagarEquipo_Click;
                Ctrl.Btn_AgregarTiempo.Click -= Btn_AgregarTiempo_Click;
                Ctrl.Btn_Trasladar.Click -= Btn_TrasladarTiempo_Click;
                Ctrl.Btn_Facturar.Click -= Btn_Facturar_Click;
                Ctrl.Btn_Adicionales.Click -= Btn_Adicionales_Click;

                Ctrl.Btn_Adicionales.Click += Btn_Adicionales_Click;
                Ctrl.Btn_Facturar.Click += Btn_Facturar_Click;
                Ctrl.Btn_Trasladar.Click += Btn_TrasladarTiempo_Click;
                Ctrl.Btn_AgregarTiempo.Click += Btn_AgregarTiempo_Click;
                Ctrl.Btn_Apagar.Click += Btn_ApagarEquipo_Click;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AsignarTiempoAEquipo(CTRL.Terminal_CTRL Equipo, bool EsIlimitado, int Minutos)
        {
            try
            {
                BLL.Auditor_BLL Auditor = new BLL.Auditor_BLL();
                DateTime HoraInicio = DateTime.Now;
                string Descripcion;
                int Estado = 3;

                if (Equipo.Equipo.HoraInicio == new DateTime()) { Equipo.Equipo.HoraInicio = HoraInicio; }
                Equipo.Equipo.Estado = ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado;

                if (EsIlimitado)
                {
                    Equipo.Equipo.TieneTiempoIlimitado = EsIlimitado;
                    EnviarOrdenaCliente(Equipo.Equipo.TCP, "-1");
                }
                else
                {
                    TimeSpan TiempoAdicionar = new TimeSpan(0, Minutos, 0);
                    Equipo.Equipo.TiempoConsumir = Equipo.Equipo.TiempoConsumir + TiempoAdicionar;
                    Equipo.Equipo.Valor = Factura.ValorXTiempoConsumido(Convert.ToInt32(Equipo.Equipo.TiempoConsumir.TotalMinutes));
                    EnviarOrdenaCliente(Equipo.Equipo.TCP, "T" + Minutos.ToString());
                }

                //Guardamos el registro en base de datos
                Factura.Guardar(Equipo.Equipo, HoraInicio.ToShortDateString(), HoraInicio.ToLongTimeString(), Usuario.Usuario, Estado);

                //guardamos el registro de auditoria
                Descripcion = "El Usuario " + Usuario.Usuario + " Asigno Tiempo :"
                              + (EsIlimitado ? "Ilimitado" : Minutos.ToString())
                              + " Al Equipo " + Equipo.Equipo.Equipo + " En La Hora: " + HoraInicio.ToLongTimeString();
                Auditor.Registrar(Descripcion, Usuario.Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.AñadirTiempo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RealizarOperacion(CTRL.Terminal_CTRL Equipo, ENT.TiposAnidados_ENT.TipoOperacionFactura Operacion)
        {
            try
            {
                DateTime HoraSalida = DateTime.Now;
                int EstadoAnulacion = 4;
                int EstadoFacturacion = 3;

                BLL.Auditor_BLL Auditor = new BLL.Auditor_BLL();
                string Descripcion;
                switch(Operacion)
                {
                    case ENT.TiposAnidados_ENT.TipoOperacionFactura.Continuar:
                        EnviarOrdenaCliente(Equipo.Equipo.TCP, "Cont");
                        Equipo.CambiarEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado);
                        break;
                    case ENT.TiposAnidados_ENT.TipoOperacionFactura.Anular:
                        DialogResult Res = MessageBox.Show("¿Desea Anular Esta Factura?"
                                                           , "Anular"
                                                           , MessageBoxButtons.YesNo
                                                           , MessageBoxIcon.Exclamation);
                        if (Res == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (Configuraciones.EstaTiempoOcioActivo() 
                                && Convert.ToInt32(Equipo.Equipo.TiempoConsumido.TotalMinutes) <= ENT.TiposAnidados_ENT.MinutosOcio)
                            {
                                Descripcion = "Se anula el registro automático del equipo " + Equipo.Equipo 
                                              + " por no cumplir el tiempo de ocio a las " + HoraSalida.ToLongTimeString();
                                Auditor.Registrar(Descripcion, Usuario.Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.AnularFactura);
                                Factura.Eliminar(Equipo.Equipo);
                                Equipo.Equipo.ReiniciarFactura();
                                Equipo.ActualizarControles();
                            }
                            else
                            {
                                Descripcion = "El usuario " + Usuario.Usuario + " anuló la factura del equipo " + Equipo.Equipo 
                                              + "con tiempo consumido " + Equipo.Equipo.TiempoConsumido.Minutes.ToString();
                                Auditor.Registrar(Descripcion, Usuario.Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.AnularFactura);
                                //guardamos el registro
                                Factura.Guardar(Equipo.Equipo, Hoy.ToShortDateString(), HoraSalida.ToLongTimeString(), Usuario.Usuario, EstadoAnulacion);
                                //enviamos la orden de bloqueo del equipo
                                EnviarOrdenaCliente(Equipo.Equipo.TCP, "Bloq");
                                Equipo.Equipo.ReiniciarFactura();
                                Equipo.ActualizarControles();
                            }
                        }
                        break;
                    case ENT.TiposAnidados_ENT.TipoOperacionFactura.Facturar:
                        Descripcion = "El usuario " + Usuario.Usuario + " facturó al " + Equipo.Equipo 
                                      + "por valor de " + Equipo.Equipo.TotalFacturar.ToString() 
                                      + " en la hora " + HoraSalida.ToLongTimeString();
                        Auditor.Registrar(Descripcion, Usuario.Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.FacturaTiempo);
                        //guardamos el registro
                        Factura.Guardar(Equipo.Equipo, Hoy.ToShortDateString(), HoraSalida.ToLongTimeString(), Usuario.Usuario, EstadoFacturacion);
                        //enviamos la orden de bloqueo del equipo
                        EnviarOrdenaCliente(Equipo.Equipo.TCP, "Bloq");
                        Equipo.Equipo.ReiniciarFactura();
                        Equipo.ActualizarControles();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VerificarConexionCliente(ENT.Terminal_ENT Equipo)
        {
            try
            {
                bool EstaActivo = InterfazNet.ValidarConexion(Equipo.TCP);

                if (!EstaActivo)
                {
                    if (Equipo.Estado != ENT.TiposAnidados_ENT.EstadoTerminal.Apagado)
                    {
                        EliminarConexionCliente(Equipo);
                    }
                }

                Ctrl_Terminales.EncontrarControlXNombre(Equipo.Equipo).ActualizarControles();
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void MostrarNotificacion(string Notif)
        {
            Lbl_Notif.Text = Notif;
        }

        private void DefinirTotalesEstado()
        {
            try
            {
                Lbl_Disponible.Text = "Disponible (" + TotalPorEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Disponible) +")";
                Lbl_Detenido.Text = "Detenido (" + TotalPorEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Detenido) + ")";
                Lbl_Ocupado.Text = "Ocupado (" + TotalPorEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado) + ")";
                Lbl_Apagado.Text = "Desconectado (" + TotalPorEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Apagado) + ")";
                Lbl_Ilimitado.Text = "Ilimitado (" + TotalPorEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Ilimitado) + ")";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string TotalPorEstado(ENT.TiposAnidados_ENT.EstadoTerminal Estado)
        {
            if (Estado == ENT.TiposAnidados_ENT.EstadoTerminal.Ilimitado)
            {
                return Equipos.Count(E => E.TieneTiempoIlimitado).ToString();
            }
            else
            {
                return Equipos.Count(E => E.Estado == Estado).ToString();
            }
        }
        #endregion

        #region "Eventos Control Terminal"
        private void Btn_ApagarEquipo_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("¿Desea Apagar El Equipo Cliente?"
                                               , "Apagar"
                                               , MessageBoxButtons.YesNo
                                               , MessageBoxIcon.Hand);
            if (Res == DialogResult.OK)
            {
                TcpClient ClienteSel = ((CTRL.Terminal_CTRL)((Control)sender).Parent).Equipo.TCP;
                EnviarOrdenaCliente(ClienteSel, "SD");
            }
        }

        private void Btn_AgregarTiempo_Click(object sender, EventArgs e)
        {
            try
            {
                CTRL.Terminal_CTRL Equipo = (CTRL.Terminal_CTRL)((Control)sender).Parent;
                //validamos que el equipo se encuentre conectado
                switch(Equipo.Equipo.Estado)
                {
                    case ENT.TiposAnidados_ENT.EstadoTerminal.Apagado:
                    case ENT.TiposAnidados_ENT.EstadoTerminal.Detenido:
                        return;
                }
                
                if (Equipo.Equipo.TieneTiempoIlimitado)
                {
                    MessageBox.Show("El usuario está navegando con tiempo ilimitado, no es posible agregar tiempo");
                    return;
                }

                Frm_SelRango Frm_Sel = new Frm_SelRango(Equipo.Equipo);
                Frm_Sel.ShowDialog();
                if (!Frm_Sel.Esilimitado & Frm_Sel.Minutos == 0) { return; }

                AsignarTiempoAEquipo(Equipo, Frm_Sel.Esilimitado, Frm_Sel.Minutos);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_TrasladarTiempo_Click(object sender, EventArgs e)
        {
            string Descripcion;
            BLL.Auditor_BLL Auditor = new BLL.Auditor_BLL();
            CTRL.Terminal_CTRL Equipo = (CTRL.Terminal_CTRL)((Control)sender).Parent;
            CTRL.Terminal_CTRL Destino;
            List<string> Disponibles = (from Eq in Equipos
                                        where Eq.Estado == ENT.TiposAnidados_ENT.EstadoTerminal.Disponible
                                        select Eq.Equipo).ToList();

            if (Equipo.Equipo.Estado != ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado) { return; }
            if (Disponibles.Count == 0) { MessageBox.Show("No hay equipos disponibles para hacer cambio."); return; }
            //detenemos el equipo actual para hacer el traslado de equipo
            Equipo.CambiarEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Detenido);
            EnviarOrdenaCliente(Equipo.Equipo.TCP, "Bloq");
            //solicitamos la seleccion del equipo destino
            Frm_TrasladoEquipo Frm_Traslado = new Frm_TrasladoEquipo(Equipo.Equipo, Disponibles);
            Frm_Traslado.Show();
            //obtenemos el objeto destino
            Destino = Ctrl_Terminales.EncontrarControlXNombre(Frm_Traslado.DestinoSeleccionado);
            //asignamos las variables de la operacion vigente
            Destino.Equipo.TieneTiempoIlimitado = Equipo.Equipo.TieneTiempoIlimitado;
            Destino.Equipo.Estado = ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado;
            Destino.Equipo.HoraInicio = Equipo.Equipo.HoraInicio;
            Destino.Equipo.TiempoConsumido = Equipo.Equipo.TiempoConsumido;
            Destino.Equipo.TiempoConsumir = Equipo.Equipo.TiempoConsumir;
            Destino.Equipo.Valor = Equipo.Equipo.Valor;
            Equipo.Equipo.ProductosAdicionales.ForEach(I => Destino.Equipo.ProductosAdicionales.Add(
                                                            new ENT.Detalles_ENT()
                                                            {
                                                                Producto = I.Producto,
                                                                Cantidad = I.Cantidad,
                                                                ValorUnidad = I.ValorUnidad,
                                                                ValorTotal = I.ValorTotal
                                                            }));
            //habilitamos nuevamente el equipo
            Equipo.Equipo.ReiniciarFactura();
            Equipo.ActualizarControles();
            //enviamos la orden al destino
            if (Equipo.Equipo.TieneTiempoIlimitado)
            {
                EnviarOrdenaCliente(Destino.Equipo.TCP, "LI" + Destino.Equipo.TiempoConsumido.ToString());
            }
            else
            {
                TimeSpan TiempoRestante = Destino.Equipo.TiempoConsumir.Subtract(Destino.Equipo.TiempoConsumido);
                EnviarOrdenaCliente(Destino.Equipo.TCP, "I" + TiempoRestante.ToString());
            }

            Destino.ActualizarControles();

            Descripcion = "El usuario " + Usuario.Usuario + " traslado el tiempo del equipo " 
                          + Equipo.Equipo.Equipo + " al equipo " + Destino.Equipo.Equipo + "a las " + DateTime.Now.ToLongTimeString();
            Auditor.Registrar(Descripcion, Usuario.Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.TrasladarTiempo);
        }

        private void Btn_Adicionales_Click(object sender, EventArgs e)
        {
            try
            {
                CTRL.Terminal_CTRL Equipo = (CTRL.Terminal_CTRL)((Control)sender).Parent;

                if (Equipo.Equipo.Estado != ENT.TiposAnidados_ENT.EstadoTerminal.Apagado
                    & Equipo.Equipo.Estado != ENT.TiposAnidados_ENT.EstadoTerminal.Disponible)
                {
                    Application.DoEvents();
                    Frm_DetallesFactura FrmDetalles = new Frm_DetallesFactura(Equipo.Equipo);
                    FrmDetalles.Show();

                    Equipo.ActualizarControles();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Facturar_Click(object sender, EventArgs e)
        {
            try
            {
                CTRL.Terminal_CTRL Equipo = (CTRL.Terminal_CTRL)((Control)sender).Parent;

                //facturamos si el equipo se encuentra ocupado
                if (Equipo.Equipo.Estado != ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado
                    & Equipo.Equipo.Estado != ENT.TiposAnidados_ENT.EstadoTerminal.Detenido) { return; }

                //enviamos la orden de detener el equipo
                EnviarOrdenaCliente(Equipo.Equipo.TCP, "BB");
                Equipo.CambiarEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Detenido);

                //validamos si la configuracion permite tiempo de ocio.
                if(Configuraciones.EstaTiempoOcioActivo() 
                   && Convert.ToInt32(Equipo.Equipo.TiempoConsumido.TotalMinutes) <= ENT.TiposAnidados_ENT.MinutosOcio)
                {
                    DialogResult Res = MessageBox.Show("El Tiempo Consumido No Ha Superado El Tiempo De Ocio  ¿Desea Anular El Tiempo (Si) Ó Desea Continuar (No)?"
                                                       , "Advertencia ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (Res == DialogResult.Yes)
                    {
                        EnviarOrdenaCliente(Equipo.Equipo.TCP, "Bloq");
                        Equipo.Equipo.ReiniciarFactura();
                        Equipo.ActualizarControles();
                    }
                    else
                    {
                        EnviarOrdenaCliente(Equipo.Equipo.TCP, "Cont");
                        Equipo.CambiarEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado);
                    }
                }
                else
                {
                    //llamamos al formulario de factura.
                    Frm_Facturar Frm_Factura = new Frm_Facturar(Equipo.Equipo);
                    Frm_Factura.ShowDialog();
                    
                    if (Frm_Factura.OperacionSel != ENT.TiposAnidados_ENT.TipoOperacionFactura.Ninguna)
                    {
                        RealizarOperacion(Equipo, Frm_Factura.OperacionSel);
                    }
                    Application.DoEvents();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        protected void ActualizarMensajes(object sender, EventArgs e)
        {
            if (Rtb_Mensajes.TextLength == 0)
            {
                Rtb_Mensajes.Text = Host + "> " + ContenidoaActualizar;
            }
            else
            {
                Rtb_Mensajes.Text += "\r\n " + Host + "> " + ContenidoaActualizar;
            }
        }

        private void Btn_ApagarEquipos_Click(object sender, EventArgs e)
        {
            if (Equipos != null)
            {
                DialogResult Res = MessageBox.Show("¿Desea apagar los equipos seleccionados en la red?"
                                                   , "Apagar"
                                                   , MessageBoxButtons.YesNo
                                                   , MessageBoxIcon.Hand);
                if (Res == DialogResult.OK)
                {
                    Equipos.FindAll(E => E.Estado != ENT.TiposAnidados_ENT.EstadoTerminal.Apagado)
                           .ForEach(E => EnviarOrdenaCliente(E.TCP, "SD"));
                }
            }
        }

        private void Tmr_Servidor_Tick(object sender, EventArgs e)
        {
            int Puerto;
            //inicia la escucha
            Server.Start();
            //si hay solicitudes de conexion pendientes
            if (Server.Pending())
            {
                //obtenemos el cliente tcp
                ClienteConectar = Server.AcceptTcpClient();

                Puerto = ObtenerPuertoDisponible();
                InterfazNet.Send(ClienteConectar, Puerto.ToString());
                ConectarCon(Puerto);
                ClienteConectar.Close();
                ClienteConectar = new TcpClient();
            }
            Tmr_Cliente.Enabled = true;
        }

        private void Tmr_Cliente_Tick(object sender, EventArgs e)
        {
            try
            {
                List<ENT.Terminal_ENT> ClientesBuscar = Equipos.FindAll(E => E.TCP != null);
                string Puerto;
                int EstadoFactura = 3;
                string HoraSalida = DateTime.Now.ToLongTimeString();
                Configuraciones = new BLL.Configuraciones.AdminConfiguraciones_BLL();
                CTRL.Terminal_CTRL EquipoSel;

                Btn_ApagarEquipos.Enabled = (Equipos.Count > 0);

                foreach (ENT.Terminal_ENT cClient in ClientesBuscar)
                {
                    if (cClient.TCP != null && cClient.TCP.Available > 0)
                    {
                        EquipoSel = Ctrl_Terminales.EncontrarControlXNombre(cClient.Equipo);
                        ContenidoRecibido = InterfazNet.Get(cClient.TCP);
                        if (ContenidoRecibido.StartsWith("BB"))
                        {
                            Puerto = ContenidoRecibido.Substring(2);

                            //validamos que el sistema tenga habilitado tiempo de ocio para los equipos y
                            //que el tiempo consumido no este dentro del tiempo de ocio
                            if (Configuraciones.EstaTiempoOcioActivo() 
                                && Convert.ToInt32(EquipoSel.Equipo.TiempoConsumido.TotalMinutes) <= ENT.TiposAnidados_ENT.MinutosOcio)
                            {
                                MessageBox.Show("El Equipo " + cClient.Equipo + " Consumió Un Tiempo Inferior Al Tiempo De Ocio, Razón Por La Que El Tiempo No Ha Sido Facturado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                Factura.Guardar(cClient, Hoy.ToShortDateString(), HoraSalida, Usuario.Usuario, EstadoFactura);
                                MessageBox.Show("El Tiempo Consumido : " + Convert.ToInt32(cClient.TiempoConsumido.TotalMinutes).ToString() 
                                                + " Min \r Equipo Utilizado : " + cClient.Equipo 
                                                + " \r Hora Inicio : " + cClient.HoraInicio.ToLongTimeString() 
                                                + " \r Hora Salida : " + HoraSalida 
                                                + " \r Total : " + cClient.TotalFacturar, "Orden Facturada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                cClient.ReiniciarFactura();
                                EquipoSel.Equipo.ReiniciarFactura();
                                EquipoSel.ActualizarControles();
                            }
                        }
                        else if (ContenidoRecibido.StartsWith("TF"))
                        {
                            //si el servidor recibe pero el cliente aparece conectado en estado distinto, 
                            //se procede a buscar el ultimo registro de factura para el cliente y continuar.
                            if (cClient.Estado == ENT.TiposAnidados_ENT.EstadoTerminal.Apagado 
                                | cClient.Estado == ENT.TiposAnidados_ENT.EstadoTerminal.Disponible)
                            {
                                Factura.ObtenerFactura(cClient);
                                EquipoSel.CambiarEstado(ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado);
                            }

                            String tiempo = ContenidoRecibido.Substring(2);
                            cClient.TiempoConsumido = new TimeSpan(Convert.ToInt32(tiempo.Substring(0,2))
                                                                   , Convert.ToInt32(tiempo.Substring(3,2))
                                                                   ,Convert.ToInt32(tiempo.Substring(6,2)));
                            cClient.TiempoConsumido = cClient.TiempoConsumido.Add(new TimeSpan(0, 0, 1));
                            EquipoSel.Equipo.TiempoConsumido = cClient.TiempoConsumido;
                            EquipoSel.Equipo.Valor = Factura.ValorXTiempoConsumido(Convert.ToInt32(EquipoSel.Equipo.TiempoConsumido.TotalMinutes));
                            EquipoSel.ActualizarControles();
                        }
                        else if (ContenidoRecibido.StartsWith("SS"))
                        {
                            Puerto = ContenidoRecibido.Substring(2);
                            EliminarConexionCliente(cClient);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void Tmr_Estados_Tick(object sender, EventArgs e)
        {
            Equipos.FindAll(E => E.TCP != null)
                   .ForEach(E => VerificarConexionCliente(E));
            DefinirTotalesEstado();
        }

        private void Tmr_Temporales_Tick(object sender, EventArgs e)
        {
            List<ENT.Terminal_ENT> Ocupados = Equipos.FindAll(E => E.Estado == ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado);

            foreach (ENT.Terminal_ENT Equipo in Ocupados)
            {
                if (Configuraciones.EstaTiempoOcioActivo())
                {
                    if (Convert.ToInt32(Equipo.TiempoConsumido.TotalMinutes) > ENT.TiposAnidados_ENT.MinutosOcio)
                    {
                        Factura.GuardarTemporal(Equipo, Usuario.Usuario);
                    }
                }
                else
                {
                    Factura.GuardarTemporal(Equipo, Usuario.Usuario);
                }
            }
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string Descripcion = "El Usuario " + Usuario.Usuario + " Cerro Sesión A La Hora : " + DateTime.Now.ToLongTimeString();
            BLL.Auditor_BLL Auditor = new BLL.Auditor_BLL();
            Auditor.Registrar(Descripcion, Usuario.Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.CerrarSesion);
            Enviando = true;
            //enviamos la orden de apagado a todos los equipos que se encuentren conectados
            Equipos.FindAll(E => E.TCP != null && !E.TCP.Connected).ForEach(E => EnviarOrdenaCliente(E.TCP, "SS"));
            Sock.Close();
            Recibir.Abort();
            Server.Stop();
        }

        private void Frm_Principal_Activated(object sender, EventArgs e)
        {
            if (!this.Enabled)
            {
                this.Enabled = !this.Enabled;
            }
        }

        #region "Mensajeria"
        private void Rtb_Mensajes_TextChanged(object sender, EventArgs e)
        {
            Rtb_Mensajes.SelectionStart = Rtb_Mensajes.TextLength;
            Rtb_Mensajes.ScrollToCaret();
        }

        private void Txt_Mensaje_TextChanged(object sender, EventArgs e)
        {
            Btn_Enviar.Enabled = (Txt_Mensaje.TextLength > 0);
        }

        private void Cmb_Equipos_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string Equipo = Cmb_Equipos.Text;
                TcpClient Cliente = Ctrl_Terminales.EncontrarControlXNombre(Equipo).Equipo.TCP;
                EnviarOrdenaCliente(Cliente, "SMS");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            IPEndPoint DirDest = new IPEndPoint(IPAddress.Broadcast, 5103);
            byte[] DateBytes = Encoding.Default.GetBytes(Txt_Mensaje.Text);
            Sock.SendTo(DateBytes, DateBytes.Length, SocketFlags.None, DirDest);
            Txt_Mensaje.Clear();
            Txt_Mensaje.Focus();
        }

        #endregion

        #region "Items del Menu"
        private void Tsmi_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tsmi_CambiarUsu_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("¿Cambiar De Usuario?"
                                               , "Cambiar Usuario"
                                               , MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (Res == DialogResult.Yes)
            {
                string Descripcion = "El Usuario " + Usuario.Usuario + " Cerro Sesion A La Hora : " + DateTime.Now.ToLongTimeString();
                BLL.Auditor_BLL Auditor = new BLL.Auditor_BLL();
                Auditor.Registrar(Descripcion, Usuario.Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.CerrarSesion);

                this.Enabled = false;

                Frm_Login Fl = new Frm_Login(false);
                Fl.ShowDialog();
            }
        }

        private void Tsmi_Usuarios_Click(object sender, EventArgs e)
        {
            Frm_AdminUsuarios Frm_AdminUsu = new Frm_AdminUsuarios();
            Frm_AdminUsu.ShowDialog();
        }

        private void Tsmi_Configuraciones_Click(object sender, EventArgs e)
        {
            try
            {
                string Nombre = "";
                GUI.Configuraciones.Frm_Configuraciones FrmConfig = new Configuraciones.Frm_Configuraciones();
                FrmConfig.ShowDialog();

                if (FrmConfig.ActualizarNombreServidor)
                {
                    //enviamos un mensaje a todos los clientes para actualizar el nombre del servidor.
                    Nombre = Configuraciones.ObtenerRazonSocial();
                    Equipos.FindAll(E => E.TCP != null && E.TCP.Connected).ForEach(E => EnviarOrdenaCliente(E.TCP, "N" + Nombre));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tsmi_Auditoria_Click(object sender, EventArgs e)
        {
            GUI.Auditoria.Frm_Auditoria FrmAuditor = new Auditoria.Frm_Auditoria();
            FrmAuditor.Show();
        }

        private void Tsmi_Consolidado_Click(object sender, EventArgs e)
        {
            GUI.Consolidado.Frm_VentasDiarias FrmVentas = new Consolidado.Frm_VentasDiarias();
            FrmVentas.Show();
        }

        private void Tsmi_VerUltimos_Click(object sender, EventArgs e)
        {
            Frm_UltimasConex FrmUltimos = new Frm_UltimasConex();
            FrmUltimos.Show();
        }
        #endregion

        private void Tsmi_Creditos_Click(object sender, EventArgs e)
        {
            Frm_Creditos FrmCredit = new Frm_Creditos();
            FrmCredit.Show();
        }


    }
}
