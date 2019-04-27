namespace WindowsFormsApplication1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnSalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInventarioInterno = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnBebidasFrias = new System.Windows.Forms.Button();
            this.btnReposteria = new System.Windows.Forms.Button();
            this.btnLicores = new System.Windows.Forms.Button();
            this.btnBebidasCalientes = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Chocolate;
            this.btnSalir.Location = new System.Drawing.Point(427, 426);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(125, 36);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(554, 422);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btnInventarioInterno);
            this.tabPage1.Controls.Add(this.btnProveedores);
            this.tabPage1.Controls.Add(this.btnEmpleados);
            this.tabPage1.Controls.Add(this.btnBebidasFrias);
            this.tabPage1.Controls.Add(this.btnReposteria);
            this.tabPage1.Controls.Add(this.btnLicores);
            this.tabPage1.Controls.Add(this.btnBebidasCalientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(546, 390);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimientos";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 114);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // btnInventarioInterno
            // 
            this.btnInventarioInterno.BackColor = System.Drawing.Color.Chocolate;
            this.btnInventarioInterno.Location = new System.Drawing.Point(171, 300);
            this.btnInventarioInterno.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventarioInterno.Name = "btnInventarioInterno";
            this.btnInventarioInterno.Size = new System.Drawing.Size(196, 51);
            this.btnInventarioInterno.TabIndex = 15;
            this.btnInventarioInterno.Text = "Inventario Interno";
            this.btnInventarioInterno.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.Chocolate;
            this.btnProveedores.Location = new System.Drawing.Point(296, 213);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(196, 51);
            this.btnProveedores.TabIndex = 14;
            this.btnProveedores.Text = "Provedores";
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.Chocolate;
            this.btnEmpleados.Location = new System.Drawing.Point(42, 213);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(196, 51);
            this.btnEmpleados.TabIndex = 13;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnBebidasFrias
            // 
            this.btnBebidasFrias.BackColor = System.Drawing.Color.Chocolate;
            this.btnBebidasFrias.Location = new System.Drawing.Point(296, 39);
            this.btnBebidasFrias.Margin = new System.Windows.Forms.Padding(4);
            this.btnBebidasFrias.Name = "btnBebidasFrias";
            this.btnBebidasFrias.Size = new System.Drawing.Size(196, 51);
            this.btnBebidasFrias.TabIndex = 12;
            this.btnBebidasFrias.Text = "Bebidas Frias";
            this.btnBebidasFrias.UseVisualStyleBackColor = false;
            this.btnBebidasFrias.Click += new System.EventHandler(this.btnBebidasFrias_Click);
            // 
            // btnReposteria
            // 
            this.btnReposteria.BackColor = System.Drawing.Color.Chocolate;
            this.btnReposteria.Location = new System.Drawing.Point(296, 120);
            this.btnReposteria.Margin = new System.Windows.Forms.Padding(4);
            this.btnReposteria.Name = "btnReposteria";
            this.btnReposteria.Size = new System.Drawing.Size(196, 51);
            this.btnReposteria.TabIndex = 11;
            this.btnReposteria.Text = "Resposteria";
            this.btnReposteria.UseVisualStyleBackColor = false;
            this.btnReposteria.Click += new System.EventHandler(this.btnReposteria_Click);
            // 
            // btnLicores
            // 
            this.btnLicores.BackColor = System.Drawing.Color.Chocolate;
            this.btnLicores.Location = new System.Drawing.Point(42, 120);
            this.btnLicores.Margin = new System.Windows.Forms.Padding(4);
            this.btnLicores.Name = "btnLicores";
            this.btnLicores.Size = new System.Drawing.Size(196, 51);
            this.btnLicores.TabIndex = 10;
            this.btnLicores.Text = "Licores";
            this.btnLicores.UseVisualStyleBackColor = false;
            this.btnLicores.Click += new System.EventHandler(this.btnLicores_Click);
            // 
            // btnBebidasCalientes
            // 
            this.btnBebidasCalientes.BackColor = System.Drawing.Color.Chocolate;
            this.btnBebidasCalientes.Location = new System.Drawing.Point(42, 39);
            this.btnBebidasCalientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnBebidasCalientes.Name = "btnBebidasCalientes";
            this.btnBebidasCalientes.Size = new System.Drawing.Size(196, 51);
            this.btnBebidasCalientes.TabIndex = 9;
            this.btnBebidasCalientes.Text = "Bebidas Calientes";
            this.btnBebidasCalientes.UseVisualStyleBackColor = false;
            this.btnBebidasCalientes.Click += new System.EventHandler(this.btnBebidasCalientes_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(546, 390);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reportes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 114);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Chocolate;
            this.button8.Location = new System.Drawing.Point(171, 298);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(196, 51);
            this.button8.TabIndex = 22;
            this.button8.Text = "Ventas-Gastos Resumido";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Chocolate;
            this.button9.Location = new System.Drawing.Point(296, 211);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(196, 51);
            this.button9.TabIndex = 21;
            this.button9.Text = "Pedidos de Provedores";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Chocolate;
            this.button10.Location = new System.Drawing.Point(42, 211);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(196, 51);
            this.button10.TabIndex = 20;
            this.button10.Text = "Ventas por Empleado";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Chocolate;
            this.button11.Location = new System.Drawing.Point(296, 37);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(196, 51);
            this.button11.TabIndex = 19;
            this.button11.Text = "Gastos";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Chocolate;
            this.button12.Location = new System.Drawing.Point(296, 118);
            this.button12.Margin = new System.Windows.Forms.Padding(4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(196, 51);
            this.button12.TabIndex = 18;
            this.button12.Text = "Facturas Cancelas";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Chocolate;
            this.button13.Location = new System.Drawing.Point(42, 118);
            this.button13.Margin = new System.Windows.Forms.Padding(4);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(196, 51);
            this.button13.TabIndex = 17;
            this.button13.Text = "Facturas Pendientes";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Chocolate;
            this.button14.Location = new System.Drawing.Point(42, 37);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(196, 51);
            this.button14.TabIndex = 16;
            this.button14.Text = "Ventas";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button16);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(546, 390);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Administracion del Sistema";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Chocolate;
            this.button15.Location = new System.Drawing.Point(173, 152);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(196, 51);
            this.button15.TabIndex = 20;
            this.button15.Text = "Inventario Interno";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Chocolate;
            this.button16.Location = new System.Drawing.Point(298, 65);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(196, 51);
            this.button16.TabIndex = 19;
            this.button16.Text = "Provedores";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Chocolate;
            this.button17.Location = new System.Drawing.Point(44, 65);
            this.button17.Margin = new System.Windows.Forms.Padding(4);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(196, 51);
            this.button17.TabIndex = 18;
            this.button17.Text = "Empleados";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.Location = new System.Drawing.Point(-30, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(196, 268);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(563, 470);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee-Soft";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnBebidasFrias;
        private System.Windows.Forms.Button btnReposteria;
        private System.Windows.Forms.Button btnLicores;
        private System.Windows.Forms.Button btnBebidasCalientes;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnInventarioInterno;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}