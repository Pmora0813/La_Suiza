using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMantEmpleados : Form
    {
        public int num { get; set; }
        public frmMantEmpleados()
        {
            InitializeComponent();
           
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMantEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'coffee_SoftDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.coffee_SoftDataSet.Empleado);

        }

        private void btbSalir_Click(object sender, EventArgs e)
        {
            Menu ofrm = new Menu();
            ofrm.Show();
            this.Hide();
        }
    }
}
