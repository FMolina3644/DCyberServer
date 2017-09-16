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
    public partial class Frm_Facturar : Form
    {
        Formato.Presentacion Util = new Formato.Presentacion();
        public ENT.TiposAnidados_ENT.TipoOperacionFactura OperacionSel = ENT.TiposAnidados_ENT.TipoOperacionFactura.Ninguna;
        ENT.Terminal_ENT Equipo;

        public Frm_Facturar(ENT.Terminal_ENT EquipoSel)
        {
            InitializeComponent();
            Equipo = EquipoSel;
        }

        private void Frm_Facturar_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        #region "Metodos & Funciones"
        private void LlenarDatos()
        {
            Lbl_ValEquipo.Text = Equipo.Equipo;
            Lbl_ValHoraIni.Text = Equipo.HoraInicio.ToLongTimeString();
            if (Equipo.TieneTiempoIlimitado)
            {
                Lbl_ValConsumo.Text = "Ilimitado";
            }
            else
            {
                Lbl_ValConsumo.Text = Equipo.TiempoConsumir.ToString();
            }
            Lbl_ValConsumido.Text = Equipo.TiempoConsumido.ToString();
            Lbl_ValValor.Text = Util.AplicarFormatoDinero(Equipo.Valor.ToString());
            Lbl_ValAdic.Text = Util.AplicarFormatoDinero(Equipo.TotalItems.ToString());
            Lbl_ValTotal.Text = Util.AplicarFormatoDinero(Equipo.TotalFacturar.ToString());
            Lnk_Items.Text = "Ver Items (" + Equipo.ProductosAdicionales.Count.ToString() + ")";
        }

        #endregion

        private void Btn_Facturar_Click(object sender, EventArgs e)
        {
            OperacionSel = (ENT.TiposAnidados_ENT.TipoOperacionFactura)Convert.ToInt32(((Control)sender).Tag);
            this.Close();
        }

        private void Lnk_Items_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.DoEvents();
            Frm_DetallesFactura FrmDetalles = new Frm_DetallesFactura(Equipo);
            FrmDetalles.ShowDialog();

            LlenarDatos();
        }

    }
}
