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
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    Adicional_Lattes ad = new Adicional_Lattes();

        //    ad.Show();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
            
        //}

        private void groupBox11_Enter(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Adicional_Lattes ofrm = new Adicional_Lattes();
            ofrm.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEmpleado ofrm = new MenuEmpleado();
            ofrm.Show();
            this.Hide();
        }
    }
}
