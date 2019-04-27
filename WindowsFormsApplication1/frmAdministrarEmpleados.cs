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
    public partial class frmAdministrarEmpleados : Form
    {
        public frmAdministrarEmpleados()
        {
            InitializeComponent();
        }

        private void btbSalir_Click(object sender, EventArgs e)
        {
            Menu ofrm = new Menu();
            ofrm.Show();
            this.Hide();
        }

        private void frmAdministrarEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'coffee_SoftDataSet6.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.coffee_SoftDataSet6.Empleado);

        }
    }
}
