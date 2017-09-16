using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.ENT
{
    public class ItemPlantilla_ENT
    {
        public ENT.TiposAnidados_ENT.Plantilla IdPlantilla { get; set; }
        public int Item { get; set; }
        public ENT.TiposAnidados_ENT.Estado Estado { get; set; }
        public int Valor { get; set;}

        public ItemPlantilla_ENT(ENT.TiposAnidados_ENT.Plantilla PlantillaSel
                                 , int ItemSel
                                 , int ValorSel
                                 , ENT.TiposAnidados_ENT.Estado EstadoSel = TiposAnidados_ENT.Estado.ACTIVO)
        {
            IdPlantilla = PlantillaSel;
            Item = ItemSel;
            Estado = EstadoSel;
            Valor = ValorSel;
        }

        public ItemPlantilla_ENT()
        {

        }
    }
}
