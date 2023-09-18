namespace SolucaoCalcs.MenuPrincipal
{
    partial class FormMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraEscolhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraMCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechar2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripCalculadora
            // 
            this.menuStripCalculadora.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem,
            this.calculadoraEscolhaToolStripMenuItem,
            this.calculadoraMCToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fechar2ToolStripMenuItem});
            this.menuStripCalculadora.Name = "menuStripCalculadora";
            this.menuStripCalculadora.Size = new System.Drawing.Size(50, 20);
            this.menuStripCalculadora.Text = "Menu";
            this.menuStripCalculadora.Click += new System.EventHandler(this.menuStripCalculadora_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.fecharToolStripMenuItem.Text = "Calculadora";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // calculadoraEscolhaToolStripMenuItem
            // 
            this.calculadoraEscolhaToolStripMenuItem.Name = "calculadoraEscolhaToolStripMenuItem";
            this.calculadoraEscolhaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.calculadoraEscolhaToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.calculadoraEscolhaToolStripMenuItem.Text = "Calculadora Escolha";
            this.calculadoraEscolhaToolStripMenuItem.Click += new System.EventHandler(this.calculadoraEscolhaToolStripMenuItem_Click);
            // 
            // calculadoraMCToolStripMenuItem
            // 
            this.calculadoraMCToolStripMenuItem.Name = "calculadoraMCToolStripMenuItem";
            this.calculadoraMCToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.calculadoraMCToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.calculadoraMCToolStripMenuItem.Text = "Calculadora MC";
            this.calculadoraMCToolStripMenuItem.Click += new System.EventHandler(this.calculadoraMCToolStripMenuItem_Click);
            // 
            // fechar2ToolStripMenuItem
            // 
            this.fechar2ToolStripMenuItem.Name = "fechar2ToolStripMenuItem";
            this.fechar2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.fechar2ToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.fechar2ToolStripMenuItem.Text = "Fechar";
            this.fechar2ToolStripMenuItem.Click += new System.EventHandler(this.fechar2ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStripCalculadora});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(572, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.toolStripMenuItem1.Text = "Orientada";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuItem1_Click);
            // 
            // FormMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 304);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMDI";
            this.Text = "FormMDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuStripCalculadora;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraEscolhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechar2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraMCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}