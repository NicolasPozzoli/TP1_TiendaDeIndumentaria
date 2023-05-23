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
    public partial class VerClientes : Form
    {
        public VerClientes()
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



        private void VerClientes_Load_1(object sender, EventArgs e)
        {
            Eliminar.CellTemplate.Style.BackColor = Color.Red;
            Eliminar.CellTemplate.Style.ForeColor = Color.White;


        }

        private async void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            FireBase producto = new FireBase();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                string id = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                await producto.BorrarPorId($"Usuario\\{id}");
                MessageBox.Show($"{id}");
                MessageBox.Show("Usuario eliminado correctamente. Presione Ver datos para actualizar.");
            }

        }

        private async void btn_verDatos_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FireBase cliente = new FireBase();
            string rol;

            FirebaseResponse response = await cliente.ObtenerCliente("Usuario");
            Dictionary<string, Cliente> clientes = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

            try 
            {
                if (clientes != null)
                {
                    foreach (KeyValuePair<string, Cliente> elemento in clientes)
                    {
                        if (elemento.Value.EsAdmin)
                        {
                            rol = "Administrador";
                        }
                        else
                        {
                            rol = "Usuario";
                        }

                        object[] row = { elemento.Value.Usuario, elemento.Value.Contrasenia, rol, elemento.Key, "Eliminar" };
                        dataGridView1.Rows.Add(row);

                        // MOSTRAR BUZOS

                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message );
            }


        }
    }
}
