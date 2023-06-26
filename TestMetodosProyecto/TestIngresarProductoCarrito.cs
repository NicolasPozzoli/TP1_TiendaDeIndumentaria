using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaVirtualDeIndumentaria;

namespace TestMetodosProyecto
{
    [TestClass]
    internal class TestIngresarProductoCarrito
    {
        [TestMethod]
        public void TestIngresarProductoCarrito_Ok()
        {
            Carrito carrito = new Carrito();
            var nombreProducto = "Buzo";
            var stockProducto = 0;
            var producto = new Producto(nombreProducto, 1000, "link", "Buzo", stockProducto);

            bool resultado = carrito.ingresarProductoCarrito(producto);


            Assert.IsTrue(resultado);
            Assert.AreEqual(1, carrito.getProductos().Count);   //Compara que el tamaño del diccionario de productos en el carrito sea igual a 1.
            Assert.IsTrue(carrito.getProductos().ContainsKey(nombreProducto));    // Verifica que el diccionario de productos en el carrito contenga una clave específica
            Assert.AreEqual(producto, carrito.getProductos()[nombreProducto]);  //Compara que el producto recuperado del carrito con la clave "Producto 1" sea igual al producto original ingresado
        }


        [TestMethod]
        public void TestIngresarProductoCarrito_ErrorProducto()
        {
            Carrito carrito = new Carrito();
            var nombreProducto = "Buzo";
            var stockProducto = 1;
            var producto = new Producto(nombreProducto, 1000, "link", "Buzo", stockProducto);

            bool resultado = carrito.ingresarProductoCarrito(producto);


            Assert.IsFalse(resultado);
            Assert.AreEqual(1, carrito.getProductos().Count);   //Compara que el tamaño del diccionario de productos en el carrito sea igual a 1.
            Assert.IsTrue(carrito.getProductos().ContainsKey(nombreProducto));    // Verifica que el diccionario de productos en el carrito contenga una clave específica
            Assert.AreEqual(producto, carrito.getProductos()[nombreProducto]);  //Compara que el producto recuperado del carrito con la clave "Producto 1" sea igual al producto original ingresado
        }


    }
}
