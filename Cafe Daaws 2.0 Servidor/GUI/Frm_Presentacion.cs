using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Cafe_Daaws_2._0_Servidor.GUI
{
    public partial class Frm_Presentacion : Form
    {
        Stopwatch Cronos = new Stopwatch();

        public Frm_Presentacion()
        {
            InitializeComponent();
        }

        private void Frm_Presentacion_Load(object sender, EventArgs e)
        {
            Tm_Permitido.Start();
            Cronos.Start();
        }

        #region "Metodos & Funciones"
        private void LlamarLogin()
        {
            Frm_Login FrmLogin = new Frm_Login();
            FrmLogin.Show();
        }
        #endregion

        private void Tm_Permitido_Tick(object sender, EventArgs e)
        {
            int Segundos = Convert.ToInt32(Cronos.Elapsed.TotalSeconds);
            if(Segundos == 3)
            {
                this.Close();
            }
        }

        private void Frm_Presentacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            LlamarLogin();
        }
    }
}
