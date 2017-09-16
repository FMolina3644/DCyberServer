using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.ENT
{
    public class Terminal_ENT
    {
        public TcpClient TCP { get; set; }
        public string Equipo { get; set; }
        public int Puerto { get; set; }
        public DateTime HoraInicio { get; set; }
        public TiposAnidados_ENT.EstadoTerminal Estado { get; set; }
        public decimal Valor { get; set; }
        public TimeSpan TiempoConsumir { get; set; }
        public bool TieneTiempoIlimitado { get; set; }
        public TimeSpan TiempoConsumido { get; set; }

        public List<Detalles_ENT> ProductosAdicionales = new List<Detalles_ENT>();

        public decimal TotalItems { get { return ProductosAdicionales.Sum(P => P.ValorTotal); } }

        public decimal TotalFacturar { get { return Valor + TotalItems; } }

        public void AgregarItem(ENT.Detalles_ENT Item)
        {
            ProductosAdicionales.Add(Item);
        }

        public void EliminarItem(ENT.Detalles_ENT Item)
        {
            ProductosAdicionales.Remove(Item);
        }

        public void ReiniciarFactura()
        {
            HoraInicio = new DateTime();
            Estado = TiposAnidados_ENT.EstadoTerminal.Disponible;
            Valor = 0;
            TiempoConsumir = new TimeSpan();
            TiempoConsumido = new TimeSpan();
            TieneTiempoIlimitado = false;
            ProductosAdicionales.Clear();
        }

        public void AsignarPropiedades(System.Data.DataTable Datos)
        {
            try
            {
                string Tiempo = Datos.Rows[0]["Min_Solic"].ToString();

                if (Tiempo == "Ilimitado")
                {
                    TieneTiempoIlimitado = true;
                }
                else
                {
                    TiempoConsumir = new TimeSpan(0, Convert.ToInt32(Tiempo), 0);
                }
                DateTime Fecha = Convert.ToDateTime(Datos.Rows[0]["Fecha_Entrada"].ToString());
                DateTime Hora = Convert.ToDateTime(Datos.Rows[0]["Hora_Entrada"].ToString());
                HoraInicio = Fecha;
                HoraInicio = HoraInicio.Add(Hora.TimeOfDay);

            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
