using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtualDeIndumentaria
{
    internal class ProductosEnCarrito
    {

        List<Producto> productosCarrito;

        public List<Producto> ProductosCarrito
        {
            get { return productosCarrito; }
        }
        public ProductosEnCarrito() 
        {
            productosCarrito = new List<Producto>();

        }

        public void agregarACarrito(Producto producto)
        {
            productosCarrito.Add(producto);
        }

    }


}
