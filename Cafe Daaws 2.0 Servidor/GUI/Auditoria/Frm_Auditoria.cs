using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor.GUI.Auditoria
{
    public partial class Frm_Auditoria : Form
    {
        BLL.AdminUsuarios.GestorUsuarios_BLL UsuariosBLL = new BLL.AdminUsuarios.GestorUsuarios_BLL();
        BLL.Auditor_BLL Auditor = new BLL.Auditor_BLL();

        public Frm_Auditoria()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Auditoria_Load(object sender, EventArgs e)
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
            List<int> AccionesSeleccionadas = new List<int>();
            DateTime Fecha = Dtp_Fecha.Value.Date;
            //validamos que se haya seleccionado al menos una accion
            List<CheckBox> CtrlsAccionesSeleccionadas = Pnl_Acciones.Controls.Cast<CheckBox>().ToList()
                                                        .FindAll(C => C.Tag != null && C.Checked);

            if (CtrlsAccionesSeleccionadas.Count == 0)
            {
                Chb_Todos.Checked = true;
                Consultar();
                return;
            }

            CtrlsAccionesSeleccionadas.ForEach(C => AccionesSeleccionadas.Add(Convert.ToInt32(C.Tag)));
            Dtg_Reporte.DataSource = Auditor.Consultar(Fecha, AccionesSeleccionadas, Cmb_Usuario.Text);
            Lbl_ValRegistros.Text = Dtg_Reporte.RowCount.ToString();
        }

        private void SeleccionarTodos()
        {
            Pnl_Acciones.Controls.Cast<CheckBox>().ToList()
            .FindAll(C => C.Tag != null)
            .ForEach(C => C.Checked = true);
        }

        #endregion

        private void Chb_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (Chb_Todos.Checked)
            {
                SeleccionarTodos();
            }
        }

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Btn_ExportarPdf_Click(object sender, EventArgs e)
        {
            try
            {
                ExportadorArchivo toPdf = new ExportadorArchivo(Dtg_Reporte, "Seguimiento");
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }
    }
}
