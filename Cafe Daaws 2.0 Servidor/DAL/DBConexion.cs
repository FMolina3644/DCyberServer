using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Cafe_Daaws_2._0_Servidor.DAL
{
    public class DBConexion
    {
        string cadConexApp = "", proveedor = "";
        private static DbProviderFactory fabrica = null;
        DbConnection cn;
        DbCommand cmd;
        DbParameter param;
        DbDataAdapter da;

        int bderror;
        public int BdError {
            get {
                return bderror;
            }
            set {
                bderror = value;
            }
        }

        public DBConexion()
        {
            cadConexApp = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString + "Data source=" + Application.StartupPath + "\\bd1CafeCues.mdb";
            proveedor = ConfigurationManager.ConnectionStrings["cadena"].ProviderName;
            DBConexion.fabrica = DbProviderFactories.GetFactory(proveedor);
            bderror = 0;
        }

        public DBConexion(string NombreDB)
        {
            cadConexApp = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString + "Data source=" + Application.StartupPath + "\\" + NombreDB +".mdb";
            proveedor = ConfigurationManager.ConnectionStrings["cadena"].ProviderName;
            DBConexion.fabrica = DbProviderFactories.GetFactory(proveedor);
            bderror = 0;
        }

        public void Conectar()
        {
            cn = fabrica.CreateConnection();
            cn.ConnectionString = cadConexApp;
            cn.Open();
        }
        public void CrearComando(string sql)
        {
            cmd = fabrica.CreateCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
        }
        public void AsignarParametro(string nombre,DbType tipo, object valor)
        { 
            param = fabrica.CreateParameter();
            param.ParameterName = nombre;
            param.DbType = tipo;
            param.Value=valor;
            cmd.Parameters.Add(param);
        }
        public int EjecutarComando()
        {
            int reg = 0;
            try
            {
                reg = cmd.ExecuteNonQuery();
            }
            catch (DbException ex)
            {
                bderror = ex.ErrorCode;
            }
    
            return reg;
        }

        public DataTable EjecutarConsulta()
        {
            DataTable dt = new DataTable();
            da = fabrica.CreateDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);
            return dt;
        }

        public DbDataReader EjecutarConsultaReader()
        {
            return cmd.ExecuteReader();
        }

        public void Desconectar()
        {
            cn.Close();        
        }
    }
}
