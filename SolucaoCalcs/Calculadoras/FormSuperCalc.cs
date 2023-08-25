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
        string vOperacao;
        double vNumant;
        bool vLimpar = false;
        double vNumdps;

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void f_Numero(object sender, EventArgs e)
        {
            if (lblPrincipal.Text == "0")
            {
                lblPrincipal.Text = "";
            }
            lblPrincipal.Text += (sender as Button).Text;
        }
        private void operacao(object sender, EventArgs e)
        {
            vOperacao = ((Button)sender).Text;
            vNumant = double.Parse(lblPrincipal.Text);
            vLimpar = true;
            limpar();
        }
        private void btnLimpar(object sender, EventArgs e)
        {
            vNumdps=0;
            vNumant = 0;
            vLimpar=true;
            limpar(); 
        }
        private void btnIgual(object sender, EventArgs e)
        {
            vNumdps = double.Parse(lblPrincipal.Text);
            switch (vOperacao)
            {
                case "+":
                    {
                        lblPrincipal.Text = (vNumant + vNumdps).ToString();
                        break;
                    }
                    case "-":
                    {
                        lblPrincipal.Text=(vNumant - vNumdps).ToString();
                        break;
                    }
                    case "*":
                    {
                        lblPrincipal.Text=(vNumant * vNumdps).ToString();
                        break;
                    }
                case "/":
                    {
                        lblPrincipal.Text=(vNumant / vNumdps).ToString();
                        break;
                    }
            }

        }
        public void limpar()
        {
            if (vLimpar = true)
            {
                lblPrincipal.Text = "";
            }
        }

        private void FormSuperCalc_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
