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
            frmVenta f = new frmVenta();
            f.Show();
        }

        private void cafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCafe c = new MantenimientoCafe();
            c.Show();
        }

        private void licorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManteniminetoLicor l = new ManteniminetoLicor();
            l.Show();
        }

        private void reposteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoReposteria r = new MantenimientoReposteria();
            r.Show();
        }

        private void programaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
