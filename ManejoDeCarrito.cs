using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtualDeIndumentaria
{
    public static class ManejoDeCarrito
    {
        public async static void ComprarProducto(string nombre, Carrito carrito)
        {
            int stock;
            FireBase producto = new FireBase();
            FirebaseResponse response = await producto.ObtenerCliente("productos");
            Dictionary<string, Producto> productos = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

            if (productos != null)
            {
                foreach (KeyValuePair<string, Producto> elemento in productos)
                {
                    if (elemento.Value.Nombre == nombre)
                    {
                        stock = elemento.Value.Stock;
                        if (stock > 0)
                        {
                            await producto.ActualizarStockProducto(elemento.Value, elemento.Key, stock - 1);
                            carrito.ingresarProductoCarrito(elemento.Value);
                            MessageBox.Show("Agregado al carrito.");
                        }
                        else
                        {
                            MessageBox.Show("NO HAY MAS STOCK DISPONIBLE!!");
                        }
                    }
                }
            }
            else
            {
                // Tratar el caso en que no hay productos disponibles
            }
        }
    
}
}
