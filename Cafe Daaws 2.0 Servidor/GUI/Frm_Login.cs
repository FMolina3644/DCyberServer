using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor.GUI
{
    public partial class Frm_Login : Form
    {
        bool PuedeCerrar = false;
        bool OcultarFormulario = true;
        ENT.Usuario_ENT UsuarioAct;

        public Frm_Login(bool Ocultar = true)
        {
            InitializeComponent();
            PuedeCerrar = true;
            OcultarFormulario = Ocultar;
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Btn_Salir.Visible = OcultarFormulario;
            Btn_Salir.Enabled = OcultarFormulario;
        }

        #region "Metodos & Funciones"
        private bool ValidarCampos()
        {
            if (Txt_Usuario.TextLength == 0)
            {
                Txt_Usuario.Focus();
                return false;
            }
            if (Txt_Contraseña.TextLength == 0)
            {
                Txt_Contraseña.Focus();
                return false;
            }

            return true;
        }

        private void Ingresar()
        {
            try
            {
                string Usuario;
                string Contraseña;
                string Momento;
                string Descripcion;

                BLL.Auditor_BLL Auditor = new BLL.Auditor_BLL();
                BLL.Autenticador.Autenticador_BLL Autenticador;

                Momento = DateTime.Now.ToLongTimeString();
                Descripcion = "El Usuario " + Txt_Usuario.Text.ToUpper() + " Inicio Sesion A La Hora : " + Momento;
                Usuario = Txt_Usuario.Text;
                Contraseña = Txt_Contraseña.Text;

                Autenticador = new BLL.Autenticador.Autenticador_BLL(Usuario, Contraseña);

                if (Autenticador.EstadoValidacion == ENT.TiposAnidados_ENT.TipoValidacion.UsuarioInexistente)
                {
                    MessageBox.Show("El usuario ingresado no existe", "Acceso denegado");
                    Txt_Usuario.Text = "";
                    Txt_Contraseña.Text = "";
                    Txt_Usuario.Focus();
                }
                else if(Autenticador.EstadoValidacion == ENT.TiposAnidados_ENT.TipoValidacion.ContraseñaIncorrecta)
                {
                    MessageBox.Show("La contraseña ingresada no es la correcta", "Acceso denegado");
                    Txt_Contraseña.Text = "";
                    Txt_Contraseña.Focus();
                }
                else if(Autenticador.EstadoValidacion == ENT.TiposAnidados_ENT.TipoValidacion.EstadoInhabilitado)
                {
                    MessageBox.Show("El usuario presenta algun tipo de bloqueo asignado por el administrador", "Consultar con el administrador");
                }
                else
                {
                    UsuarioAct = Autenticador.UsuarioBLL.Usuario;
                    if (OcultarFormulario)
                    {
                        Frm_Principal frm = new Frm_Principal(UsuarioAct);
                        frm.Show();
                    }

                    Auditor.Registrar(Descripcion, Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria.IniciarSesion);
                    PuedeCerrar = false;
                    this.Close();
                }
            }
            catch(Exception )
            {
                throw;
            }
        }
        #endregion

        private void Frm_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(PuedeCerrar)
            {
                Application.Exit();
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos()) { return; }
                Ingresar();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            if (!OcultarFormulario)
            {
                PuedeCerrar = false;
                this.Close();
                Frm_Principal fs = new Frm_Principal(UsuarioAct);
                fs.Show();
            }
            else
            {
                PuedeCerrar = true;
                Application.Exit();
            }
        }

    }
}
