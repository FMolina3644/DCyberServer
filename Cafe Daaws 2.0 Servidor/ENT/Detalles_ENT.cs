using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.ENT
{
    public class Detalles_ENT
    {

        public string Producto { get; set; }
        public decimal ValorUnidad { get; set; }
        public int Cantidad { get; set; }
        public decimal ValorTotal { get; set; }

        public void CalcularTotal()
        {
            ValorTotal = ValorUnidad * Cantidad;
        }
    }
}
