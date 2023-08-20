using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucaoCalcs.Calculadoras
{
    public partial class FormSuperCalc : Form
    {
        public FormSuperCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void f_Numero(object sender, EventArgs e)
        {
            lblPrincipal.Text=(sender as Button).Text;
        }
    }
}
