using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaVirtualDeIndumentaria
{
    public partial class AgregarProducto : Form
    {
        private string linkDeImagen;
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void lbl_usuario_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void btn_ingresar_Click(object sender, EventArgs e)
        {

            string nombreProducto = txb_nombreProducto.Text;
            decimal precio = numericUpDown1.Value;
            int stock = int.Parse(numericUpDown2.Text);
            string tipo = comboBox_tipo.Text;

            if (!string.IsNullOrEmpty(nombreProducto) && !string.IsNullOrEmpty(tipo) && stock > 0 && precio > 0 && linkDeImagen != null)
            {
                var producto = new Producto(nombreProducto, precio, linkDeImagen, tipo, stock);
                FireBase user = new FireBase();

                await user.IngresarProducto(producto);
                MessageBox.Show("Producto creado correctamente.");
                Close();
            }
            else
            {
                MessageBox.Show("Error al crear un producto.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "|*.jpg; *.png; *.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(ofd.FileName);
                linkDeImagen = ofd.FileName;
            }
            else
            {
                linkDeImagen = null;
            }
        }
    }
}
