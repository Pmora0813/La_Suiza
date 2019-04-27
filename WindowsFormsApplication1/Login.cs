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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }



        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //this.txtUsuario.Text = "Coffee";
            this.txtContraseña.Text = "Soft";
            if (this.txtUsuario.Text.Equals(""))
            {
                MessageBox.Show(null, "Datos incorectos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.txtContraseña.Text.Equals(""))
            {
                MessageBox.Show(null, "Datos incorectos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.txtUsuario.Text.Equals("Coffee") && this.txtContraseña.Text.Equals("Soft"))
            {
                Menu m = new Menu();
                m.Show();
                this.Hide();
            }
            else
            {

                if (this.txtUsuario.Text.Equals("Coffee1") && this.txtContraseña.Text.Equals("Soft"))
                {
                    MenuEmpleado m = new MenuEmpleado();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Datos incorectos.", "Coffe-Soft", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Increse el Usuario y Contraseña correspondientes para ingresar al sistema.", "Infomacion");
        }
    }
}
