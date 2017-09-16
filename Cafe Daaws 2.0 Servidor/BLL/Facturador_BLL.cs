using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.BLL
{
    public class Facturador_BLL
    {
        DAL.Facturador_DAL Datos = new DAL.Facturador_DAL();

        public void Guardar(ENT.Terminal_ENT Equipo, string Fecha, string HoraSalida, string Usuario, int EstadoFactura)
        {
            Equipo.Valor = ValorXTiempoConsumido(Convert.ToInt32(Equipo.TiempoConsumido.TotalMinutes));
            if (Datos.ExisteRegistro(Fecha, Equipo.HoraInicio.ToLongTimeString()))
            {
                //Actualizamos los valores de la factura.
                Datos.ActualizarFactura(Fecha, Equipo.HoraInicio.ToLongTimeString(), HoraSalida, Equipo.Valor, Convert.ToInt32(Equipo.TiempoConsumido.TotalMinutes), EstadoFactura);
            }
            else
            {
                //Creamos una nueva factura.
                Datos.RegistrarFactura(Fecha, Equipo.HoraInicio.ToLongTimeString(), Usuario, Equipo.Equipo, Equipo.Valor, Convert.ToInt32(Equipo.TiempoConsumir.TotalMinutes), EstadoFactura);
            }
        }

        public void GuardarTemporal(ENT.Terminal_ENT Equipo, string Usuario)
        {
            string TiempoConsumir = Equipo.TieneTiempoIlimitado ? "Ilimitado" : Convert.ToInt32(Equipo.TiempoConsumir.TotalMinutes).ToString();
            if (Datos.ExisteRegistroTemporal(Usuario))
            {
                Datos.ActualizarFacturaTemporal(Usuario, TiempoConsumir, Convert.ToInt32(Equipo.TiempoConsumido.TotalMinutes).ToString());
            }
            else
            {
                Datos.IngresarFacturaTemporal(Equipo.HoraInicio.ToShortDateString(), Equipo.HoraInicio.ToLongTimeString(), Usuario, Equipo.Equipo, TiempoConsumir, Convert.ToInt32(Equipo.TiempoConsumido.TotalMinutes).ToString());
            }
        }

        public void Eliminar(ENT.Terminal_ENT Equipo)
        {
            Datos.EliminarFactura(Equipo.HoraInicio.ToShortDateString(), Equipo.HoraInicio.ToLongTimeString());
        }

        public decimal ValorXTiempoConsumido(int MinutosEvaluar)
        {
            int EquivaleHora = 60;
            int MinutosRestantes = MinutosEvaluar % EquivaleHora;
            int HorasUtilizadas = 0;
            decimal ValorMinsRestantes = 0;
            decimal ValorHorasUtilizadas = 0;
            while (MinutosEvaluar >= EquivaleHora)
            {
                MinutosEvaluar = MinutosEvaluar - EquivaleHora;
                HorasUtilizadas++;
            }
            if (MinutosRestantes > 0) { ValorMinsRestantes = Datos.ObtenerValorPorRangoTiempo(MinutosRestantes); }
            ValorHorasUtilizadas = Datos.ObtenerValorPorRangoTiempo(EquivaleHora) * HorasUtilizadas;

            return ValorHorasUtilizadas + ValorMinsRestantes;
        }

        public System.Data.DataTable ConsultarFacturas(DateTime Fecha, string Usuario = "")
        {
            if (string.IsNullOrEmpty(Usuario))
            {
                return Datos.ConsultarFacturas(Fecha.ToShortDateString());
            }
            else
            {
                return Datos.ConsultarFacturas(Fecha.ToShortDateString(), Usuario);
            }
        }

        public System.Data.DataTable ConsultarFacturasTemporales()
        {
            return Datos.ConsultarFacturasTemporales();
        }

        public void ObtenerFactura(ENT.Terminal_ENT Equipo)
        {
            try
            {
                Equipo.AsignarPropiedades(Datos.ObtenerUltimaFacturaEquipo(Equipo.Equipo));
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void GuardarItem(ENT.Terminal_ENT Equipo, ENT.Detalles_ENT Item)
        {
            try
            {
                if (!Datos.ExisteDetalleFactura(Equipo, Item))
                {
                    Datos.GuardarDetalleFactura(Equipo, Item);
                    Equipo.AgregarItem(Item);
                }
                else
                {
                    Datos.ActualizarValoresDetalle(Equipo, Item);
                }
            }
            catch(Exception)
            {
                throw;
            }
        }

        public void EliminarItem(ENT.Terminal_ENT Equipo, ENT.Detalles_ENT Item)
        {
            try
            {
                Datos.ActualizarEstadoDetalle(Equipo, Item);
                Equipo.EliminarItem(Item);
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
