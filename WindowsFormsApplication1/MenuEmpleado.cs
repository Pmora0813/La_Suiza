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
    public partial class MenuEmpleado : Form
    {
        public MenuEmpleado()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void btnbbCalientes_Click(object sender, EventArgs e)
        {
            frmbebidasCalientes ofrm = new frmbebidasCalientes();
            ofrm.Show();
            this.Hide();
        }

        private void btnbbFrias_Click(object sender, EventArgs e)
        {
            frmBebidasFrias ofrm = new frmBebidasFrias();
            ofrm.Show();
            this.Hide();
        }

        private void btnLicores_Click(object sender, EventArgs e)
        {
            frmLicores ofrm = new frmLicores();
            ofrm.Show();
            this.Hide();
        }

        private void btnReposteria_Click(object sender, EventArgs e)
        {
            frmReposteria ofrm = new frmReposteria();
            ofrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVenta ofrm = new frmVenta();
            ofrm.Show();
            this.Hide();
        }
    }
}
