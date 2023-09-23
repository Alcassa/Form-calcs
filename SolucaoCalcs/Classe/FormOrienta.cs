using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SolucaoCalcs.Classe;

namespace SolucaoCalcs.Classe
{
    public partial class FormOrienta : Form
    {
        public FormOrienta()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            decimal a, b;
            if(txtNumero1.Text == null) { a = 0; }
            else
            {
                a=decimal.Parse(txtNumero1.Text);
            }
            a = decimal.Parse(txtNumero1.Text);
            if (txtNumero2.Text == "") { b = 0; }
            else
            {
                b = decimal.Parse(txtNumero2.Text);
            }
            txtNumero2.Enabled = true;
            switch (cmbFunc.Text)
            {

                case "Somar":
                    {
                        var calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        calc.Somar();
                        lblResultado.Text = calc.Resultado.ToString();
                        break;
                    }
                case "Subtrair":
                    {
                        var calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResultado.Text = calc.Subtrair();
                        break;
                    }
                case "Multiplicar":
                    {
                        var calc = new CalculadoraBasica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResultado.Text = calc.Multiplicar().ToString();
                        break;
                    }
                case "Dividir1":
                    {
                        CalculadoraBasica calc = new CalculadoraBasica();
                        lblResultado.Text = calc.Dividir(a, b);
                        break;
                    }
                case "ImparPar":
                    {
                        txtNumero2.Enabled = false;
                        var calc = new CalculadoraCientifica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResultado.Text = calc.Par_Impar();
                        break;
                    }
                case "Compara":
                    {
                        var calc = new CalculadoraCientifica();
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResultado.Text = calc.Comparar();
                        break;
                    }
                case "Potenciação":
                    {
                        var calc = new CalculadoraCientifica();
                        Convert.ToDouble(a);
                        Convert.ToDouble(b);
                        calc.Num1 = a;
                        calc.Num2 = b;
                        lblResultado.Text = Convert.ToString(calc.Potenciacao());
                        break;
                    }
                default:
                    break;
            }
        }

    }
}
