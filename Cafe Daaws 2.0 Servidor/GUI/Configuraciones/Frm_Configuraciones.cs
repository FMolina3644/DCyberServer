using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor.GUI.Configuraciones
{
    public partial class Frm_Configuraciones : Form
    {
        BLL.Configuraciones.AdminConfiguraciones_BLL Config = new BLL.Configuraciones.AdminConfiguraciones_BLL();
        Formato.Presentacion Util = new Formato.Presentacion();
        public bool ActualizarNombreServidor = false;

        int PlantillaSeleccionada = 0;

        public Frm_Configuraciones()
        {
            InitializeComponent();
        }

        private void Frm_Configuraciones_Load(object sender, EventArgs e)
        {
            LlenarDatos();
        }

        #region "Metodos & Funciones"
        private void LlenarDatos()
        {
            Txt_RazonSocial.Text = Config.ObtenerRazonSocial();
            Chb_PermitirOcio.Checked = Config.EstaTiempoOcioActivo();
            CargarValoresPlantillas();

            PlantillaSeleccionada = Config.ObtenerPlantillaSeleccionada();
            SeleccionarPanel();

        }

        private void SeleccionarPanel()
        {
            string CadenaBuscar = "Pnl_Plantilla";
            List<Control> Ctrls = Pnl_Plantillas.Controls.Cast<Control>().ToList().FindAll(C => C.Name.Contains(CadenaBuscar));

            Ctrls.FindAll(C => C.Name == CadenaBuscar + PlantillaSeleccionada.ToString()).ForEach(C => C.BackColor = Color.LightBlue);
            Ctrls.FindAll(C => C.Name != CadenaBuscar + PlantillaSeleccionada.ToString()).ForEach(C => C.BackColor = Color.LightGray);

        }

        private void CargarValoresPlantillas()
        {
            string CadenaBuscar = "Pnl_Plantilla";
            //obtenemos los paneles con su respectiva plantilla
            List<Control> Ctrls = Pnl_Plantillas.Controls.Cast<Control>().ToList()
                                  .FindAll(C => C.Name.Contains(CadenaBuscar));
            //por cada panel buscamos los controles y asignamos su valor
            Ctrls.ForEach(C => C.Controls.Cast<Control>().ToList()
                               .FindAll(Ch => Ch.Tag != null  & Ch.Name.Contains("Txt"))
                               .ForEach(Txt => Txt.Text = Config.ConsultarValoresPlantilla(
                                                                 Convert.ToInt32(C.Tag)
                                                                 , Convert.ToInt32(Txt.Tag))));
        }

        private void Guardar()
        {
            try
            {
                List<ENT.ItemPlantilla_ENT> ItemsGuardar = new List<ENT.ItemPlantilla_ENT>();
                List<ENT.ItemPlantilla_ENT> ItemsActualizar = new List<ENT.ItemPlantilla_ENT>();
                //validamos que los items de la plantilla seleccionada contengan valores
                string CadenaBuscar = "Pnl_Plantilla";
                bool HayCamposVacios = Pnl_Plantillas.Controls.Cast<Control>().ToList()
                                        .Find(C => C.Name.Contains(CadenaBuscar + PlantillaSeleccionada.ToString()))
                                        .Controls.Cast<Control>().ToList()
                                        .FindAll(Ch => Ch.Tag != null & Ch.Name.Contains("Txt"))
                                        .Any(Ch => string.IsNullOrEmpty(Ch.Text));
                if (HayCamposVacios)
                {
                    MessageBox.Show("Todos los rangos de la plantilla deben estar seleccionados");
                    return;
                }

                ENT.TiposAnidados_ENT.Plantilla PlantillaOcio = (ENT.TiposAnidados_ENT.Plantilla)Convert.ToInt32(Chb_PermitirOcio.Tag);
                ENT.TiposAnidados_ENT.Estado EstadoActivaOcio = Chb_PermitirOcio.Checked ? ENT.TiposAnidados_ENT.Estado.ACTIVO : ENT.TiposAnidados_ENT.Estado.INACTIVO;
                ItemsActualizar.Add(new ENT.ItemPlantilla_ENT(PlantillaOcio,1,0,EstadoActivaOcio));

                //cambiamos el estado de los items de la plantilla no seleccionada
                Pnl_Plantillas.Controls.Cast<Control>().ToList()
                .Find(C => C.Name != CadenaBuscar + PlantillaSeleccionada.ToString() && C.Name.Contains(CadenaBuscar))
                .Controls.Cast<Control>().ToList()
                .FindAll(Ch => Ch.Tag != null & Ch.Name.Contains("Txt"))
                .ForEach(Ch => ItemsActualizar.Add(new ENT.ItemPlantilla_ENT((ENT.TiposAnidados_ENT.Plantilla)Convert.ToInt32(Ch.Parent.Tag)
                                                                    , Convert.ToInt32(Ch.Tag)
                                                                    , 0
                                                                    , ENT.TiposAnidados_ENT.Estado.INACTIVO)));

                //actualizamos valor y activamos los items de la plantilla seleccionada
                Pnl_Plantillas.Controls.Cast<Control>().ToList()
                .Find(C => C.Name.Contains(CadenaBuscar + PlantillaSeleccionada.ToString()))
                .Controls.Cast<Control>().ToList()
                .FindAll(Ch => Ch.Tag != null & Ch.Name.Contains("Txt"))
                .ForEach(Ch => ItemsGuardar.Add(new ENT.ItemPlantilla_ENT((ENT.TiposAnidados_ENT.Plantilla)PlantillaSeleccionada
                                                                    , Convert.ToInt32(Ch.Tag)
                                                                    , Convert.ToInt32(Ch.Text)
                                                                    , ENT.TiposAnidados_ENT.Estado.ACTIVO)));

                Config.ActualizarEstadoItem(ItemsActualizar);
                Config.GuardarValoresPlantilla(ItemsGuardar);

                MessageBox.Show("Plantilla Actualizada con éxito");
                LlenarDatos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void Btn_AceptarRazon_Click(object sender, EventArgs e)
        {
            //Actualizamos la razon social
            Config.ActualizarRazonSocial(Txt_RazonSocial.Text);
            ActualizarNombreServidor = true;

            if (MessageBox.Show("¿Desea realizar otros cambios en las configuraciones?"
                                , "Confirmar Cambio"
                                ,MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                this.Close();
            }
        }

        private void Btn_Sel1_Click(object sender, EventArgs e)
        {
            PlantillaSeleccionada = Convert.ToInt32(((Control)sender).Tag);
            SeleccionarPanel();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_0_15_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.KeyPress_Numerico(ref sender, ref e);
        }

        private void Btn_Restaurar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea restaurar los parametros por defecto"
                , "Restaurar por defecto"
                , MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                Config.RestaurarValoresDefaultPlantillas();
                LlenarDatos();
            }
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

    }
}
