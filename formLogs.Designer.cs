namespace TiendaVirtualDeIndumentaria
{
    partial class formLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridView1 = new DataGridView();
            usuario = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            accion = new DataGridViewTextBoxColumn();
            btn_actualizar = new Button();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            menuStrip1 = new MenuStrip();
            listaDeMovimientosToolStripMenuItem = new ToolStripMenuItem();
            graficoEstadisticoToolStripMenuItem = new ToolStripMenuItem();
            lbl_titulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { usuario, fecha, accion });
            dataGridView1.Location = new Point(301, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(955, 514);
            dataGridView1.TabIndex = 0;
            // 
            // usuario
            // 
            usuario.HeaderText = "Usuario";
            usuario.MinimumWidth = 6;
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 200;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            fecha.Width = 200;
            // 
            // accion
            // 
            accion.HeaderText = "Accion";
            accion.MinimumWidth = 6;
            accion.Name = "accion";
            accion.ReadOnly = true;
            accion.Width = 500;
            // 
            // btn_actualizar
            // 
            btn_actualizar.FlatStyle = FlatStyle.Flat;
            btn_actualizar.Font = new Font("SimSun-ExtB", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_actualizar.Location = new Point(33, 123);
            btn_actualizar.Name = "btn_actualizar";
            btn_actualizar.Size = new Size(129, 49);
            btn_actualizar.TabIndex = 54;
            btn_actualizar.Text = "Actualizar";
            btn_actualizar.UseVisualStyleBackColor = true;
            btn_actualizar.Click += btn_actualizar_Click_1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(253, 102);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(1060, 543);
            chart1.TabIndex = 55;
            chart1.Text = "chart1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { listaDeMovimientosToolStripMenuItem, graficoEstadisticoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1482, 28);
            menuStrip1.TabIndex = 58;
            menuStrip1.Text = "menuStrip1";
            // 
            // listaDeMovimientosToolStripMenuItem
            // 
            listaDeMovimientosToolStripMenuItem.Name = "listaDeMovimientosToolStripMenuItem";
            listaDeMovimientosToolStripMenuItem.Size = new Size(164, 24);
            listaDeMovimientosToolStripMenuItem.Text = "Lista de movimientos";
            listaDeMovimientosToolStripMenuItem.Click += listaDeMovimientosToolStripMenuItem_Click;
            // 
            // graficoEstadisticoToolStripMenuItem
            // 
            graficoEstadisticoToolStripMenuItem.Name = "graficoEstadisticoToolStripMenuItem";
            graficoEstadisticoToolStripMenuItem.Size = new Size(146, 24);
            graficoEstadisticoToolStripMenuItem.Text = "Grafico estadistico";
            graficoEstadisticoToolStripMenuItem.Click += graficoEstadisticoToolStripMenuItem_Click;
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Sitka Subheading", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_titulo.ForeColor = SystemColors.ActiveCaptionText;
            lbl_titulo.Location = new Point(549, 48);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(440, 33);
            lbl_titulo.TabIndex = 59;
            lbl_titulo.Text = "Usuarios que mas interactuan en la app";
            // 
            // formLogs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1482, 670);
            Controls.Add(lbl_titulo);
            Controls.Add(chart1);
            Controls.Add(btn_actualizar);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "formLogs";
            Text = "formLogs";
            Load += formLogs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_actualizar;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn accion;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem listaDeMovimientosToolStripMenuItem;
        private ToolStripMenuItem graficoEstadisticoToolStripMenuItem;
        private Label lbl_titulo;
    }
}