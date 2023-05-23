namespace TiendaVirtualDeIndumentaria
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_usuario = new Label();
            label1 = new Label();
            txb_usuario = new TextBox();
            txb_contraseña = new TextBox();
            btn_ingresar = new Button();
            lbl_conectado = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label_error = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Transparent;
            lbl_usuario.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuario.ForeColor = SystemColors.ButtonFace;
            lbl_usuario.Location = new Point(475, 227);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(79, 26);
            lbl_usuario.TabIndex = 0;
            lbl_usuario.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(466, 318);
            label1.Name = "label1";
            label1.Size = new Size(108, 26);
            label1.TabIndex = 1;
            label1.Text = "Contraseña";
            // 
            // txb_usuario
            // 
            txb_usuario.Location = new Point(416, 265);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(207, 27);
            txb_usuario.TabIndex = 2;
            // 
            // txb_contraseña
            // 
            txb_contraseña.Location = new Point(416, 356);
            txb_contraseña.Name = "txb_contraseña";
            txb_contraseña.Size = new Size(207, 27);
            txb_contraseña.TabIndex = 3;
            txb_contraseña.UseSystemPasswordChar = true;
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
            btn_ingresar.Location = new Point(416, 410);
            btn_ingresar.Name = "btn_ingresar";
            btn_ingresar.Size = new Size(103, 38);
            btn_ingresar.TabIndex = 5;
            btn_ingresar.Text = "Ingresar";
            btn_ingresar.UseVisualStyleBackColor = false;
            btn_ingresar.Click += btn_ingresar_Click;
            // 
            // lbl_conectado
            // 
            lbl_conectado.AutoSize = true;
            lbl_conectado.BackColor = Color.Transparent;
            lbl_conectado.FlatStyle = FlatStyle.Flat;
            lbl_conectado.ForeColor = Color.SpringGreen;
            lbl_conectado.Location = new Point(793, 424);
            lbl_conectado.Name = "lbl_conectado";
            lbl_conectado.Size = new Size(0, 20);
            lbl_conectado.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.System;
            button1.Font = new Font("Microsoft JhengHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(520, 410);
            button1.Name = "button1";
            button1.Size = new Size(103, 38);
            button1.TabIndex = 7;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(444, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label_error
            // 
            label_error.AutoSize = true;
            label_error.BackColor = Color.Transparent;
            label_error.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label_error.ForeColor = Color.RosyBrown;
            label_error.Location = new Point(377, 455);
            label_error.Name = "label_error";
            label_error.Size = new Size(0, 26);
            label_error.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(975, 506);
            Controls.Add(label_error);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lbl_conectado);
            Controls.Add(btn_ingresar);
            Controls.Add(txb_contraseña);
            Controls.Add(txb_usuario);
            Controls.Add(label1);
            Controls.Add(lbl_usuario);
            DoubleBuffered = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesion";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_usuario;
        private Label label1;
        private TextBox txb_usuario;
        private TextBox txb_contraseña;
        private Button btn_ingresar;
        private Label lbl_conectado;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label_error;
    }
}