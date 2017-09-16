using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Daaws_2._0_Servidor
{
    public class ExportadorArchivo
    {
        DataGridView Data;
        public ExportadorArchivo(DataGridView Dtg, string NombreArchivo)
        {
            Data = Dtg;
            Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10);
            string filename = NombreArchivo + ".pdf";
            FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            PdfWriter.GetInstance(doc, file); 
            doc.Open();
            GenerarDocumento(doc);
            doc.Close();
            Process.Start(filename);
        }

        public void GenerarDocumento(Document document)
        {
            PdfPTable datatable = new PdfPTable(Data.ColumnCount);
            datatable.DefaultCell.Padding = 3;
            float[] headerwidths = GetTamañoColumnas();
            datatable.SetWidths(headerwidths);
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 2;
            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

            for (int i = 0; i < Data.ColumnCount; i++)
            {
                datatable.AddCell(Data.Columns[i].HeaderText);
            }

            datatable.HeaderRows = 1;
            datatable.DefaultCell.BorderWidth = 1;

            for (int i = 0; i < Data.RowCount; i++)
            {
                for (int j = 0; j < Data.ColumnCount; j++)
                {
                    datatable.AddCell(Data[j, i].Value.ToString());

                }
                datatable.CompleteRow();

            }
            document.Add(datatable);
        }

        public float[] GetTamañoColumnas()
        {

            float[] values = new float[Data.ColumnCount];
            for (int i = 0; i < Data.ColumnCount; i++)
            {
                values[i] = (float)Data.Columns[i].Width;
            }
            return values;
        }

    }
}
