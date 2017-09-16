using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor.GUI.Consolidado
{
    public partial class Frm_VentasDiarias : Form
    {
        BLL.AdminUsuarios.GestorUsuarios_BLL UsuariosBLL = new BLL.AdminUsuarios.GestorUsuarios_BLL();
        BLL.Facturador_BLL Facturador = new BLL.Facturador_BLL();

        public Frm_VentasDiarias()
        {
            InitializeComponent();
        }

        private void Frm_VentasDiarias_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        #region "Metodos & Funciones"
        private void InicializarFormulario()
        {
            LlenarCombo();
            Dtp_Fecha.MaxDate = DateTime.Today;
            Consultar();
        }

        private void LlenarCombo()
        {
            Cmb_Usuario.DataSource = UsuariosBLL.UsuariosParaAuditoria();
            Cmb_Usuario.SelectedIndex = -1;
        }

        private void Consultar()
        {
            DateTime Fecha = Dtp_Fecha.Value.Date;
            Dtg_Reporte.DataSource = Facturador.ConsultarFacturas(Fecha, Cmb_Usuario.Text);
            Lbl_ValRegistros.Text = Dtg_Reporte.RowCount.ToString();
            if (Dtg_Reporte.RowCount > 0)
            {
                Lbl_ValFacturado.Text = Dtg_Reporte.Rows.Cast<DataGridViewRow>()
                                        .Sum(F => Convert.ToDecimal(F.Cells[2].Value)).ToString();
            }
        }

        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Btn_ExportarPdf_Click(object sender, EventArgs e)
        {
            if (Dtg_Reporte.RowCount > 0) { ExportadorArchivo Exportador = new ExportadorArchivo(Dtg_Reporte, "Consolidado"); }
        }

    }
}
