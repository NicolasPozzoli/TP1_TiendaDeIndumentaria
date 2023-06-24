using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVirtualDeIndumentaria
{
    public partial class CarritoForm : Form
    {
     //   public static List<Compra> comprasLista = new List<Compra>();
      //  public static string nombreComprador = Productos.nombreComprador;
        public static string nombreProducto= Productos.nombreProducto;
        public static decimal precio= Productos.precio;
        string claveProducto;
        decimal precioFinal = 0;
        private Dictionary<string, Producto> productos;
        private ImageList listaDeImagenes;

      
        public CarritoForm(Dictionary<string, Producto> productosSeleccionados)
        {

            InitializeComponent();
            productos = productosSeleccionados;
            


            listaDeImagenes = new ImageList();
            listaDeImagenes.ImageSize = new Size(50, 50);

            int index = 0;

            foreach (var producto in productos.Values)
            {

                Image imagen = ObtenerImagenDesdeURL(producto.LinkImagen);

                if (imagen != null)
                {
                    listaDeImagenes.Images.Add(imagen);
                }
                else
                {

                }
                precioFinal += producto.Precio;


                ListViewItem item = new ListViewItem();
                item.Text = producto.Nombre;
                item.ImageIndex = index;
                listViewCarrito.Items.Add(item);

                index++;
            }



            listViewCarrito.LargeImageList = listaDeImagenes;
        }
        private void mostrarPrecioFinal(decimal precio)
        {
            label_precio.Text = "Precio final:  $" + precio.ToString();
        }

        private Image ObtenerImagenDesdeURL(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                byte[] bytes = webClient.DownloadData(url);
                MemoryStream ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch (Exception)
            {
                return null;
            }
        }


        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }



        private void btnVaciarCarrito_Click_1(object sender, EventArgs e)
        {

            listViewCarrito.Items.Clear();
            productos.Clear();
        }

        private void CarritoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listViewCarrito.SelectedItems.Count > 0)
            {
                int index = listViewCarrito.SelectedIndices[0];
                 claveProducto = listViewCarrito.Items[index].Text;
                listViewCarrito.Items.RemoveAt(index);
                productos.Remove(claveProducto);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            confirmarCompraEmergente(precioFinal);
        }
        private void confirmarCompraEmergente(decimal precio)
        {
            string mensaje = "El precio final de la compra es $" + precio.ToString() + " ¿Desea confirmar?";
            string titulo = "Confirmacion";
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            if (resultado == DialogResult.OK)
            {
                try 
                {

                    label_precio.Text = "Compra realizada con exito.";
                    label_precio.ForeColor = Color.Green;

                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (resultado == DialogResult.Cancel)
            {

            }
        }
    }
}
