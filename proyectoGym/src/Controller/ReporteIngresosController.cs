using System.Collections.Generic;
using System.IO;

using ProyectoGym.src.Model.Context;
using src.Model.Finanzas;
using src.Model.Inventario;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using Document = QuestPDF.Fluent.Document;
using QuestPDF.Helpers;


namespace ProyectoGym.src.Controller
{
    public class ReporteIngresosController 
    {
        private readonly GymContext _context;

        public ReporteIngresosController(GymContext context)
        {
            _context = context;
        }
        
        public byte[] GenerarReportePDF(List<Factura> facturas, List<Maquina> maquinas)
        {
            var pdfDocument = Document.Create(container =>
            {
            container.Page(page =>
            {
                page.Size(PageSizes.A4);
                page.Content()
                    .Stack(stack =>
                    {
                        stack.Item().Table(table =>
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
                                header.Cell().Text("Monto");
                                header.Cell().Text("Fecha");
                                header.Cell().Text("Fecha Vencimiento");
                            });

                            foreach (var item in facturas)
                            {
                                table.Cell().Text(item.Cliente.NombreCompleto);
                                table.Cell().Text(item.Monto.ToString("C"));
                                table.Cell().Text(item.Fecha.ToString());
                            }
                        });

                        stack.Item().PaddingVertical(20).Text(" "); 

                        stack.Item().Table(table =>
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
                                header.Cell().Text("Nombre");
                                header.Cell().Text("Fecha adquisición");
                                header.Cell().Text("Vida Útil (meses)");
                                header.Cell().Text("Costo");
                            });

                            foreach (var item in maquinas)
                            {
                                table.Cell().Text(item.Nombre);
                                table.Cell().Text(item.FechaAdquisicion);
                                table.Cell().Text(item.VidaUtilMeses);
                                table.Cell().Text(item.costo);
                            }
                        });
                    });
            });
        });

            return pdfDocument.GeneratePdf();
        }
        
    }
}
