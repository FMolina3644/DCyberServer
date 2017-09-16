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
    public partial class Frm_AdminUsuarios : Form
    {
        BLL.AdminUsuarios.GestorUsuarios_BLL GestorBLL = new BLL.AdminUsuarios.GestorUsuarios_BLL();
        BLL.AdminUsuarios.Usuario_BLL UsuarioBLL = new BLL.AdminUsuarios.Usuario_BLL();
        public Frm_AdminUsuarios()
        {
            InitializeComponent();
        }

        private void Frm_AdminUsuarios_Load(object sender, EventArgs e)
        {
            InicializarFormulario();
        }

        #region "Metodos & Funciones"
        private void InicializarFormulario()
        {
            Dtg_Usuarios.AutoGenerateColumns = false;
            Dtg_Usuarios.DataSource = GestorBLL.ListarUsuarios()
                                               .FindAll(U => U.TipoUsuario != ENT.TiposAnidados_ENT.TipoUsuario.SUPERADMIN);
        }

        private bool ValidacionesCrearUsuario()
        {
            //validamos el contenido inicialmente
            if (string.IsNullOrEmpty(Txt_Usuario.Text))
            {
                MessageBox.Show("Debe ingresar el usuario");
                Txt_Usuario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Txt_Contraseña.Text))
            {
                MessageBox.Show("Debe ingresar la contraseña");
                Txt_Contraseña.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Txt_RepContraseña.Text))
            {
                MessageBox.Show("Debe confirmar la contraseña");
                Txt_RepContraseña.Focus();
                return false;
            }
            if (Txt_Contraseña.Text != Txt_RepContraseña.Text)
            {
                MessageBox.Show("Las contraseñas deben ser iguales");
                Txt_Contraseña.Clear();
                Txt_RepContraseña.Clear();
                Txt_Contraseña.Focus();
                return false;
            }
            if (Txt_Contraseña.TextLength < 6)
            {
                MessageBox.Show("Por motivos de seguridad la contraseña debe tener 6 ó mas caracteres");
                Txt_Contraseña.Focus();
                return false;
            }

            UsuarioBLL.CargarUsuario(Txt_Usuario.Text);
            if (UsuarioBLL.Usuario.Usuario != null)
            {
                MessageBox.Show("El usuario ya está registrado");
                Txt_Usuario.Clear();
                Txt_Contraseña.Clear();
                Txt_RepContraseña.Clear();
                Txt_Usuario.Focus();
                return false;
            }

            return true;
        }

        private bool ValidacionesCambioContraseña()
        {
            if (string.IsNullOrEmpty(Txt_NueContraseña.Text) || string.IsNullOrEmpty(Txt_ConfNueContraseña.Text))
            {
                MessageBox.Show("Debe ingresar la nueva contraseña");
                Txt_NueContraseña.Focus();
                return false;
            }
            else if (Txt_NueContraseña.Text != Txt_ConfNueContraseña.Text)
            {
                MessageBox.Show("Ambas Contraseñas No Coinciden");
                Txt_NueContraseña.Clear();
                Txt_ConfNueContraseña.Clear();
                Txt_NueContraseña.Focus();
                return false;
            }
            if(Txt_NueContraseña.TextLength < 6)
            {
                MessageBox.Show("Por motivos de seguridad la contraseña debe tener 6 ó mas caracteres");
                return false;
            }

            return true;
        }

        private void CrearUsuario() 
        { 
            try
            {
                if (ValidacionesCrearUsuario())
                {
                    UsuarioBLL.Crear(Txt_Usuario.Text, Txt_Contraseña.Text);
                    MessageBox.Show("Usuario creado con éxito");
                    InicializarFormulario();
                    Btn_RegNuevo_Click(null, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EliminarUsuario()
        {
            try
            {
                if (Dtg_Usuarios.CurrentRow != null)
                {
                    UsuarioBLL.Usuario = (ENT.Usuario_ENT)Dtg_Usuarios.CurrentRow.DataBoundItem;
                    if (MessageBox.Show("¿Desea eliminar al usuario " + UsuarioBLL.Usuario.Usuario + "?"
                                        ,"Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        UsuarioBLL.Eliminar();
                        MessageBox.Show("Usuario eliminado con éxito");
                        InicializarFormulario();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarContraseña()
        {
            try
            {
                if(ValidacionesCambioContraseña())
                {
                    UsuarioBLL.ActualizarContraseña(Txt_NueContraseña.Text);
                    MessageBox.Show("Contraseña actualizada con éxito");
                    InicializarFormulario();
                    Btn_RegNuevo_Click(null, null);
                }
            }
            catch (Exception ex)
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
            Pnl_Listas.Visible = false;
            Pnl_Edicion.Visible = false;
            Pnl_Crear.Visible = true;
            Txt_Usuario.Clear();
            Txt_Contraseña.Clear();
            Txt_RepContraseña.Clear();
            Txt_Usuario.Focus();
        }

        private void Btn_RegNuevo_Click(object sender, EventArgs e)
        {
            Pnl_Crear.Visible = false;
            Pnl_Edicion.Visible = false;
            Pnl_Listas.Visible = true;
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            CrearUsuario();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void Btn_CambiarContra_Click(object sender, EventArgs e)
        {
            if (Dtg_Usuarios.CurrentRow != null)
            {
                UsuarioBLL.Usuario = (ENT.Usuario_ENT)Dtg_Usuarios.CurrentRow.DataBoundItem;
                Lbl_UsuEditar.Text = UsuarioBLL.Usuario.Usuario;

                Pnl_Listas.Visible = false;
                Pnl_Crear.Visible = false;
                Pnl_Edicion.Visible = true;
                Txt_NueContraseña.Clear();
                Txt_ConfNueContraseña.Clear();
                Txt_NueContraseña.Focus();
            }
        }

        private void Btn_GuardarContraseña_Click(object sender, EventArgs e)
        {
            ActualizarContraseña();
        }

    }
}
