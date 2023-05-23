namespace TiendaVirtualDeIndumentaria
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            lbl_conectado = new Label();
            txb_contraseña = new TextBox();
            txb_usuario = new TextBox();
            label1 = new Label();
            lbl_usuario = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(338, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            button1.Location = new Point(365, 384);
            button1.Name = "button1";
            button1.Size = new Size(103, 38);
            button1.TabIndex = 15;
            button1.Text = "Registrarse";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbl_conectado
            // 
            lbl_conectado.AutoSize = true;
            lbl_conectado.BackColor = Color.Transparent;
            lbl_conectado.FlatStyle = FlatStyle.Flat;
            lbl_conectado.ForeColor = Color.SpringGreen;
            lbl_conectado.Location = new Point(687, 393);
            lbl_conectado.Name = "lbl_conectado";
            lbl_conectado.Size = new Size(0, 20);
            lbl_conectado.TabIndex = 14;
            // 
            // txb_contraseña
            // 
            txb_contraseña.Location = new Point(310, 340);
            txb_contraseña.Name = "txb_contraseña";
            txb_contraseña.Size = new Size(207, 27);
            txb_contraseña.TabIndex = 12;
            txb_contraseña.UseSystemPasswordChar = true;
            // 
            // txb_usuario
            // 
            txb_usuario.Location = new Point(310, 249);
            txb_usuario.Name = "txb_usuario";
            txb_usuario.Size = new Size(207, 27);
            txb_usuario.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(360, 302);
            label1.Name = "label1";
            label1.Size = new Size(108, 26);
            label1.TabIndex = 10;
            label1.Text = "Contraseña";
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.BackColor = Color.Transparent;
            lbl_usuario.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usuario.ForeColor = Color.WhiteSmoke;
            lbl_usuario.Location = new Point(369, 211);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(79, 26);
            lbl_usuario.TabIndex = 9;
            lbl_usuario.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Sitka Subheading", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(246, 165);
            label2.Name = "label2";
            label2.Size = new Size(334, 26);
            label2.TabIndex = 17;
            label2.Text = "BIENVENIDO!! Cree una nueva cuenta";
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(lbl_conectado);
            Controls.Add(txb_contraseña);
            Controls.Add(txb_usuario);
            Controls.Add(label1);
            Controls.Add(lbl_usuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Registro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label lbl_conectado;
        private TextBox txb_contraseña;
        private TextBox txb_usuario;
        private Label label1;
        private Label lbl_usuario;
        private Label label2;
    }
}