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
    public partial class Frm_SelRango : Form
    {
        ENT.Terminal_ENT Equipo;
        BLL.Configuraciones.AdminConfiguraciones_BLL Config = new BLL.Configuraciones.AdminConfiguraciones_BLL();

        public bool Esilimitado = false;
        public int Minutos = 0;

        public Frm_SelRango(ENT.Terminal_ENT EquipoSel)
        {
            InitializeComponent();
            Equipo = EquipoSel;
            Lbl_Titulo.Text = Equipo.Equipo;
        }

        private void Frm_SelRango_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }

        #region "Metodos & Funciones"
        private void LlenarCombo()
        {
            Cmb_Rango.DataSource = Config.ObtenerRangosTiempo();
            Cmb_Rango.SelectedIndex = -1;
        }

        private string ObtenerCadenaNumerica(string Texto)
        {
            string CadenaResultante = "";
            Texto.ToCharArray().ToList()
                               .FindAll(C => Char.IsNumber(C))
                               .ForEach(C => CadenaResultante = CadenaResultante + C.ToString());
            return CadenaResultante;
        }

        private bool EsNumerico(string Texto)
        {
            bool EsNumerico = false;
            EsNumerico = !Texto.ToCharArray().ToList().Any(C => !Char.IsNumber(C));
            return EsNumerico;
        }

        #endregion

        private void Btn_Aceptar_Click(object sender, EventArgs e)
        {
            string Contenido = Cmb_Rango.Text;
            if (Contenido.Length == 0) { Cmb_Rango.Focus(); return; }
            if (Contenido.Length <= 3)
            {
                if (EsNumerico(Contenido))
                {
                    Minutos = Convert.ToInt32(Contenido);
                }
                else
                {
                    Cmb_Rango.Text = "";
                    Cmb_Rango.Focus();
                    return;
                }
            }
            else if (Config.ObtenerRangosTiempo().Contains(Contenido))
            {
                if (Contenido == "Ilimitado")
                {
                    Esilimitado = true;
                }
                else
                {
                    Minutos = Convert.ToInt32(ObtenerCadenaNumerica(Contenido));
                }
            }
            else
            {
                Cmb_Rango.Focus(); 
                return;
            }
            this.Close();
        }

    }
}
