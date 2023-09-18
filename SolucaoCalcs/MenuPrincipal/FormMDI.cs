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
using SolucaoCalcs;
using SolucaoCalcs.Calculadoras;

namespace SolucaoCalcs.MenuPrincipal
{
    public partial class FormMDI : Form
    {
        public FormMDI()
        {
            InitializeComponent();
        }

        private void menuStripCalculadora_Click(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }
        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 cacl = new Form1();
            cacl.MdiParent = this;
            cacl.Show();
        }

        private void fechar2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculadoraEscolhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCalculadora cacl=new FormCalculadora();
            cacl.MdiParent = this;
            cacl.Show();
        }

        private void calculadoraMCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSuperCalc calc=new FormSuperCalc();
            calc.MdiParent = this;
            calc.Show();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var calc = new FormOrienta();
            calc.MdiParent = this;
            calc.Show();

        }
    }
}
