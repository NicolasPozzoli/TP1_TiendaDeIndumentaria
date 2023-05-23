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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TiendaVirtualDeIndumentaria
{
    public partial class Productos : Form
    {
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
            MessageBox.Show($"{EsAdmin}");
            ocultarBotonesComprar();
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
            button10.Show();
            button9.Show();
            button3.Show();
            button4.Show();
            button8.Show();
            button7.Show();
            button6.Show();
            button5.Show();
        }

        private void ocultarBotonesComprar()
        {
            button10.Hide();
            button9.Hide();
            button3.Hide();
            button4.Hide();
            button8.Hide();
            button7.Hide();
            button6.Hide();
            button5.Hide();
        }

        private async void FiltrarProductosPorTipo(string tipo)
        {
            FireBase producto = new FireBase();
            Label[] labels;

            FirebaseResponse response = await producto.ObtenerCliente("productos");
            Dictionary<string, Producto> productos = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

            if (productos != null)
            {
                MessageBox.Show("Entro al if de si hay productos.");
                foreach (KeyValuePair<string, Producto> elemento in productos)
                {
                    if (elemento.Value.Tipo == tipo)
                    {
                        //metodo para cargar labels
                        label1.Text = elemento.Value.Nombre;
                        label9.Text = elemento.Value.Precio.ToString();
                        pictureBox2.Image = Image.FromFile(elemento.Value.LinkImagen);
                        // MOSTRAR BUZOS
                    }
                }
            }
            else
            {
                MessageBox.Show("Entro al else de no hay productos.");
                ocultarBotonesComprar();
                label1.Hide();
                label9.Hide();
                pictureBox2.Hide();
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
    }
}
