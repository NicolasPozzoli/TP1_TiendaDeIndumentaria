namespace TiendaVirtualDeIndumentaria
{
    partial class AgregarProducto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarProducto));
            label_error = new Label();
            btn_ingresar = new Button();
            label1 = new Label();
            lbl_nombreProducto = new Label();
            txb_nombreProducto = new TextBox();
            lbl_precio = new Label();
            label3 = new Label();
            bindingSource1 = new BindingSource(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            comboBox_tipo = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.BackColor = Color.Transparent;
            label_error.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_error.ForeColor = Color.RosyBrown;
            label_error.Location = new Point(265, 399);
            label_error.Name = "label_error";
            label_error.Size = new Size(0, 26);
            label_error.TabIndex = 17;
            // 
            // btn_ingresar
            // 
            btn_ingresar.BackColor = Color.Transparent;
            btn_ingresar.BackgroundImageLayout = ImageLayout.None;
            btn_ingresar.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            btn_ingresar.FlatAppearance.BorderSize = 0;
            btn_ingresar.FlatStyle = FlatStyle.System;
            btn_ingresar.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_ingresar.ForeColor = SystemColors.ControlText;
            btn_ingresar.Image = (Image)resources.GetObject("btn_ingresar.Image");
            btn_ingresar.Location = new Point(372, 399);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(103, 38);
            btn_ingresar.TabIndex = 14;
            btn_ingresar.Text = "Crear";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(395, 304);
            label1.Name = "label1";
            label1.Size = new Size(50, 26);
            label1.TabIndex = 11;
            label1.Text = "Tipo";
            label1.Click += label1_Click;
            // 
            // lbl_nombreProducto
            // 
            lbl_nombreProducto.AutoSize = true;
            lbl_nombreProducto.BackColor = Color.Transparent;
            lbl_nombreProducto.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nombreProducto.ForeColor = SystemColors.ActiveCaptionText;
            lbl_nombreProducto.Location = new Point(395, 211);
            lbl_nombreProducto.Name = "lbl_nombreProducto";
            lbl_nombreProducto.Size = new Size(57, 26);
            lbl_nombreProducto.TabIndex = 10;
            lbl_nombreProducto.Text = "Stock";
            lbl_nombreProducto.Click += lbl_usuario_Click;
            // 
            // txb_nombreProducto
            // 
            txb_nombreProducto.Location = new Point(316, 75);
            txb_nombreProducto.Name = "txb_nombreProducto";
            txb_nombreProducto.Size = new Size(207, 27);
            txb_nombreProducto.TabIndex = 20;
            // 
            // lbl_precio
            // 
            lbl_precio.AutoSize = true;
            lbl_precio.BackColor = Color.Transparent;
            lbl_precio.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_precio.ForeColor = SystemColors.ActiveCaptionText;
            lbl_precio.Location = new Point(395, 126);
            lbl_precio.Name = "lbl_precio";
            lbl_precio.Size = new Size(64, 26);
            lbl_precio.TabIndex = 19;
            lbl_precio.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(339, 32);
            label3.Name = "label3";
            label3.Size = new Size(184, 26);
            label3.TabIndex = 18;
            label3.Text = "Nombre de producto";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // comboBox_tipo
            // 
            comboBox_tipo.FormattingEnabled = true;
            comboBox_tipo.Items.AddRange(new object[] { "Buzo", "Pantalon", "Remera", "Ropa interior", "Accesorio" });
            comboBox_tipo.Location = new Point(316, 347);
            comboBox_tipo.Name = "comboBox_tipo";
            comboBox_tipo.Size = new Size(207, 28);
            comboBox_tipo.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(77, 76);
            label2.Name = "label2";
            label2.Size = new Size(154, 26);
            label2.TabIndex = 25;
            label2.Text = "Foto de producto";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(59, 131);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(188, 151);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(59, 304);
            button1.Name = "button1";
            button1.Size = new Size(188, 38);
            button1.TabIndex = 27;
            button1.Text = "Agregar imagen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(316, 171);
            numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(207, 27);
            numericUpDown1.TabIndex = 28;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(316, 255);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(207, 27);
            numericUpDown2.TabIndex = 29;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(comboBox_tipo);
            Controls.Add(txb_nombreProducto);
            Controls.Add(lbl_precio);
            Controls.Add(label3);
            Controls.Add(label_error);
            Controls.Add(btn_ingresar);
            Controls.Add(label1);
            Controls.Add(lbl_nombreProducto);
            Name = "AgregarProducto";
            Text = "AgregarProducto";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_error;
        private Button btn_ingresar;
        private Label label1;
        private Label lbl_nombreProducto;
        private TextBox txb_nombreProducto;
        private Label lbl_precio;
        private Label label3;
        private BindingSource bindingSource1;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox comboBox_tipo;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}