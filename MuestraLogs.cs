using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TiendaVirtualDeIndumentaria
{
    internal class MuestraLogs
    {
        private FireBase firebase;

        public MuestraLogs()
        {
            firebase = new FireBase();
        }


        public async void MostrarLogsEnDataGridView(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            FireBase logs = new FireBase();

            FirebaseResponse response = await logs.ObtenerCliente("movimientos");
            Dictionary<string, Log> movimientos = JsonConvert.DeserializeObject<Dictionary<string, Log>>(response.Body);

            try
            {
                if (movimientos != null)
                {
                    foreach (KeyValuePair<string, Log> elemento in movimientos)
                    {

                        object[] row = { elemento.Value.Usuario, elemento.Value.Fecha, elemento.Value.Accion };
                        dataGridView.Rows.Add(row);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public async void MostrarLogsEnGrafico(Chart chart)
        {
            FireBase logs = new FireBase();

            FirebaseResponse response = await logs.ObtenerCliente("movimientos");
            Dictionary<string, Log> movimientos = JsonConvert.DeserializeObject<Dictionary<string, Log>>(response.Body);

            chart.Series.Clear();
            Series serie = new Series("Acciones por Usuario");

            var accionesPorUsuario = movimientos.GroupBy(log => log.Value.Usuario)
                                         .Select(group => new
                                         {
                                             Usuario = group.Key,
                                             CantidadAcciones = group.Count()
                                         });

            foreach (var usuario in accionesPorUsuario)
            {
                serie.Points.AddXY(usuario.Usuario, usuario.CantidadAcciones);
            }

            chart.Series.Add(serie);
            chart.ChartAreas[0].AxisX.Title = "Usuarios";
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisY.Title = "Cantidad de Acciones";
            chart.Refresh();
        }
    }

}

