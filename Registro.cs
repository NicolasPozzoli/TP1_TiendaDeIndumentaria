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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string usuario = txb_usuario.Text;
            string psw = txb_contraseña.Text;
            bool esAdmin;

            try 
            {
                if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(psw))
                {
                    if (usuario == "admin")
                    {
                        esAdmin=true;
                    }
                    else 
                    {
                        esAdmin = false;
                    }
                    Random id = new Random();
                    var registro = new Cliente()
                    {
                        IdCliente = id.Next().ToString(),
                        Usuario = usuario,
                        Contrasenia = psw,
                        EsAdmin = esAdmin,
                    };
                    FireBase user = new FireBase();

                    await user.IngresarCliente(registro);
                    MessageBox.Show("Registrado correctamente.");
                    Close();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }



        }
    }
}
