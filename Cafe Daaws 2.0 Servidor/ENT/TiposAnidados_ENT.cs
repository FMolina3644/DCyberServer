using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_Daaws_2._0_Servidor.ENT
{
    public class TiposAnidados_ENT
    {
        public enum Estado
        {
            ACTIVO = 1,
            INACTIVO = 2
        }

        public enum AccionesAuditoria
        {
            IniciarSesion = 1,
            CerrarSesion = 2,
            AñadirTiempo = 3,
            AnularFactura = 4,
            TrasladarTiempo = 5,
            FacturaTiempo = 6
        }

        public enum TipoUsuario
        {
            SUPERADMIN = 1,
            ADMIN = 2
        }

        public enum TipoValidacion
        {
            AccesoCorrecto = 0,
            UsuarioInexistente = 1,
            ContraseñaIncorrecta = 2,
            EstadoInhabilitado = 3
        }

        public enum EstadoTerminal
        {
            Disponible = 0,
            Detenido = 1,
            Ocupado = 2,
            Apagado = 3,
            Ilimitado = 4
        }

        public enum TipoOperacionFactura
        {
            Ninguna = 0,
            Facturar = 1,
            Continuar = 2,
            Anular = 3
        }

        public enum Plantilla
        {
            Ocio = 0,
            Default = 1,
            Personalizada = 2
        }

        public static int MinutosOcio = 2;
    }
}
