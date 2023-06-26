using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtualDeIndumentaria
{
     public class Carrito
    {
        Dictionary<string,Producto> productos = new Dictionary<string, Producto>();
        public Carrito() 
        {


           

           


        }

        public bool ingresarProductoCarrito(Producto producto) 
        {
            string claveProducto = producto.Nombre;
            try {
                productos.Add(claveProducto, producto);
                return true;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public Dictionary<string,Producto> getProductos() {  return productos; }


    }
}
