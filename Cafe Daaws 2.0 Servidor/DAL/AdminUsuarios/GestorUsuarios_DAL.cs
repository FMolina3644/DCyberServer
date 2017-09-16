using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.DAL.AdminUsuarios
{
    public class GestorUsuarios_DAL
    {
        public List<ENT.Usuario_ENT> ObtenerUsuarios()
        {
           List<ENT.Usuario_ENT> Usuarios = new List<ENT.Usuario_ENT>();
           DbDataReader dr;
           DBConexion bd = new DBConexion();
           bd.Conectar();
           bd.CrearComando("select [Username], [Password], [IdTipoUsuario] from Usuario where [IdEstado]=1");
           dr = bd.EjecutarConsultaReader();
           while (dr.Read())
           {
               ENT.Usuario_ENT Usuario = new ENT.Usuario_ENT();
               Usuario.Usuario = Convert.ToString(dr.GetValue(0));
               Usuario.Contraseña = Convert.ToString(dr.GetValue(1));
               Usuario.TipoUsuario = (ENT.TiposAnidados_ENT.TipoUsuario)Convert.ToInt32(dr.GetValue(2));
               Usuario.Estado = ENT.TiposAnidados_ENT.Estado.ACTIVO;
               Usuarios.Add(Usuario);
           }
           dr.Close();
           bd.Desconectar();
           return Usuarios;
        }

    }
}
