using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.BLL.AdminUsuarios
{
    public class GestorUsuarios_BLL
    {
        DAL.AdminUsuarios.GestorUsuarios_DAL Datos = new DAL.AdminUsuarios.GestorUsuarios_DAL();

        public List<string> UsuariosParaAuditoria()
        {
            List<string> Usuarios = new List<string>();
            Datos.ObtenerUsuarios().ForEach(U => Usuarios.Add(U.Usuario));
            return Usuarios;
        }

        public List<ENT.Usuario_ENT> ListarUsuarios()
        {
            return Datos.ObtenerUsuarios();
        }
    }
}
