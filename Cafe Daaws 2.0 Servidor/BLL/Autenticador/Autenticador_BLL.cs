using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.BLL.Autenticador
{
    public class Autenticador_BLL
    {
        public ENT.TiposAnidados_ENT.TipoValidacion EstadoValidacion { get; set; }
        public AdminUsuarios.Usuario_BLL UsuarioBLL = new AdminUsuarios.Usuario_BLL();
        public Autenticador_BLL(string Usuario, string Contraseña)
        {
            try
            {
                UsuarioBLL.CargarUsuario(Usuario);
                ValidarUsuario(Contraseña);
            }
            catch(Exception )
            {
                throw;
            }
        }

        private void ValidarUsuario(string Contraseña)
        {
            try
            {
                if (UsuarioBLL.Usuario.Usuario == null)
                {
                    EstadoValidacion = ENT.TiposAnidados_ENT.TipoValidacion.UsuarioInexistente;
                }
                else if (UsuarioBLL.Usuario.Estado == ENT.TiposAnidados_ENT.Estado.INACTIVO)
                {
                    EstadoValidacion = ENT.TiposAnidados_ENT.TipoValidacion.EstadoInhabilitado;
                }
                else if (UsuarioBLL.Usuario.Contraseña != Contraseña)
                {
                    EstadoValidacion = ENT.TiposAnidados_ENT.TipoValidacion.ContraseñaIncorrecta;
                }
                else
                {
                    EstadoValidacion = ENT.TiposAnidados_ENT.TipoValidacion.AccesoCorrecto;
                }
            }
            catch(Exception )
            {
                throw;
            }
        }

    }
}
