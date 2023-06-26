using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVirtualDeIndumentaria;

namespace TestMetodosProyecto
{
    [TestClass]
    internal class TestExportarCsv
    {
        [TestMethod]
        public void TestExportarEnCSV_Ok()
        {
            var productos = new Dictionary<string, Producto>();

            string nombreArchivo = "productos_test.csv";

            InformesGenerados.ExportarCSV(productos, nombreArchivo);

            string rutaArchivo = Path.Combine("C:\\Users\\Nicolas\\source\\repos\\TiendaVirtualDeIndumentaria\\Exportaciones", nombreArchivo);
            Assert.IsTrue(File.Exists(rutaArchivo), "El archivo CSV no fue generado correctamente.");
        }


        [TestMethod]
        public void TestExportarEnCSV_ErrorEnPath()
        {
            var productos = new Dictionary<string, Producto>();

            string nombreArchivo = "productos_test.csv";

            InformesGenerados.ExportarCSV(productos, nombreArchivo);

            string rutaArchivo = Path.Combine("C://Path//erroneo//ejemplo", nombreArchivo);
            Assert.IsTrue(File.Exists(rutaArchivo), "El archivo CSV no fue generado correctamente.");
        }



        [TestMethod]
        public void TestExportarEnCSV_ErrorEnNombre()
        {
            var productos = new Dictionary<string, Producto>();

            string nombreArchivo = "12345";

            InformesGenerados.ExportarCSV(productos, nombreArchivo);

            string rutaArchivo = Path.Combine("C://Path//erroneo//ejemplo", nombreArchivo);
            Assert.IsTrue(File.Exists(rutaArchivo), "El archivo CSV no fue generado correctamente.");
        }


    }
}
