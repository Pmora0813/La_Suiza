namespace WindowsFormsApplication1
{
    partial class frmAdministrarProveedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministrarProveedores));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btbSalir = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.coffee_SoftDataSet7 = new WindowsFormsApplication1.coffee_SoftDataSet7();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proveedorTableAdapter = new WindowsFormsApplication1.coffee_SoftDataSet7TableAdapters.ProveedorTableAdapter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.coffee_SoftDataSet8 = new WindowsFormsApplication1.coffee_SoftDataSet8();
            this.licoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.licoresTableAdapter = new WindowsFormsApplication1.coffee_SoftDataSet8TableAdapters.LicoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_SoftDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_SoftDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.licoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(468, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 135);
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(18, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 25);
            this.label4.TabIndex = 63;
            this.label4.Text = "Solicitud de Pedidos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 263);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 158);
            this.textBox1.TabIndex = 62;
            // 
            // btbSalir
            // 
            this.btbSalir.BackColor = System.Drawing.Color.Chocolate;
            this.btbSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbSalir.Location = new System.Drawing.Point(477, 373);
            this.btbSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btbSalir.Name = "btbSalir";
            this.btbSalir.Size = new System.Drawing.Size(120, 43);
            this.btbSalir.TabIndex = 61;
            this.btbSalir.Text = "Salir";
            this.btbSalir.UseVisualStyleBackColor = false;
            this.btbSalir.Click += new System.EventHandler(this.btbSalir_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.Chocolate;
            this.btnDesactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.Location = new System.Drawing.Point(477, 318);
            this.btnDesactivar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(117, 45);
            this.btnDesactivar.TabIndex = 60;
            this.btnDesactivar.Text = "Enviar Pedido";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Chocolate;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(477, 263);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(117, 45);
            this.btnActualizar.TabIndex = 59;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Chocolate;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgregar.Location = new System.Drawing.Point(477, 59);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 45);
            this.btnAgregar.TabIndex = 58;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // lista
            // 
            this.lista.DataSource = this.proveedorBindingSource;
            this.lista.DisplayMember = "nombre";
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 19;
            this.lista.Location = new System.Drawing.Point(23, 59);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(175, 137);
            this.lista.TabIndex = 57;
            this.lista.ValueMember = "nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Proveedor";
            // 
            // coffee_SoftDataSet7
            // 
            this.coffee_SoftDataSet7.DataSetName = "coffee_SoftDataSet7";
            this.coffee_SoftDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataMember = "Proveedor";
            this.proveedorBindingSource.DataSource = this.coffee_SoftDataSet7;
            // 
            // proveedorTableAdapter
            // 
            this.proveedorTableAdapter.ClearBeforeFill = true;
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.licoresBindingSource;
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(239, 59);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 137);
            this.listBox1.TabIndex = 66;
            this.listBox1.ValueMember = "nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(234, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "Productos";
            // 
            // coffee_SoftDataSet8
            // 
            this.coffee_SoftDataSet8.DataSetName = "coffee_SoftDataSet8";
            this.coffee_SoftDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // licoresBindingSource
            // 
            this.licoresBindingSource.DataMember = "Licores";
            this.licoresBindingSource.DataSource = this.coffee_SoftDataSet8;
            // 
            // licoresTableAdapter
            // 
            this.licoresTableAdapter.ClearBeforeFill = true;
            // 
            // frmAdministrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 434);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btbSalir);
            this.Controls.Add(this.btnDesactivar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Museo Sans For Dell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdministrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrar Proveedores";
            this.Load += new System.EventHandler(this.frmAdministrarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_SoftDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffee_SoftDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.licoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btbSalir;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Label label2;
        private coffee_SoftDataSet7 coffee_SoftDataSet7;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private coffee_SoftDataSet7TableAdapters.ProveedorTableAdapter proveedorTableAdapter;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private coffee_SoftDataSet8 coffee_SoftDataSet8;
        private System.Windows.Forms.BindingSource licoresBindingSource;
        private coffee_SoftDataSet8TableAdapters.LicoresTableAdapter licoresTableAdapter;
    }
}