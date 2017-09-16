using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.BLL.Configuraciones
{
    public class AdminConfiguraciones_BLL
    {
        DAL.Configuraciones.AdminConfiguraciones_DAL Datos = new DAL.Configuraciones.AdminConfiguraciones_DAL();

        public bool EstaTiempoOcioActivo()
        {
            return Datos.EstaTiempoOcioActivo();
        }

        public string ObtenerRazonSocial()
        {
            return Datos.ObtenerRazonSocial();
        }

        public void ActualizarRazonSocial(string NRazon)
        {
            Datos.ActualizarRazonSocial(NRazon);
        }

        public List<string> ObtenerRangosTiempo()
        {
            List<string> Rangos = new List<string>();
            List<int> RangosTiempo = Datos.ObtenerRangosTiempo();
            foreach (int i in RangosTiempo)
            {
                string Rango = i == -1 ? "Ilimitado" : Math.Abs(i).ToString() + " Min";
                Rangos.Add(Rango);
            }
            return Rangos;
        }

        public int ObtenerPlantillaSeleccionada()
        {
            return Datos.ObtenerPlantillaSeleccionada();
        }

        public string ConsultarValoresPlantilla(int IdPlantilla, int Item)
        {
            return Datos.ConsultarValoresPlantilla(IdPlantilla, Item).ToString();
        }

        public void RestaurarValoresDefaultPlantillas()
        {
            int ValorIncrementar = 200;
            int ValorInicial = 200;
            List<ENT.ItemPlantilla_ENT> Items = new List<ENT.ItemPlantilla_ENT>();

            Items.Add(new ENT.ItemPlantilla_ENT(ENT.TiposAnidados_ENT.Plantilla.Default, 1, 300));
            Items.Add(new ENT.ItemPlantilla_ENT(ENT.TiposAnidados_ENT.Plantilla.Default, 2, 500));
            Items.Add(new ENT.ItemPlantilla_ENT(ENT.TiposAnidados_ENT.Plantilla.Default, 3, 800));
            Items.Add(new ENT.ItemPlantilla_ENT(ENT.TiposAnidados_ENT.Plantilla.Default, 4, 1000));

            for (int item = 1; item <= 6; item++)
            {
                Items.Add(new ENT.ItemPlantilla_ENT(ENT.TiposAnidados_ENT.Plantilla.Personalizada, item, ValorInicial));
                ValorInicial = ValorInicial + ValorIncrementar;
            }

            GuardarValoresPlantilla(Items);
        }

        public void ActualizarEstadoItem(List<ENT.ItemPlantilla_ENT> Items)
        {
            Items.ForEach(I => Datos.ActualizarEstadoItem(I));
        }

        public void GuardarValoresPlantilla(List<ENT.ItemPlantilla_ENT> Items)
        {
            Items.ForEach(I => Datos.GuardarValorPlantilla(I));
        }

    }
}
