namespace TiendaVirtualDeIndumentaria
{
    partial class CarritoForm
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
            btnVaciarCarrito = new Button();
            button1 = new Button();
            listViewCarrito = new ListView();
            button2 = new Button();
            label_precio = new Label();
            SuspendLayout();
            // 
            // btnVaciarCarrito
            // 
            btnVaciarCarrito.Location = new Point(233, 515);
            btnVaciarCarrito.Name = "btnVaciarCarrito";
            btnVaciarCarrito.Size = new Size(164, 37);
            btnVaciarCarrito.TabIndex = 1;
            btnVaciarCarrito.Text = "Vaciar carrito";
            btnVaciarCarrito.UseVisualStyleBackColor = true;
            btnVaciarCarrito.Click += btnVaciarCarrito_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(441, 515);
            button1.Name = "button1";
            button1.Size = new Size(164, 37);
            button1.TabIndex = 3;
            button1.Text = "Eliminar producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listViewCarrito
            // 
            listViewCarrito.Location = new Point(210, 68);
            listViewCarrito.Name = "listViewCarrito";
            listViewCarrito.Size = new Size(625, 385);
            listViewCarrito.TabIndex = 4;
            listViewCarrito.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(643, 515);
            button2.Name = "button2";
            button2.Size = new Size(164, 37);
            button2.TabIndex = 5;
            button2.Text = "Confirmar compra";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label_precio
            // 
            label_precio.AutoSize = true;
            label_precio.Font = new Font("Yu Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label_precio.Location = new Point(411, 466);
            label_precio.Name = "label_precio";
            label_precio.Size = new Size(0, 22);
            label_precio.TabIndex = 6;
            // 
            // CarritoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 601);
            Controls.Add(label_precio);
            Controls.Add(button2);
            Controls.Add(listViewCarrito);
            Controls.Add(button1);
            Controls.Add(btnVaciarCarrito);
            Name = "CarritoForm";
            Text = "CarritoForm";
            Load += CarritoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVaciarCarrito;
        private Button button1;
        private ListView listViewCarrito;
        private Button button2;
        private Label label_precio;
    }
}