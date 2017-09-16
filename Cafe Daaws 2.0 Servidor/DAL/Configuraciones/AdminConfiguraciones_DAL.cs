using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.DAL.Configuraciones
{
    public class AdminConfiguraciones_DAL
    {
        public bool EstaTiempoOcioActivo()
        {
            bool EstaActivo = false;
            DbDataReader dr;
            DBConexion bd = new DBConexion();
            bd.Conectar();
            bd.CrearComando("select [estado] from PlantillaTiempo where [IdPlantilla]=0 and [Item]= 1");
            dr = bd.EjecutarConsultaReader();
            if (dr.Read())
            {
                EstaActivo = (Convert.ToInt32(dr.GetValue(0)) == 1);
            }
            dr.Close();
            bd.Desconectar();
            return EstaActivo;
        }

        public List<int> ObtenerRangosTiempo()
        {
            List<int> Rangos = new List<int>();
            DbDataReader dr;
            DBConexion bd = new DBConexion();
            bd.Conectar();
            bd.CrearComando("select [RangoFin] from PlantillaTiempo where [estado]=@est");
            bd.AsignarParametro("@est", DbType.Int32, (int)ENT.TiposAnidados_ENT.Estado.ACTIVO);
            dr = bd.EjecutarConsultaReader();
            while (dr.Read())
            {
                Rangos.Add(Convert.ToInt32(dr.GetValue(0)));
            }
            dr.Close();
            bd.Desconectar();
            return Rangos;
        }

        public string ObtenerRazonSocial()
        {
            string Nombre = "";
            DbDataReader dr;
            DBConexion bd = new DBConexion();
            bd.Conectar();
            bd.CrearComando("select [Nombre] from Servidor where [Id]=1");
            dr = bd.EjecutarConsultaReader();
            if (dr.Read())
            {
                Nombre = dr.GetValue(0).ToString();
            }
            dr.Close();
            bd.Desconectar();
            return Nombre;
        }

        public void ActualizarRazonSocial(string Nombre)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "UPDATE Servidor SET [Nombre] = [@nmb] WHERE [Id]= 1 ";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@vlr", DbType.String, Nombre);
            DbDataReader dr = Db.EjecutarConsultaReader();
            dr.Close();
            Db.Desconectar();
        }

        public int ConsultarValoresPlantilla(int IdPlantilla, int Item)
        {
            int Ins = 0;
            DbDataReader dr;
            DBConexion bd = new DBConexion();
            bd.Conectar();
            bd.CrearComando("select [Valor] from plantillatiempo where [IdPlantilla]=@idplant and [Item]=@item");
            bd.AsignarParametro("@idplant", DbType.Int32, IdPlantilla);
            bd.AsignarParametro("@item", DbType.Int32, Item);
            dr = bd.EjecutarConsultaReader();
            if (dr.Read())
            {
                Ins = Convert.ToInt32(dr.GetValue(0));
            }
            dr.Close();
            bd.Desconectar();
            return Ins;
        }

        public void GuardarValorPlantilla(ENT.ItemPlantilla_ENT Item)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "update plantillatiempo set [valor]=@val, [estado]=@est where [idplantilla]=@idplant and [item]=@item";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@val", DbType.Int32, Item.Valor);
            Db.AsignarParametro("@est", DbType.Int32, (int)Item.Estado);
            Db.AsignarParametro("@idplant", DbType.Int32, (int)Item.IdPlantilla);
            Db.AsignarParametro("@item", DbType.Int32, Item.Item);
            Db.EjecutarComando();
            Db.Desconectar();
        }

        public int ObtenerPlantillaSeleccionada()
        {
            int PlantillaSel = 0;
            DbDataReader dr;
            DBConexion bd = new DBConexion();
            bd.Conectar();
            bd.CrearComando("select [IdPlantilla] from PlantillaTiempo where [Estado]=1 and [IdPlantilla]>0 group by IdPlantilla");
            dr = bd.EjecutarConsultaReader();
            if (dr.Read())
            {
                PlantillaSel = Convert.ToInt32(dr.GetValue(0));
            }
            dr.Close();
            bd.Desconectar();
            return PlantillaSel;
        }

        public void ActualizarEstadoItem(ENT.ItemPlantilla_ENT Item)
        {
            DBConexion Db = new DBConexion();
            Db.Conectar();
            string sentenciaSQL = "update plantillatiempo set [estado]=@est where [idplantilla]=@idplant and [item]=@item";
            Db.CrearComando(sentenciaSQL);
            Db.AsignarParametro("@est", DbType.Int32, (int)Item.Estado);
            Db.AsignarParametro("@idplant", DbType.Int32, (int)Item.IdPlantilla);
            Db.AsignarParametro("@item", DbType.Int32, Item.Item);
            Db.EjecutarComando();
            Db.Desconectar();
        }
    }
}
