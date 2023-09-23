using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolucaoCalcs.MenuPrincipal;

namespace SolucaoCalcs.login
{
    public partial class FormLogin_ : Form
    {
        public FormLogin_()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text.Equals("Alcassa") && txtPassword.Text.Equals("123"))
                {
                    var menu = new FormMDI();
                    menu.Show();
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Ocorreu um erro");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPassword.Text = "";
        }
    }
}
