using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.ENT
{
    public class Usuario_ENT
    {
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public ENT.TiposAnidados_ENT.Estado Estado { get; set; }
        public ENT.TiposAnidados_ENT.TipoUsuario TipoUsuario { get; set; }

        public Usuario_ENT()
        {

        }
    }
}
