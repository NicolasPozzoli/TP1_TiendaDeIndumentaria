using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TiendaVirtualDeIndumentaria
{
    public partial class formLogs : Form
    {

        public formLogs()
        {
            InitializeComponent();

        }

        private async void formLogs_Load(object sender, EventArgs e)
        {
            chart1.Hide();
            lbl_titulo.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btn_actualizar_Click_1(object sender, EventArgs e)
        {
            MuestraLogs muestraLogs = new MuestraLogs();
            muestraLogs.MostrarLogsEnDataGridView(dataGridView1);
            muestraLogs.MostrarLogsEnGrafico(chart1);

        }

        private void listaDeMovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chart1.Hide();
            lbl_titulo.Hide();
            dataGridView1.Show();
        }

        private void graficoEstadisticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            chart1.Show();
            lbl_titulo.Show();
        }
    }
}



