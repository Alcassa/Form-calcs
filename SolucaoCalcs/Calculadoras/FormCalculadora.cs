using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucaoCalcs.Calculadoras
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b;
                a = double.Parse(txtN1.Text);
                b = double.Parse(txtN2.Text);
                if (radSomar.Checked)
                {
                    lblSinal.Text = "+";
                    txtResult.Text = (a + b).ToString("F2", CultureInfo.InvariantCulture);
                }
                else if (radSubtrair.Checked)
                {
                    lblSinal.Text = "-";
                    txtResult.Text = (a - b).ToString("F2", CultureInfo.InvariantCulture);
                }
                else if (radMultiplicar.Checked)
                {
                    lblSinal.Text = "*";
                    txtResult.Text = (a * b).ToString("F2", CultureInfo.InvariantCulture);
                }
                else if (radDividir.Checked)
                {
                    lblSinal.Text = "/";
                    txtResult.Text = (a / b).ToString("F2", CultureInfo.InvariantCulture);
                }
            }
            catch (Exception)
            {
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
            lblSinal.Text = "";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            this.Text = "?";
        }
    }
}
