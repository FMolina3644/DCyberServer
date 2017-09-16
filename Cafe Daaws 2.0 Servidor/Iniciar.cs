using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor
{
    class Iniciar : ApplicationContext
    {
        public Iniciar()
        {
            GUI.Frm_Presentacion FrmPresenta = new GUI.Frm_Presentacion();
            FrmPresenta.Show();
        }
    }
}
