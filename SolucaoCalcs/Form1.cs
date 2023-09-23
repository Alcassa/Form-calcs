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

namespace SolucaoCalcs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                lblSinal.Text = "+";
                a = double.Parse(txtNumber1.Text);
                b = double.Parse(txtNumber2.Text);
                lblResultado.Text = (a + b).ToString("F2", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                lblResultado.Text = "Não foi posivel realizar a operação";
            }
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                lblSinal.Text = "-";
                a = double.Parse(txtNumber1.Text);
                b = double.Parse(txtNumber2.Text);
                lblResultado.Text = (a - b).ToString("F2", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                lblResultado.Text = "Não foi posivel realizar a operação";
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                lblSinal.Text = "X";
                a = double.Parse(txtNumber1.Text);
                b = double.Parse(txtNumber2.Text);
                if (a == 0 || b == 0)
                {
                    lblResultado.Text = "O Resultado é zero";
                }
                else
                    lblResultado.Text = (a * b).ToString("F2", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                lblResultado.Text = "Não foi posivel realizar a operação";
            }
        }

        private void bntDividir_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                lblSinal.Text = "/";
                a = double.Parse(txtNumber1.Text);
                b = double.Parse(txtNumber2.Text);
                if (a == 0 || b == 0)
                {
                    lblResultado.Text = "Não é possivel dividir por zero";
                }
                else
                    lblResultado.Text = (a / b).ToString("F2", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                lblResultado.Text = "Não foi possivel realizar a operação";
            }
        }
        private void btnImparPars_Click(object sender, EventArgs e)
        {
            double a, b, r;
            try
            {
                lblSinal.Text = "+";
                a = Convert.ToDouble(txtNumber1.Text);
                b = Convert.ToDouble(txtNumber2.Text);
                r = a + b;
                for (int i = 0; i < r; i++)
                {
                    double imparPar = r % 2;
                    if (imparPar == 0)
                    {
                        lblResultado.Text = "O número é par";
                    }
                    else
                    {
                        lblResultado.Text = "O número é impar";
                    }
                }

            }
            catch (Exception) { }
        }
        private void btnCompara_Click(object sender, EventArgs e)
        {
            double a, b;
            try
            {
                a = Convert.ToDouble(txtNumber1.Text);
                b = Convert.ToDouble(txtNumber2.Text);
                if (a > b)
                {
                    lblSinal.Text = " > ";
                    lblResultado.Text = "O primeiro número é maior";
                }
                else if (a < b)
                {
                    lblSinal.Text = " < ";
                    lblResultado.Text = "O segundo número é maior";
                }
                else
                {
                    lblSinal.Text = "=";
                    lblResultado.Text = "'Os números são iguais";
                }
            }
            catch (Exception)
            {

            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            lblResultado.Text = "?";
            
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
