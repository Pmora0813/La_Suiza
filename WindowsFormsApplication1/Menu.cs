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
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta ofrm = new frmVenta();
            ofrm.Show();
            this.Hide();
        }

        private void cafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoBebidasCalientes ofrm = new MantenimientoBebidasCalientes();
            ofrm.Show();
            this.Hide();
        }

        private void licorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManteniminetoLicor ofrm = new ManteniminetoLicor();
            ofrm.Show();
            this.Hide();
        }

        private void reposteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoReposteria ofrm = new MantenimientoReposteria();
            ofrm.Show();
            this.Hide();
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Login ofrm = new Login();
            ofrm.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnBebidasCalientes_Click(object sender, EventArgs e)
        {
            MantenimientoBebidasCalientes ofrm = new MantenimientoBebidasCalientes();
            ofrm.Show();
            this.Hide();
        }

        private void btnBebidasFrias_Click(object sender, EventArgs e)
        {
            frmMantenimientoBebidasFrias ofrm = new frmMantenimientoBebidasFrias();
            ofrm.Show();
            this.Hide();
        }

        private void btnLicores_Click(object sender, EventArgs e)
        {
            ManteniminetoLicor ofrm = new ManteniminetoLicor();
            ofrm.Show();
            this.Hide();
        }

        private void btnReposteria_Click(object sender, EventArgs e)
        {
            MantenimientoReposteria ofrm = new MantenimientoReposteria();
            ofrm.Show();
            this.Hide();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmMantEmpleados ofrm = new frmMantEmpleados();
            ofrm.Show();
            this.Hide();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            frmProveedores ofrm = new frmProveedores();
            ofrm.Show();
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            frmAdministrarEmpleados ofrm = new frmAdministrarEmpleados();
            ofrm.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmAdministrarProveedores ofrm = new frmAdministrarProveedores();
            ofrm.Show();
            this.Hide();
        }
    }
}
