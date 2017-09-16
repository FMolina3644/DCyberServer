using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.DAL
{
    public class Facturador_DAL
    {
        public bool ExisteRegistro(string Fecha, string HoraEntrada)
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "SELECT * FROM Cobro WHERE [Hora_Entrada] = [@h] AND [Fecha_Entrada] = [@fch]";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@h", DbType.String, HoraEntrada);
                Db.AsignarParametro("@fch", DbType.String, Fecha);
                DbDataReader dr = Db.EjecutarConsultaReader();
                bool ExisteRegistro = dr.Read();
                dr.Close();
                Db.Desconectar();
                return ExisteRegistro;
            }
            catch(Exception )
            {
                throw;
            }
        }

        public void ActualizarFactura(string Fecha,string HoraEntrada, string HoraSalida, decimal Valor, int Minutos, int Estado)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "UPDATE Cobro SET [Valor_Historico] = [@vlr], [Min_Solic] = [@min], [IdEst] = [@Est], [Hora_Salida] = [@hs] WHERE [Hora_Entrada]= [@h] AND [Fecha_Entrada] = [@fch]";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@vlr", DbType.Decimal, Valor);
            Db.AsignarParametro("@min", DbType.String, Minutos.ToString());
            Db.AsignarParametro("@Est", DbType.Int32, Estado);
            Db.AsignarParametro("@hs", DbType.String, HoraSalida);
            Db.AsignarParametro("@h", DbType.String, HoraEntrada);
            Db.AsignarParametro("@fch", DbType.String, Fecha);
            DbDataReader dr = Db.EjecutarConsultaReader();
            dr.Close();
            Db.Desconectar();
        }

        public void RegistrarFactura(string Fecha, string HoraEntrada, string Usuario, string Equipo, decimal Valor, int Minutos, int Estado)
        {
            DBConexion Db = new DBConexion();
            DbDataReader dr;
            Db.Conectar();
            string sentenciaSQL = "INSERT INTO Cobro([Fecha_Entrada],[Hora_Entrada],[Username],[Equipo],[Valor_Historico], [Min_Solic], [IdEst]) VALUES ([@fch],[@H],[@user],[@Eq],[@VH],[@Min], [@Est])";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@fch", DbType.String, Fecha);
            Db.AsignarParametro("@H", DbType.String, HoraEntrada);
            Db.AsignarParametro("@user", DbType.String, Usuario);
            Db.AsignarParametro("@Eq", DbType.String, Equipo);
            Db.AsignarParametro("@VH", DbType.Decimal, Valor);
            Db.AsignarParametro("@Min", DbType.String, Minutos.ToString());
            Db.AsignarParametro("@Est", DbType.Int32, Estado);
            dr = Db.EjecutarConsultaReader();
            dr.Close();
            Db.Desconectar();
        }

        public bool ExisteRegistroTemporal(string Usuario)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "SELECT * FROM RegistroTemporal WHERE [Username] = [@usu]";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@usu", DbType.String, Usuario);
            DbDataReader dr = Db.EjecutarConsultaReader();
            bool ExisteRegistro = dr.Read();
            dr.Close();
            Db.Desconectar();
            return ExisteRegistro;
        }

        public void ActualizarFacturaTemporal(string Usuario, string MinutosSolicitados, string MinutosConsumidos)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "UPDATE RegistroTemporal SET [Min_Solic] = [@Min],[Min_consu] = [@min_Con] WHERE [Username] = [@user]";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@Min", DbType.String, MinutosSolicitados);
            Db.AsignarParametro("@min_Con", DbType.Int32, MinutosConsumidos);
            Db.AsignarParametro("@User", DbType.String, Usuario);
            DbDataReader dr = Db.EjecutarConsultaReader();
            dr.Close();
            Db.Desconectar();
        }

        public void IngresarFacturaTemporal(string Fecha, string HoraEntrada, string Usuario, string Equipo, string MinutosSolicitados, string MinutosConsumidos)
        {
            DBConexion Db = new DBConexion();
            DbDataReader dr;
            Db.Conectar();
            string sentenciaSQL = "INSERT INTO RegistroTemporal([Fecha_Entrada],[Hora_Entrada],[Username],[Equipo],[Min_Solic],[Min_consu]) VALUES ([@fch],[@H],[@user],[@Eq],[@Min],[@min_Con])";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@fch", DbType.String, Fecha);
            Db.AsignarParametro("@H", DbType.String, HoraEntrada);
            Db.AsignarParametro("@user", DbType.String, Usuario);
            Db.AsignarParametro("@Eq", DbType.String, Equipo);
            Db.AsignarParametro("@Min", DbType.String, MinutosSolicitados);
            Db.AsignarParametro("@min_Con", DbType.Int32, MinutosConsumidos);
            dr = Db.EjecutarConsultaReader();
            dr.Close();
            Db.Desconectar();
        }

        public void EliminarFactura(string Fecha, string Hora)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "DELETE * FROM Cobro WHERE [Hora_Entrada]= @h AND [Fecha_Entrada]= @fch";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@h", DbType.String, Hora);
            Db.AsignarParametro("@fch", DbType.String, Fecha);
            DbDataReader dr = Db.EjecutarConsultaReader();
            dr.Close();
            Db.Desconectar();
        }

        public decimal ObtenerValorPorRangoTiempo(int Tiempo)
        {
            decimal Valor = 0;
            DbDataReader dr;
            DBConexion Db = new DBConexion();
            Db.Conectar();
            Db.CrearComando("SELECT Valor FROM PlantillaTiempo WHERE [@min] >= [RangoIni] AND [@min] <= [RangoFin] AND [Estado] = 1");
            Db.AsignarParametro("@min", DbType.Int32, Tiempo);
            dr = Db.EjecutarConsultaReader();
            if (dr.Read())
            {
                Valor = Convert.ToDecimal(dr.GetValue(0));
            }
            dr.Close();
            Db.Desconectar();
            return Valor;
        }

        public decimal ObtenerValorPorRangoFinal(int Tiempo)
        {
            decimal Valor = 0;
            DbDataReader dr;
            DBConexion bd = new DBConexion();
            bd.Conectar();
            bd.CrearComando("select [Valor] from plantillatiempo where [RangoFin]= @rf and [Estado]=1");
            bd.AsignarParametro("@rf", DbType.Int32, Tiempo);
            dr = bd.EjecutarConsultaReader();
            if (dr.Read())
            {
                Valor = Convert.ToDecimal(dr.GetValue(0));
            }
            dr.Close();
            bd.Desconectar();
            return Valor;
        }

        public DataTable ConsultarFacturas(string Fecha)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "select  [IdCobro],[Equipo],[Valor_Historico] AS Valor ,[Username] AS Usuario, [Min_Solic] AS Tiempo_Consumido, [Fecha_Entrada], [Hora_Entrada], [Hora_Salida] from Cobro  where [Fecha_entrada]=@fecha order by [Username]";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@fecha", DbType.String, Fecha);
            DataTable dt = Db.EjecutarConsulta();
            Db.Desconectar();
            return dt;
        }

        public DataTable ConsultarFacturas(string Fecha, string Usuario)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "Select [IdCobro],[Equipo],[Valor_Historico] AS Valor, [Min_Solic] AS Tiempo_Consumido, [Fecha_Entrada], [Hora_Entrada], [Hora_Salida] From Cobro where [Username]= [@user] and [Fecha_entrada]= [@fch]";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@user", DbType.String, Usuario);
            Db.AsignarParametro("@fch", DbType.String, Fecha);
            DataTable dt = Db.EjecutarConsulta();
            Db.Desconectar();
            return dt;
        }

        public DataTable ConsultarFacturasTemporales()
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "select * from RegistroTemporal";
                Db.CrearComando(sentenciaSQL);
                DataTable dtTemporales = Db.EjecutarConsulta();
                Db.Desconectar();
                return dtTemporales;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public DataTable ObtenerUltimaFacturaEquipo(string Nombre)
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "SELECT top 1 * FROM Cobro WHERE [Equipo] = [@Eq] order by [Hora_Entrada] Desc";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@Eq", DbType.String, Nombre);
                DataTable dtFactura = Db.EjecutarConsulta();
                Db.Desconectar();
                return dtFactura;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ExisteDetalleFactura(ENT.Terminal_ENT Equipo, ENT.Detalles_ENT Item)
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "SELECT * FROM CobroDetalle WHERE [Hora_Entrada] = [@h] AND [Fecha_Entrada] = [@fch] and [Equipo] = [@eq] and [Estado] = 1 and [Producto] = [@prd]";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@h", DbType.String, Equipo.HoraInicio.ToLongTimeString());
                Db.AsignarParametro("@fch", DbType.String, Equipo.HoraInicio.ToShortDateString());
                Db.AsignarParametro("@eq", DbType.String, Equipo.Equipo);
                Db.AsignarParametro("@prd", DbType.String, Item.Producto);
                DbDataReader dr = Db.EjecutarConsultaReader();
                bool ExisteRegistro = dr.Read();
                dr.Close();
                Db.Desconectar();
                return ExisteRegistro;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void ActualizarEstadoDetalle(ENT.Terminal_ENT Equipo, ENT.Detalles_ENT Item)
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "UPDATE CobroDetalle SET [Estado] = [@est] WHERE [Hora_Entrada] = [@h] AND [Fecha_Entrada] = [@fch] and [Equipo] = [@eq] and [Estado] = 1 and [Producto] = [@prd]";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@h", DbType.String, Equipo.HoraInicio.ToLongTimeString());
                Db.AsignarParametro("@fch", DbType.String, Equipo.HoraInicio.ToShortDateString());
                Db.AsignarParametro("@eq", DbType.String, Equipo.Equipo);
                Db.AsignarParametro("@prd", DbType.String, Item.Producto);
                Db.AsignarParametro("@est", DbType.Int32, (int)ENT.TiposAnidados_ENT.Estado.INACTIVO);
                DbDataReader dr = Db.EjecutarConsultaReader();
                dr.Close();
                Db.Desconectar();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void ActualizarValoresDetalle(ENT.Terminal_ENT Equipo, ENT.Detalles_ENT Item)
        {
            try
            {
                DBConexion Db = new DBConexion();
                Db.Conectar();
                string sentenciaSQL = "UPDATE CobroDetalle SET [Valor_Unidad] = [@vlruni], [Cantidad] = [@cnt], [Valor_Total] = [@vtot] WHERE [Hora_Entrada] = [@h] AND [Fecha_Entrada] = [@fch] and [Equipo] = [@eq] and [Estado] = 1 and [Producto] = [@prd]";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@h", DbType.String, Equipo.HoraInicio.ToLongTimeString());
                Db.AsignarParametro("@fch", DbType.String, Equipo.HoraInicio.ToShortDateString());
                Db.AsignarParametro("@eq", DbType.String, Equipo.Equipo);
                Db.AsignarParametro("@prd", DbType.String, Item.Producto);
                Db.AsignarParametro("@vlruni", DbType.Decimal, Item.ValorUnidad);
                Db.AsignarParametro("@cnt", DbType.Int32, Item.Cantidad);
                Db.AsignarParametro("@vtot", DbType.Decimal, Item.ValorTotal);
                DbDataReader dr = Db.EjecutarConsultaReader();
                dr.Close();
                Db.Desconectar();
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void GuardarDetalleFactura(ENT.Terminal_ENT Equipo, ENT.Detalles_ENT Item)
        {
            try
            {
                DBConexion Db = new DBConexion();
                DbDataReader dr;
                Db.Conectar();
                string sentenciaSQL = "INSERT INTO CobroDetalle([Fecha_Entrada],[Hora_Entrada],[Equipo],[Producto],[Valor_Unidad],[Cantidad],[Valor_Total],[Estado]) VALUES ([@fch],[@H],[@Eq],[@Prd],[@Vlruni],[@Cnt],[@Vlrtot],1)";
                Db.CrearComando(sentenciaSQL);
                Db.AsignarParametro("@fch", DbType.String, Equipo.HoraInicio.ToShortDateString());
                Db.AsignarParametro("@H", DbType.String, Equipo.HoraInicio.ToLongTimeString());
                Db.AsignarParametro("@Eq", DbType.String, Equipo.Equipo);
                Db.AsignarParametro("@Prd", DbType.String, Item.Producto);
                Db.AsignarParametro("@Vlruni", DbType.Decimal, Item.ValorUnidad);
                Db.AsignarParametro("@Cnt", DbType.Int32, Item.Cantidad);
                Db.AsignarParametro("@Vlrtot", DbType.Decimal, Item.ValorTotal);
                dr = Db.EjecutarConsultaReader();
                dr.Close();
                Db.Desconectar();
            }
            catch(Exception)
            {
                throw;
            }
        }

    }
}
