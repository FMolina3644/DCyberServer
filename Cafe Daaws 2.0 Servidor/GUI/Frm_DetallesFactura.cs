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
    public partial class Frm_DetallesFactura : Form
    {
        Formato.Presentacion Util = new Formato.Presentacion();
        BLL.Facturador_BLL Factura = new BLL.Facturador_BLL();

        ENT.Terminal_ENT Equipo;
        ENT.Detalles_ENT NDetalle;

        public Frm_DetallesFactura(ENT.Terminal_ENT EquipoSel)
        {
            InitializeComponent();
            Equipo = EquipoSel;
        }

        private void Frm_DetallesFactura_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        #region "Metodos & Funciones"
        private void InicializarFormulario()
        {
            Lbl_Equipo.Text = Equipo.Equipo;
            ActivarPanel((Equipo.ProductosAdicionales.Count == 0));
            Dtg_Detalles.AutoGenerateColumns = false;
            Dtg_Detalles.DataSource = null;
            if (Equipo.ProductosAdicionales.Count > 0)
            {
                Dtg_Detalles.DataSource = Equipo.ProductosAdicionales;
            }
            Dtg_Detalles.Refresh();
            this.Refresh();
        }

        private void ActivarPanel(bool EsNuevo)
        {
            if (EsNuevo)
            {
                Pnl_Nuevo.Visible = true;
                Pnl_Detalles.Visible = false;

                Txt_Producto.Clear();
                Txt_ValorUnidad.Clear();
                Txt_Unidades.Clear();

                NDetalle = new ENT.Detalles_ENT();
                Txt_Producto.Focus();
            }
            else
            {
                NDetalle = new ENT.Detalles_ENT();
                Pnl_Nuevo.Visible = false;
                Pnl_Detalles.Visible = true;
            }
        }

        private void CalcularTotal()
        {
            NDetalle.CalcularTotal();
            Lbl_ValTotal.Text = Util.AplicarFormatoDinero(NDetalle.ValorTotal.ToString());
        }

        private void AgregarDetalle()
        {
            try
            {
                if (string.IsNullOrEmpty(Txt_Producto.Text))
                {
                    Txt_Producto.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(Txt_ValorUnidad.Text))
                {
                    Txt_ValorUnidad.Focus();
                    return;
                }
                if(string.IsNullOrEmpty(Txt_Unidades.Text))
                {
                    Txt_Unidades.Focus();
                    return;
                }

                Factura.GuardarItem(Equipo, NDetalle);
                MessageBox.Show("Item agregado con éxito");
                InicializarFormulario();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            ActivarPanel(true);
        }

        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            ActivarPanel(false);
        }

        private void Txt_ValorUnidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.KeyPress_Numerico(ref sender, ref e);
        }

        private void Txt_Unidades_KeyPress(object sender, KeyPressEventArgs e)
        {
            Util.KeyPress_Numerico(ref sender, ref e);
        }

        private void Txt_Unidades_TextChanged(object sender, EventArgs e)
        {
            NDetalle.Cantidad = string.IsNullOrEmpty(Txt_Unidades.Text) ? 0 : Convert.ToInt32(Txt_Unidades.Text);
            CalcularTotal();
        }

        private void Txt_ValorUnidad_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Txt_ValorUnidad.Text))
            {
                Txt_ValorUnidad.Focus();
                return;
            }

            NDetalle.ValorUnidad = Convert.ToDecimal(Txt_ValorUnidad.Text);
            CalcularTotal();
        }

        private void Txt_Producto_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Producto.Text))
            {
                Txt_Producto.Focus();
                return;
            }
            NDetalle.Producto = Txt_Producto.Text;
        }

        private void Txt_Unidades_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Unidades.Text))
            {
                Txt_Unidades.Focus();
                return;
            }
            NDetalle.Cantidad = Convert.ToInt32(Txt_Unidades.Text);
            CalcularTotal();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Dtg_Detalles.CurrentRow != null)
                {
                    NDetalle = (ENT.Detalles_ENT)Dtg_Detalles.CurrentRow.DataBoundItem;
                    Factura.EliminarItem(Equipo,NDetalle);
                    MessageBox.Show("Item eliminado con éxito");
                    InicializarFormulario();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dtg_Detalles_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            DataGridViewRow FilaSeleccionada = Dtg_Detalles.Rows[e.RowIndex];
            string Valor = FilaSeleccionada.Cells[e.ColumnIndex].Value.ToString();

            if (string.IsNullOrEmpty(Valor))
            {
                FilaSeleccionada.Cells[e.ColumnIndex].Value = "1";
            }

            NDetalle = (ENT.Detalles_ENT)FilaSeleccionada.DataBoundItem;
            NDetalle.CalcularTotal();
            Dtg_Detalles.Update();
            Dtg_Detalles.Refresh();
            Factura.GuardarItem(Equipo,NDetalle);
        }

        private void Dtg_Detalles_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {

            }
            catch(Exception)
            {

            }
        }

    }
}