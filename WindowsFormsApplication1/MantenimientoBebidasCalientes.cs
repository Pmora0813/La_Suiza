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
    public partial class MantenimientoBebidasCalientes : Form
    {
        public MantenimientoBebidasCalientes()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Menu ofrm = new Menu();
            ofrm.Show();
            this.Hide();

        }

        private void MantenimientoBebidasCalientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'coffee_SoftDataSet4.BBCalientes' Puede moverla o quitarla según sea necesario.
            this.bBCalientesTableAdapter.Fill(this.coffee_SoftDataSet4.BBCalientes);

        }
    }
}
