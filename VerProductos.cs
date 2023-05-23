using FireSharp.Response;
using Newtonsoft.Json;
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
    public partial class VerProductos : Form
    {
        public VerProductos()
        {
            InitializeComponent();
        }

        private void VerProductos_Load(object sender, EventArgs e)
        {
            Eliminar.CellTemplate.Style.BackColor = Color.Red;
            Eliminar.CellTemplate.Style.ForeColor = Color.White;


        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FireBase producto = new FireBase();
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    string id = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                    await producto.BorrarPorId($"productos\\{id}");
                    MessageBox.Show("Producto eliminado correctamente. Presione Ver datos para actualizar.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private async void btn_verDatos_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FireBase producto = new FireBase();

            FirebaseResponse response = await producto.ObtenerCliente("productos");
            Dictionary<string, Producto> productos = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

            try 
            {
                if (productos != null)
                {
                    foreach (KeyValuePair<string, Producto> elemento in productos)
                    {

                        object[] row = { elemento.Value.Nombre, elemento.Value.Precio, elemento.Value.Stock, elemento.Value.Tipo, elemento.Key, "Eliminar" };
                        dataGridView1.Rows.Add(row);

                        // MOSTRAR BUZOS

                    }
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            } 

        }

        private async void btn_eliminar_Click(object sender, EventArgs e)
        {


        }
    }
}
