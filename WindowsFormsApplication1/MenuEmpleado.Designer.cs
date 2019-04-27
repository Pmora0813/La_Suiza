namespace WindowsFormsApplication1
{
    partial class MenuEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuEmpleado));
            this.btnbbCalientes = new System.Windows.Forms.Button();
            this.btnbbFrias = new System.Windows.Forms.Button();
            this.btnLicores = new System.Windows.Forms.Button();
            this.btnReposteria = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbbCalientes
            // 
            this.btnbbCalientes.BackColor = System.Drawing.Color.Chocolate;
            this.btnbbCalientes.Location = new System.Drawing.Point(12, 30);
            this.btnbbCalientes.Name = "btnbbCalientes";
            this.btnbbCalientes.Size = new System.Drawing.Size(175, 108);
            this.btnbbCalientes.TabIndex = 0;
            this.btnbbCalientes.Text = "Bebidas Calientes";
            this.btnbbCalientes.UseVisualStyleBackColor = false;
            this.btnbbCalientes.Click += new System.EventHandler(this.btnbbCalientes_Click);
            // 
            // btnbbFrias
            // 
            this.btnbbFrias.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnbbFrias.BackColor = System.Drawing.Color.Chocolate;
            this.btnbbFrias.Location = new System.Drawing.Point(205, 30);
            this.btnbbFrias.Name = "btnbbFrias";
            this.btnbbFrias.Size = new System.Drawing.Size(175, 108);
            this.btnbbFrias.TabIndex = 1;
            this.btnbbFrias.Text = "Bebidas Frias";
            this.btnbbFrias.UseVisualStyleBackColor = false;
            this.btnbbFrias.Click += new System.EventHandler(this.btnbbFrias_Click);
            // 
            // btnLicores
            // 
            this.btnLicores.BackColor = System.Drawing.Color.Chocolate;
            this.btnLicores.Location = new System.Drawing.Point(12, 166);
            this.btnLicores.Name = "btnLicores";
            this.btnLicores.Size = new System.Drawing.Size(175, 108);
            this.btnLicores.TabIndex = 2;
            this.btnLicores.Text = "Licores";
            this.btnLicores.UseVisualStyleBackColor = false;
            this.btnLicores.Click += new System.EventHandler(this.btnLicores_Click);
            // 
            // btnReposteria
            // 
            this.btnReposteria.BackColor = System.Drawing.Color.Chocolate;
            this.btnReposteria.Location = new System.Drawing.Point(205, 166);
            this.btnReposteria.Name = "btnReposteria";
            this.btnReposteria.Size = new System.Drawing.Size(175, 108);
            this.btnReposteria.TabIndex = 3;
            this.btnReposteria.Text = "Reposteria";
            this.btnReposteria.UseVisualStyleBackColor = false;
            this.btnReposteria.Click += new System.EventHandler(this.btnReposteria_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(386, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 327);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Chocolate;
            this.btnRegresar.Location = new System.Drawing.Point(552, 334);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(174, 49);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.Location = new System.Drawing.Point(12, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(368, 93);
            this.button1.TabIndex = 6;
            this.button1.Text = "Facturar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MenuEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReposteria);
            this.Controls.Add(this.btnLicores);
            this.Controls.Add(this.btnbbFrias);
            this.Controls.Add(this.btnbbCalientes);
            this.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbbCalientes;
        private System.Windows.Forms.Button btnbbFrias;
        private System.Windows.Forms.Button btnLicores;
        private System.Windows.Forms.Button btnReposteria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button button1;
    }
}