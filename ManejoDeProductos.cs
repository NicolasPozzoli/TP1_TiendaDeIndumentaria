using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaVirtualDeIndumentaria
{
    public class ManejoDeProductos
    {
        public static void mostrarBotonesComprar(Button[] botonComprar)
        {
            foreach (Button boton in botonComprar)
            {
                boton.Show();
            }
        }

        public static void ocultarBotonesComprar(Button[] botonComprar)
        {
            foreach (Button boton in botonComprar)
            {
                boton.Hide();
            }
        }
        private static void limpiarProductos(Label[] nombre, Label[] precio, PictureBox[] imegenes)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                nombre[i].Hide();
                precio[i].Hide();
                imegenes[i].Hide();
            }
        }


        public async static void FiltrarProductosPorTipo(string tipo, Label[] labelsNombre, Label[] labelsPrecios, PictureBox[] imagenes, Button[] botonComprar)
        {
            ocultarBotonesComprar(botonComprar);
            limpiarProductos(labelsNombre, labelsPrecios, imagenes);
            FireBase producto = new FireBase();
            FirebaseResponse response = await producto.ObtenerCliente("productos");
            Dictionary<string, Producto> productos = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

            if (productos != null)
            {
                int index = 0;
                foreach (KeyValuePair<string, Producto> elemento in productos)
                {
                    if (elemento.Value.Tipo == tipo)
                    {
                        MuestraProducto.CargarNombre(labelsNombre, index, elemento.Value.Nombre);
                        MuestraProducto.CargarPrecio(labelsPrecios, index, elemento.Value.Precio);
                        MuestraProducto.CargarImagen(imagenes, index, elemento.Value.LinkImagen);
                        botonComprar[index].Show();
                        labelsNombre[index].Show();
                        labelsPrecios[index].Show();
                        imagenes[index].Show();
                        index++;
                    }
                }
            }
            else
            {
                ocultarBotonesComprar(botonComprar);
                // Ocultar otros controles si es necesario
            }
        }

        public async static void VerificarStock(string nombre)
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
                            MessageBox.Show("Este producto tiene stock disponible");
                        }
                        else
                        {
                            MessageBox.Show("ESTE PRODUCTO YA NO TIENE STOCK!!");
                        }
                    }
                }
            }
          
        }



    }
}
