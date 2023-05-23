using FireSharp.Interfaces;
using FireSharp.Config;
using Newtonsoft.Json;
using FireSharp.Response;
using FireSharp.Extensions;
using Microsoft.Win32;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace TiendaVirtualDeIndumentaria
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> clientes = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }


        public void CerrarFormulario()
        {
            DialogResult = DialogResult.OK;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        private async void btn_ingresar_Click(object sender, EventArgs e)
        {
            var formUsuario = new Productos();
            FireBase user = new FireBase();
            string usuario = txb_usuario.Text;
            string psw = txb_contraseña.Text;

            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(psw))
            {
                FirebaseResponse response = await user.ObtenerCliente("Usuario/");
                Dictionary<string, Cliente> usuarios = JsonConvert.DeserializeObject<Dictionary<string, Cliente>>(response.Body);

                if (usuarios != null)
                {
                    foreach (KeyValuePair<string, Cliente> elemento in usuarios)
                    {
                        if (elemento.Value.Usuario == usuario && elemento.Value.Contrasenia == psw)
                        {
                            this.Hide();
                            if (elemento.Value.EsAdmin == true)
                            {
                                formUsuario.EsAdmin = true;
                                formUsuario.Show();
                            }
                            else
                            {
                                formUsuario.Show();
                            }
                        }
                        else
                        {
                            label_error.Text = "Error. Usuario o contraseña incorrectos.";
                        }
                    }
                }
                else {
                    MessageBox.Show("No hay usuarios creados. Registrese para empezar.");
                }

            }
            else
            {
                MessageBox.Show("Error al iniciar sesion.");
                txb_usuario.Text = "";
                txb_contraseña.Text = "";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formRegistro = new Registro();

            string usuario = txb_usuario.Text;
            string psw = txb_contraseña.Text;

            if (formRegistro.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}