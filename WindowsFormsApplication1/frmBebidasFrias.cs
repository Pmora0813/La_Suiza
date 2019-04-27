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
    public partial class frmBebidasFrias : Form
    {
        public frmBebidasFrias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuEmpleado ofrm = new MenuEmpleado();
            ofrm.Show();
            this.Hide();
        }
    }
}
