using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.DAL.Auditor
{
    public class Auditor_DAL
    {
        public ENT.Auditoria_ENT Auditoria { get; set; }

        public void Registrar()
        {
            try
            {
                DBConexion Db = new DBConexion();
                DbDataReader dr;
                Db.Conectar();
                string sentenciaSQL = "INSERT INTO Auditoria ([Descrip],[FechaHora],[Usuario], [IdAcc]) VALUES ([@des],[@da],[@user], [@Est])";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@des", DbType.String, Auditoria.Descripcion);
                Db.AsignarParametro("@da", DbType.DateTime, Auditoria.Fecha);
                Db.AsignarParametro("@user", DbType.String, Auditoria.Usuario);
                Db.AsignarParametro("@Est", DbType.Int32, (int)Auditoria.Estado);
                dr = Db.EjecutarConsultaReader();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public DataTable Consultar(DateTime Fecha, int Accion)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "SELECT * FROM Auditoria WHERE IdAcc=@Acc AND [FechaHora]=@Fcha ORDER BY Id";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@Acc", DbType.Int32, Accion);
            Db.AsignarParametro("@Fcha", DbType.String, Fecha.ToShortDateString());
            DataTable dt = Db.EjecutarConsulta();
            Db.Desconectar();
            return dt;
        }

        public DataTable Consultar(DateTime Fecha, int Accion, string Usuario)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "SELECT * FROM Auditoria WHERE usuario= @user AND IdAcc=@Acc AND [FechaHora]=@Fcha ORDER BY Id";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@user", DbType.String, Usuario);
            Db.AsignarParametro("@Acc", DbType.Int32, Accion);
            Db.AsignarParametro("@Fcha", DbType.String, Fecha.ToShortDateString());
            DataTable dt = Db.EjecutarConsulta();
            Db.Desconectar();
            return dt;
        }

    }
}
