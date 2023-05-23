namespace TiendaVirtualDeIndumentaria
{
    partial class StockProducto
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
            btn_verDatos = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Reponer = new DataGridViewButtonColumn();
            lbl_reponer = new Label();
            label1 = new Label();
            numeric_stock = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_stock).BeginInit();
            SuspendLayout();
            // 
            // btn_verDatos
            // 
            btn_verDatos.Location = new Point(60, 87);
            btn_verDatos.Name = "btn_verDatos";
            btn_verDatos.Size = new Size(116, 42);
            btn_verDatos.TabIndex = 5;
            btn_verDatos.Text = "Ver datos";
            btn_verDatos.UseVisualStyleBackColor = true;
            btn_verDatos.Click += btn_verDatos_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Reponer });
            dataGridView1.Location = new Point(256, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(806, 426);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Precio";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Stock";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Tipo";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Id";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Reponer
            // 
            Reponer.FlatStyle = FlatStyle.Flat;
            Reponer.HeaderText = "";
            Reponer.MinimumWidth = 6;
            Reponer.Name = "Reponer";
            Reponer.ReadOnly = true;
            Reponer.Text = "Reponer";
            Reponer.Width = 125;
            // 
            // lbl_reponer
            // 
            lbl_reponer.AutoSize = true;
            lbl_reponer.Location = new Point(19, 202);
            lbl_reponer.Name = "lbl_reponer";
            lbl_reponer.Size = new Size(202, 20);
            lbl_reponer.TabIndex = 8;
            lbl_reponer.Text = "Ingrese cantidad a reponer y ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 227);
            label1.Name = "label1";
            label1.Size = new Size(231, 20);
            label1.TabIndex = 9;
            label1.Text = "seleccione un producto de la lista";
            // 
            // numeric_stock
            // 
            numeric_stock.Location = new Point(38, 286);
            numeric_stock.Name = "numeric_stock";
            numeric_stock.Size = new Size(150, 27);
            numeric_stock.TabIndex = 10;
            // 
            // StockProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 563);
            Controls.Add(numeric_stock);
            Controls.Add(label1);
            Controls.Add(lbl_reponer);
            Controls.Add(dataGridView1);
            Controls.Add(btn_verDatos);
            Name = "StockProducto";
            Text = "StockProducto";
            Load += StockProducto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_stock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_verDatos;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewButtonColumn Reponer;
        private Label lbl_reponer;
        private Label label1;
        private NumericUpDown numeric_stock;
    }
}