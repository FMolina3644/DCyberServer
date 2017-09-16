using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor.CTRL
{
    public partial class Terminal_CTRL : UserControl
    {
        public ENT.Terminal_ENT Equipo;
        Formato.Presentacion Util = new Formato.Presentacion();

        public Terminal_CTRL(ENT.Terminal_ENT Equipo)
        {
            InitializeComponent();
            this.Equipo = Equipo;
        }

        private void Terminal_CTRL_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        #region "Metodos & Funciones"
        private void LlenarDatos()
        {
            Lbl_Nombre.Text = Equipo.Equipo;

            Lbl_ValTiempo.Text = Util.AplicarFormatoDinero(Equipo.Valor.ToString());
            Lbl_ValAdicional.Text = Util.AplicarFormatoDinero(Equipo.TotalItems.ToString());
            Lbl_ValTotal.Text = Util.AplicarFormatoDinero(Equipo.TotalFacturar.ToString());

            Lbl_ValHoraInicio.Text = Equipo.HoraInicio.ToShortTimeString();
            if (Equipo.TieneTiempoIlimitado)
            {
                Lbl_ValTiempoConsumir.Text = "Ilimitado";
            }
            else
            {
                Lbl_ValTiempoConsumir.Text = Equipo.TiempoConsumir.Hours.ToString("0#")
                                         + ":" + Equipo.TiempoConsumir.Minutes.ToString("0#");
            }
            Lbl_ValTiempoConsumido.Text = Equipo.TiempoConsumido.Hours.ToString("0#") 
                                          + ":" + Equipo.TiempoConsumido.Minutes.ToString("0#")
                                          + ":" + Equipo.TiempoConsumido.Seconds.ToString("0#");

            Btn_Adicionales.Text = "(" + Equipo.ProductosAdicionales.Count().ToString() + ")";
            Pnl_Facturacion.Visible = (Equipo.HoraInicio != new DateTime());
            DefinirColorPorEstado();
        }

        private void DefinirColorPorEstado()
        {
            Color ColorAsignar = Color.White;
            if (Equipo.TieneTiempoIlimitado)
            {
                ColorAsignar = Color.Black;
            }
            else
            {
                switch (Equipo.Estado)
                {
                    case ENT.TiposAnidados_ENT.EstadoTerminal.Disponible:
                        ColorAsignar = Color.MediumSeaGreen;
                        break;
                    case ENT.TiposAnidados_ENT.EstadoTerminal.Detenido:
                        ColorAsignar = Color.Violet;
                        break;
                    case ENT.TiposAnidados_ENT.EstadoTerminal.Ocupado:
                        ColorAsignar = Color.Yellow;
                        break;
                    case ENT.TiposAnidados_ENT.EstadoTerminal.Apagado:
                        ColorAsignar = Color.DarkRed;
                        break;
                    case ENT.TiposAnidados_ENT.EstadoTerminal.Ilimitado:
                        ColorAsignar = Color.Black;
                        break;
                }
            }

            Ptb_Estado1.BackColor = ColorAsignar;
        }

        public void CambiarEstado(ENT.TiposAnidados_ENT.EstadoTerminal NueEstado)
        {
            Equipo.Estado = NueEstado;
            DefinirColorPorEstado();
            ActualizarControles();
        }

        public void ActualizarControles()
        {
            LlenarDatos();
        }
        #endregion

        private void Btn_VerOpciones_Click(object sender, EventArgs e)
        {
            Boolean EstadoActual = Btn_Apagar.Visible;
            Btn_Apagar.Visible = !EstadoActual;
            Btn_Trasladar.Visible = !EstadoActual;
        }

    }
}
