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
    public partial class ContTerminales_CTRL : UserControl
    {
        public ContTerminales_CTRL()
        {
            InitializeComponent();
        }

        private void ContTerminales_CTRL_Load(object sender, EventArgs e)
        {

        }

        #region "Metodos & Funciones"
        public void AgregarControl(ENT.Terminal_ENT Equipo)
        {
            try
            {
                CTRL.Terminal_CTRL CtrlTerminal = new Terminal_CTRL(Equipo);
                CtrlTerminal.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                CtrlTerminal.Width = this.Width - 20;
                Controls.Add(CtrlTerminal);
                ReorganizarControles();
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void ReorganizarControles()
        {
            try
            {
                int Indice = 0;
                int EspacioEntreCtrls = 2;
                int TotalEspacio = 0;
                int Sangria = 2;
                foreach (Control Ctrl in Controls)
                {
                    TotalEspacio = Indice * EspacioEntreCtrls;
                    Ctrl.Location = new Point(Sangria, (Ctrl.Height * Indice) + TotalEspacio + EspacioEntreCtrls);
                    Indice += 1;
                }
                this.Refresh();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public CTRL.Terminal_CTRL EncontrarControlXNombre(string Nombre)
        {
            return Controls.Cast<CTRL.Terminal_CTRL>().ToList()
                   .Find(C => C.Equipo.Equipo == Nombre);
        }
        #endregion
    }
}