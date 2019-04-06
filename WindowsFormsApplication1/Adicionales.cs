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
    public partial class Adicional_Lattes : Form
    {
        public Adicional_Lattes()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adicional_Lattes ad = new Adicional_Lattes();

            ad.Close();
        }
    }
}
