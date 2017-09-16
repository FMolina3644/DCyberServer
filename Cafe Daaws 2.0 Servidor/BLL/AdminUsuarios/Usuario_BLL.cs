using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.BLL.AdminUsuarios
{
    public class Usuario_BLL
    {
        public ENT.Usuario_ENT Usuario { get; set; }
        DAL.AdminUsuarios.Usuario_DAL Datos = new DAL.AdminUsuarios.Usuario_DAL();

        public void CargarUsuario(string Usuario)
        {
            try
            {
                Datos.CargarUsuario(Usuario);
                this.Usuario = Datos.Usuario;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Crear(string UsuarioSel, string Contraseña)
        {
            try
            {
                Usuario = new ENT.Usuario_ENT();
                Usuario.Usuario = UsuarioSel;
                Usuario.Contraseña = Contraseña;
                Usuario.Estado = ENT.TiposAnidados_ENT.Estado.ACTIVO;
                Usuario.TipoUsuario = ENT.TiposAnidados_ENT.TipoUsuario.ADMIN;

                Datos.Usuario = Usuario;
                Datos.Crear();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Eliminar()
        {
            try
            {
                Usuario.Estado = ENT.TiposAnidados_ENT.Estado.INACTIVO;
                Datos.Usuario = Usuario;
                Datos.ActualizarEstado();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ActualizarContraseña(string NuevaContraseña)
        {
            try
            {
                Usuario.Contraseña = NuevaContraseña;
                Datos.Usuario = Usuario;
                Datos.ActualizarContraseña();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
