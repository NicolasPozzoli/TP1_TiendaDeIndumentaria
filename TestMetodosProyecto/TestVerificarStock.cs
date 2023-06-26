using Microsoft.VisualStudio.TestTools.UnitTesting;
using TiendaVirtualDeIndumentaria;
using System.Collections.Generic;



namespace TestMetodosProyecto
{
    [TestClass]
    public class TestVerificarStock
    {
        [TestMethod]
        public async Task TestVerificarStock_ProductoConStock()
        {
            ManejoDeProductos manejoDeProductos = new ManejoDeProductos();
            string nombreProducto = "Buzo de mina";
            bool resultado = await manejoDeProductos.VerificarStock(nombreProducto);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public async Task TestVerificarStock_ProductoSinStock()
        {
            ManejoDeProductos manejoDeProductos = new ManejoDeProductos();
            string nombreProducto = "Bolso Puma";
            bool resultado = await manejoDeProductos.VerificarStock(nombreProducto);

            Assert.IsFalse(resultado);
            
        }

        [TestMethod]
        public async Task TestVerificarStock_ProductoNoEncontrado()
        {
            ManejoDeProductos manejoDeProductos = new ManejoDeProductos();
            string nombreProducto = "Producto inexistente";
            bool resultado = await manejoDeProductos.VerificarStock(nombreProducto);

            Assert.IsFalse(resultado);

        }
    }
}