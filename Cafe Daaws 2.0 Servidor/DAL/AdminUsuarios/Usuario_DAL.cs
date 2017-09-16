using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.DAL.AdminUsuarios
{
    public class Usuario_DAL
    {
        public ENT.Usuario_ENT Usuario { get; set; }

        public void CargarUsuario(string Usuario)
        {
            try
            {
                this.Usuario = new ENT.Usuario_ENT();
                DbDataReader dr;
                DBConexion bd = new DBConexion();
                bd.Conectar();
                bd.CrearComando("select [idTipoUsuario], [IdEstado], [Username], [Password] from Usuario where username=@username");
                bd.AsignarParametro("@username", DbType.String, Usuario);
                dr = bd.EjecutarConsultaReader();
                while (dr.Read())
                {
                    this.Usuario.Usuario = dr["Username"].ToString();
                    this.Usuario.Contraseña = dr["Password"].ToString();
                    this.Usuario.TipoUsuario = (ENT.TiposAnidados_ENT.TipoUsuario)Convert.ToInt32(dr["idTipoUsuario"]);
                    this.Usuario.Estado = (ENT.TiposAnidados_ENT.Estado)Convert.ToInt32(dr["IdEstado"]);
                }
                dr.Close();
                bd.Desconectar();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void Crear()
        {
            try
            {
                DBConexion Db = new DBConexion();
                DbDataReader dr;
                Db.Conectar();
                string sentenciaSQL = "INSERT INTO Usuario ([Username],[Password],[IdTipoUsuario],[IdEstado]) VALUES (@user,@pwd,@TipoU,@Est)";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@user", DbType.String, Usuario.Usuario);
                Db.AsignarParametro("@pwd", DbType.String, Usuario.Contraseña);
                Db.AsignarParametro("@TipoU", DbType.Int32, (int)Usuario.TipoUsuario);
                Db.AsignarParametro("@Est", DbType.Int32, (int)Usuario.Estado);
                dr = Db.EjecutarConsultaReader();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ActualizarEstado()
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "UPDATE Usuario SET [IdEstado] = @Est WHERE [Username]= @User";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@Est", DbType.Int32, (int)Usuario.Estado);
                Db.AsignarParametro("@User", DbType.String, Usuario.Usuario);
                Db.EjecutarComando();
                Db.Desconectar();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarContraseña()
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "UPDATE Usuario SET [Password] = @Pwd WHERE [Username]= @User";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@Pwd", DbType.String, Usuario.Contraseña);
                Db.AsignarParametro("@User", DbType.String, Usuario.Usuario);
                Db.EjecutarComando();
                Db.Desconectar();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
