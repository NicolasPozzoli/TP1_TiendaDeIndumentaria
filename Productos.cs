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
        public event EventHandler<string> SeccionSeleccionada;   //EVENTO PROPIO
        Dictionary<string, Producto> productos;
        public string NombreUsuario { get; set; }
        //   public static List<Compra> comprasLista = new List<Compra>();
        public static string nombreProducto;
        public static decimal precio;
        Carrito carrito = new Carrito();
        Label[] labelsNombre = new Label[8];
        Button[] botonComprar = new Button[8];
        Label[] labelsPrecios = new Label[8];
        PictureBox[] imagenes = new PictureBox[8];
        //   ProductosEnCarrito productosEnCarrito;
        public Productos()
        {
            InitializeComponent();

        }

        private void EventoSeccionSeleccionada(string seccion)
        {
            SeccionSeleccionada?.Invoke(this, seccion);
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
            string nombre = NombreUsuario;
            label_nombreUser.Text = $"!Holaaa {nombre}¡¡";
            if (!EsAdmin)
            {
                label_admin.Hide();
                button2.Hide();
                btn_verProductos.Hide();
                button11.Hide();
                button12.Hide();
                btn_verMovimientos.Hide();
            }

            labelsNombre = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8 };
            botonComprar = new Button[] { comprar1, comprar2, comprar3, comprar4, comprar5, comprar6, comprar7, comprar8 };
            labelsPrecios = new Label[] {label9,label10,label11,label12,
                label13,label14,label15,label16,
            };
            imagenes = new PictureBox[]{
                pictureBox1,pictureBox2,pictureBox3,pictureBox4
                ,pictureBox5,pictureBox6,pictureBox7,pictureBox8
            };

            ManejoDeProductos.ocultarBotonesComprar(botonComprar);
            //   productosEnCarrito = new ProductosEnCarrito();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string seccionSeleccionada = "Buzos";
            ManejoDeProductos.mostrarBotonesComprar(botonComprar);
            EventoSeccionSeleccionada(seccionSeleccionada);
            ManejoDeProductos.FiltrarProductosPorTipo("Buzo", labelsNombre, labelsPrecios, imagenes, botonComprar);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} ingreso a la seccion Buzo");
        }

        private async void btn_pantalones_Click(object sender, EventArgs e)
        {
            ManejoDeProductos.mostrarBotonesComprar(botonComprar);
            //mostrarBotonesComprar();
            ManejoDeProductos.FiltrarProductosPorTipo("Pantalon", labelsNombre, labelsPrecios, imagenes, botonComprar);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} ingreso a la seccion Pantalon");

        }

        private async void btn_remeras_Click(object sender, EventArgs e)
        {
            ManejoDeProductos.mostrarBotonesComprar(botonComprar);
            //mostrarBotonesComprar();
            ManejoDeProductos.FiltrarProductosPorTipo("Remera", labelsNombre, labelsPrecios, imagenes, botonComprar);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} ingreso a la seccion Remera");
        }

        private async void btn_ropaInterior_Click(object sender, EventArgs e)
        {
            ManejoDeProductos.mostrarBotonesComprar(botonComprar);
            //mostrarBotonesComprar();
            ManejoDeProductos.FiltrarProductosPorTipo("Ropa interior", labelsNombre, labelsPrecios, imagenes, botonComprar);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} ingreso a la seccion Ropa Interior");
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            ManejoDeProductos.mostrarBotonesComprar(botonComprar);
            //mostrarBotonesComprar();
            ManejoDeProductos.FiltrarProductosPorTipo("Accesorio", labelsNombre, labelsPrecios, imagenes, botonComprar);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} ingreso a la seccion Accesorio");
        }

        private async void btn_borrarProductos_Click(object sender, EventArgs e)
        {

        }

        private async void btn_verProductos_Click(object sender, EventArgs e)
        {
            VerProductos formVerProductos = new VerProductos();

            formVerProductos.ShowDialog();
        }


        private void validarPrecio(Label labelPrecio)
        {
            string contenidoLabel = label9.Text;

            if (contenidoLabel.Length > 1)
            {
                string contenidoSinPrimerCaracter = contenidoLabel.Substring(1);
                precio = decimal.Parse(contenidoSinPrimerCaracter);
            }
            else
            {
            }
        }

        public void cargarCompra(string nombreProducto, decimal precio)
        {

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
            // comprarProducto(label1.Text);
            nombreProducto = label1.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label9);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");

        }

        private void comprar2_Click(object sender, EventArgs e)
        {
            //  comprarProducto(label2.Text);
            nombreProducto = label2.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label10);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");
        }

        private void comprar3_Click(object sender, EventArgs e)
        {
            //  comprarProducto(label3.Text);
            nombreProducto = label3.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label11);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");
        }

        private void comprar4_Click(object sender, EventArgs e)
        {
            // comprarProducto(label4.Text);
            nombreProducto = label4.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label12);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");
        }

        private void comprar5_Click(object sender, EventArgs e)
        {
            //  comprarProducto(label5.Text);
            nombreProducto = label5.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label13);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");
        }

        private void comprar6_Click(object sender, EventArgs e)
        {
            //  comprarProducto(label6.Text);
            nombreProducto = label6.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label14);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");
        }

        private void comprar7_Click(object sender, EventArgs e)
        {
            // comprarProducto(label7.Text);
            nombreProducto = label7.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label15);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");
        }

        private void comprar8_Click(object sender, EventArgs e)
        {
            // comprarProducto(label8.Text);
            nombreProducto = label8.Text;
            ManejoDeCarrito.ComprarProducto(nombreProducto, carrito);
            validarPrecio(label16);
            Log log = new Log();
            log.guardarLogEnFirebase(NombreUsuario, DateTime.Now, $"El usuario {NombreUsuario} agrego un producto al carrito");
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Dictionary<string, Producto> productos = carrito.getProductos();
            CarritoForm formCarrito = new CarritoForm(productos);

            formCarrito.ShowDialog();
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void exportarEnCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, Producto> productos = carrito.getProductos();
            string nombreArchivo = "productos.csv";
            InformesGenerados.ExportarCSV(productos, nombreArchivo);
            MessageBox.Show("Informe CSV generado correctamente.");
        }

        private void exportarEnJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, Producto> productos = carrito.getProductos();
            string nombreArchivo = "productos.json";
            InformesGenerados.ExportarJSON(productos, nombreArchivo);
            MessageBox.Show("Informe JSON generado correctamente.");
        }

        private void exportarEnPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dictionary<string, Producto> productos = carrito.getProductos();

            string nombreArchivo = "productos.pdf";
            InformesGenerados.ExportarPDF(productos, nombreArchivo);
            MessageBox.Show("El archivo PDF ha sido generado correctamente.", "Exportación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_verMovimientos_Click_1(object sender, EventArgs e)
        {
            formLogs formMovimientos = new formLogs();

            formMovimientos.ShowDialog();
        }
    }
}
