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
    public partial class frmMantenimientoBebidasFrias : Form
    {
        public frmMantenimientoBebidasFrias()
        {
            InitializeComponent();
        }

        private void btbSalir_Click(object sender, EventArgs e)
        {
            Menu ofrm = new Menu();
            ofrm.Show();
            this.Hide();
        }

        private void frmMantenimientoBebidasFrias_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'coffee_SoftDataSet1.BBFrias' Puede moverla o quitarla según sea necesario.
            this.bBFriasTableAdapter.Fill(this.coffee_SoftDataSet1.BBFrias);

        }
    }
}
