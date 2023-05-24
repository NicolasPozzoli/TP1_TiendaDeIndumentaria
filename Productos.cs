using FireSharp.Config;
using FireSharp.Response;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TiendaVirtualDeIndumentaria
{
    public partial class Productos : Form
    {
        Label[] labelsNombre = new Label[8];
        Button[] botonComprar = new Button[8];
        Label[] labelsPrecios = new Label[8];
        PictureBox[] imagenes = new PictureBox[8];
     //   ProductosEnCarrito productosEnCarrito;
        public Productos()
        {
            InitializeComponent();
        }

        private bool _esAdmin;

        public bool EsAdmin
        {
            get { return _esAdmin; }
            set
            {
                _esAdmin = value;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //AGREGAR PRODUCTOS
            var formAgregarProducto = new AgregarProducto();
            formAgregarProducto.ShowDialog();

        }

        private async void Productos_Load(object sender, EventArgs e)
        {
            if (!EsAdmin)
            {
                label_admin.Hide();
                button2.Hide();
                btn_verProductos.Hide();
                button11.Hide();
                button12.Hide();

            }
            ocultarBotonesComprar();
            labelsNombre = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8 };
            botonComprar = new Button[] { comprar1, comprar2, comprar3, comprar4, comprar5, comprar6, comprar7, comprar8 };
            labelsPrecios = new Label[] {label9,label10,label11,label12,
                label13,label14,label15,label16,
            };
            imagenes = new PictureBox[]{
                pictureBox1,pictureBox2,pictureBox3,pictureBox4
                ,pictureBox5,pictureBox6,pictureBox7,pictureBox8
            };
         //   productosEnCarrito = new ProductosEnCarrito();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            mostrarBotonesComprar();
            FiltrarProductosPorTipo("Buzo");

        }

        private async void btn_pantalones_Click(object sender, EventArgs e)
        {
            mostrarBotonesComprar();
            FiltrarProductosPorTipo("Pantalon");

        }

        private async void btn_remeras_Click(object sender, EventArgs e)
        {
            mostrarBotonesComprar();
            FiltrarProductosPorTipo("Remera");

        }

        private async void btn_ropaInterior_Click(object sender, EventArgs e)
        {
            FiltrarProductosPorTipo("Ropa interior");

        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            mostrarBotonesComprar();
            FiltrarProductosPorTipo("Accesorio");

        }

        private async void btn_borrarProductos_Click(object sender, EventArgs e)
        {

        }

        private async void btn_verProductos_Click(object sender, EventArgs e)
        {
            VerProductos formVerProductos = new VerProductos();

            formVerProductos.ShowDialog();
        }
        private void mostrarBotonesComprar()
        {
            comprar1.Show();
            comprar2.Show();
            comprar3.Show();
            comprar4.Show();
            comprar5.Show();
            comprar6.Show();
            comprar7.Show();
            comprar8.Show();
        }

        private void ocultarBotonesComprar()
        {
            comprar1.Hide();
            comprar2.Hide();
            comprar3.Hide();
            comprar4.Hide();
            comprar5.Hide();
            comprar6.Hide();
            comprar7.Hide();
            comprar8.Hide();
        }

        private void limpiarProductos(Label[] nombre, Label[] precio, PictureBox[] imegenes)
        {
            for (int i = 0; i < nombre.Length; i++)
            {
                nombre[i].Hide();
                precio[i].Hide();
                imegenes[i].Hide();
            }
        }

        private async void FiltrarProductosPorTipo(string tipo)
        {
            ocultarBotonesComprar();
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
                
                ocultarBotonesComprar();
                label1.Hide();
                label9.Hide();
                pictureBox1.Hide();
            }


        }



        private async void descontarStock(string nombre)
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
                       stock= elemento.Value.Stock;
                        if (stock > 0)
                        {
                            await producto.ActualizarStockProducto(elemento.Value, elemento.Key, stock - 1);
                            MessageBox.Show("Producto Comprado.");
                        }
                        else {
                            MessageBox.Show("NO HAY MAS STOCK DISPONIBLE!!");
                        }
                    }

                }
            }
            else
            {
               
                ocultarBotonesComprar();
                label1.Hide();
                label9.Hide();
                pictureBox1.Hide();
            }


        }


        private void button11_Click(object sender, EventArgs e)
        {
            VerClientes formVerClientes = new VerClientes();
            formVerClientes.EsAdmin = true;
            formVerClientes.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            StockProducto formReponerStock = new StockProducto();

            formReponerStock.ShowDialog();
        }

        private void comprar1_Click(object sender, EventArgs e)
        {
            descontarStock(label1.Text);
        }

        private void comprar2_Click(object sender, EventArgs e)
        {
            descontarStock(label2.Text);
        }

        private void comprar3_Click(object sender, EventArgs e)
        {
            descontarStock(label3.Text);
        }

        private void comprar4_Click(object sender, EventArgs e)
        {
            descontarStock(label4.Text);
        }

        private void comprar5_Click(object sender, EventArgs e)
        {
            descontarStock(label5.Text);
        }

        private void comprar6_Click(object sender, EventArgs e)
        {
            descontarStock(label6.Text);
        }

        private void comprar7_Click(object sender, EventArgs e)
        {
            descontarStock(label7.Text);
        }

        private void comprar8_Click(object sender, EventArgs e)
        {
            descontarStock(label8.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
