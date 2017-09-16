using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.ENT
{
    public class Auditoria_ENT
    {
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string Usuario { get; set; }
        public TiposAnidados_ENT.AccionesAuditoria Estado { get; set; }
    }
}
