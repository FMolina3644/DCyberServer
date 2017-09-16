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
    public partial class Frm_TrasladoEquipo : Form
    {
        ENT.Terminal_ENT Equipo;
        public string DestinoSeleccionado = "";
        public Frm_TrasladoEquipo(ENT.Terminal_ENT EquipoSel, List<string> Disponibles)
        {
            InitializeComponent();
            Equipo = EquipoSel;
            Cmb_Destino.DataSource = Disponibles;
            Cmb_Destino.SelectedIndex = -1;
        }

        private void Frm_TrasladoEquipo_Load(object sender, EventArgs e)
        {
            Lbl_Origen.Text = "De: " + Equipo.Equipo;
        }

        private void Btn_Traslado_Click(object sender, EventArgs e)
        {
            if (Cmb_Destino.SelectedIndex == -1)
            {
                Cmb_Destino.Focus();
                return;
            }

            DestinoSeleccionado = Cmb_Destino.Text;
            this.Close();
        }

        private void Frm_TrasladoEquipo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DestinoSeleccionado == "")
            {
                Cmb_Destino.Focus();
                e.Cancel = true;
            }
        }

    }
}
