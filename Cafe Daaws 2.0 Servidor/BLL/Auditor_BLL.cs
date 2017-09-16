using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cafe_Daaws_2._0_Servidor.BLL
{
    public class Auditor_BLL
    {
        public ENT.Auditoria_ENT Auditoria { get; set; }
        DAL.Auditor.Auditor_DAL Datos = new DAL.Auditor.Auditor_DAL();

        public void Registrar(string Descripcion, string Usuario, ENT.TiposAnidados_ENT.AccionesAuditoria Estado)
        {
            try
            {
                Auditoria = new ENT.Auditoria_ENT();
                Auditoria.Descripcion = Descripcion;
                Auditoria.Fecha = DateTime.Today;
                Auditoria.Estado = Estado;
                Auditoria.Usuario = Usuario;

                Datos.Auditoria = Auditoria;
                Datos.Registrar();

            }
            catch(Exception )
            {
                throw;
            }
        }

        public DataTable Consultar(DateTime Fecha, List<int> AccionesFiltrar, string Usuario)
        {
            DataTable DtAuditoria = new DataTable();
            if (string.IsNullOrEmpty(Usuario))
            {
                AccionesFiltrar.ForEach(A => DtAuditoria.Merge(Datos.Consultar(Fecha, A)));
            }
            else
            {
                AccionesFiltrar.ForEach(A => DtAuditoria.Merge(Datos.Consultar(Fecha, A, Usuario)));
            }

            return DtAuditoria;
        }

    }
}
