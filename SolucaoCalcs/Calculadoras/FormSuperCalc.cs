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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void f_Numero(object sender, EventArgs e)
        {
            string numero = ((Button)sender).ToString();
            if (vLimpar)
            {
                lblPrincipal.Text = "";
                vLimpar = false;
            }
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
            lblPrincipal.Focus();
        }

        private void btnIgual(object sender, EventArgs e)
        {
            double vNumdps = double.Parse(lblPrincipal.Text);
            switch (vOperacao)
            {
                case "+":
                    {
                        lblPrincipal.Text = (vNumant + vNumdps).ToString();
                        break;
                    }
                case "-":
                    {
                        lblPrincipal.Text = (vNumant - vNumdps).ToString();
                        break;
                    }
                case "*":
                    {
                        lblPrincipal.Text = (vNumant * vNumdps).ToString();
                        break;
                    }
                case "/":
                    {
                        lblPrincipal.Text = (vNumant / vNumdps).ToString();
                        break;
                    }
            }

        }


        private void FormSuperCalc_KeyDown(object sender, KeyEventArgs e)
        {
            Button but = new Button();
            if (e.Control == true) { }
            if (e.Alt == true) { }
            if (e.Shift == true) { }
            if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                but.Text = e.KeyCode.ToString().Substring(1, 1);
                f_Numero(but, e);
                return;
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {
                but.Text = " , ";
                f_Numero(but, e);
                return;

            }
            switch (e.KeyCode.ToString())
            {
                case "Oemplus":
                    {
                        but.Text = "+";
                        operacao(but, e);
                        return;
                    }
                case "Subtract":
                    {
                        but.Text = "-";
                        operacao(but, e);
                        return;
                    }
                case "Multiply":
                    {
                        but.Text = "*";
                        operacao(but, e);
                        return;
                    }
                case "'Divide":
                    {
                        but.Text = "/";
                        operacao(but, e);
                        return;
                    }
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnIgual(but, e);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
