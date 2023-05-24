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
    public partial class StockProducto : Form
    {
        public StockProducto()
        {
            InitializeComponent();
        }

        private void StockProducto_Load(object sender, EventArgs e)
        {
            Reponer.CellTemplate.Style.BackColor = Color.Green;
            Reponer.CellTemplate.Style.ForeColor = Color.White;
        }

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int stock = int.Parse(numeric_stock.Text);
            FireBase producto = new FireBase();
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Reponer")
                {
                    string id = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                    FirebaseResponse response = await producto.ObtenerCliente("productos");
                    Dictionary<string, Producto> productos = JsonConvert.DeserializeObject<Dictionary<string, Producto>>(response.Body);

                    try
                    {
                        if (productos != null)
                        {
                            foreach (KeyValuePair<string, Producto> elemento in productos)
                            {
                                if (elemento.Key == id)
                                {

                                    await producto.ActualizarStockProducto(elemento.Value,id,stock);
                          
                                    //elemento.Value.Stock=stock;
                                    //MessageBox.Show($"stock : {elemento.Value.Stock}");
                                   
                                }

                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    MessageBox.Show("Stock actualizado correctamente. Presione Ver datos para actualizar.");
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

                        object[] row = { elemento.Value.Nombre, elemento.Value.Precio, elemento.Value.Stock, elemento.Value.Tipo, elemento.Key, "Reponer" };
                        dataGridView1.Rows.Add(row);

                        // MOSTRAR BUZOS

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
    }

