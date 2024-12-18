using System.Collections.Generic;
using System.IO;

using ProyectoGym.src.Model.Context;
using src.Model.Finanzas;
using src.Model.Gestion;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;
using QuestPDF.Helpers;


namespace ProyectoGym.src.Controller
{
    public class ReporteMatriculaController 
    {
        private readonly GymContext _context;

        public ReporteMatriculaController(GymContext context)
        {
            _context = context;
        }

        public byte[] GenerarReportePDF(List<Membresia> membresia)
        {
            var pdfDocument = Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Content()
                        .Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(100);
                                columns.RelativeColumn(1);  
                                columns.RelativeColumn(1);   
                                columns.RelativeColumn(1);   
                            });

                            table.Header(header =>
                            {
                                header.Cell().Text("Nombre cliente");
                                header.Cell().Text("Costo");
                                header.Cell().Text("Fecha Inicio");
                                header.Cell().Text("Fecha Vencimiento");
                            });

                            foreach (var item in membresia)
                            {
                                table.Cell().Text(item.Cliente.NombreCompleto);
                                table.Cell().Text(item.Costo.ToString());
                                table.Cell().Text(item.FechaInicio.ToString());
                                table.Cell().Text(item.FechaVencimiento.ToShortDateString());
                            }
                        });
                });
            });

            return pdfDocument.GeneratePdf();
        }
        
    }
}
