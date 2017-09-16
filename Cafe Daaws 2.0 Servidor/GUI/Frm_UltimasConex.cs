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
    public partial class Frm_UltimasConex : Form
    {
        public Frm_UltimasConex()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        #region "Metodos & Funciones"
        private void InicializarFormulario()
        {
            BLL.Facturador_BLL Facturar = new BLL.Facturador_BLL();
            Dtg_Temporales.DataSource = Facturar.ConsultarFacturasTemporales();
        }
        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
