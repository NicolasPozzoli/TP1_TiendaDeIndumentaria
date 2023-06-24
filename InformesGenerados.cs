using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace TiendaVirtualDeIndumentaria
{
    internal class InformesGenerados
    {
        public static void ExportarCSV(Dictionary<string, Producto> productos, string nombreArchivo)
        {
            string rutaArchivo = Path.Combine("C:\\Users\\Nicolas\\source\\repos\\TiendaVirtualDeIndumentaria\\Exportaciones", nombreArchivo);
            using (StreamWriter writer = new StreamWriter(rutaArchivo))
            {
                
                writer.WriteLine("Nombre, Precio, Cantidad");
                foreach (var producto in productos.Values)
                {
                    string linea = $"{producto.Nombre}, {producto.Precio}, {producto.Stock}";
                    writer.WriteLine(linea);
                }
            }
        }

        public static void ExportarJSON(Dictionary<string, Producto> productos, string nombreArchivo)
        {
         
            string rutaArchivo = Path.Combine("C:\\Users\\Nicolas\\source\\repos\\TiendaVirtualDeIndumentaria\\Exportaciones", nombreArchivo);
            string json = JsonConvert.SerializeObject(productos, Formatting.Indented);

            
            File.WriteAllText(rutaArchivo, json);
        }


        public static void ExportarPDF(Dictionary<string, Producto> productos, string nombreArchivo)
        {
            string rutaArchivo = Path.Combine("C:\\Users\\Nicolas\\source\\repos\\TiendaVirtualDeIndumentaria\\Exportaciones", nombreArchivo);

            using (Document doc = new Document())
            {
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();//ABRO EL DOCUMENTO
                    PdfPTable tablaProductos = new PdfPTable(3); // CREO TABLA

                   // tablaProductos.DefaultCell.Border = Rectangle.NO_BORDER; // MAL
                    tablaProductos.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;

                    // ENCABEZADO
                    tablaProductos.AddCell("Nombre");
                    tablaProductos.AddCell("Precio");
                    tablaProductos.AddCell("Cantidad");

                    foreach (var producto in productos.Values)
                    {
                        tablaProductos.AddCell(producto.Nombre);
                        tablaProductos.AddCell(producto.Precio.ToString());
                        tablaProductos.AddCell(producto.Stock.ToString());
                    }
                    doc.Add(tablaProductos);
                    doc.Close();
                }
            }
        }

    }
}
