using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TiendaVirtualDeIndumentaria
{
    public class Log
    { 
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Accion { get; set; }



        public async void guardarLogEnFirebase(string txbNombre,DateTime fecha,string accion)
        {
            string nombreUsuario = txbNombre;

            if (!string.IsNullOrEmpty(txbNombre) && accion != null)
            {
                FireBase user = new FireBase();
                Log log = new Log
                {
                    Usuario = nombreUsuario,
                    Fecha = fecha,
                    Accion = accion,
                                                       
                };
                await user.IngresarLog(log);
            }
            else
            {
                MessageBox.Show("Error al guardar movimiento.");
            }
        }
     
        }

    }

