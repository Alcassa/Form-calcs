namespace SolucaoCalcs.Classe
{
    partial class FormOrienta
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.cmbFunc = new System.Windows.Forms.ComboBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(61, 32);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(100, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(336, 33);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(100, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // cmbFunc
            // 
            this.cmbFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunc.FormattingEnabled = true;
            this.cmbFunc.Items.AddRange(new object[] {
            "Somar",
            "Subtrair",
            "Dividir1",
            "Multiplicar",
            "Compara",
            "ImparPar",
            "Potenciação"});
            this.cmbFunc.Location = new System.Drawing.Point(188, 32);
            this.cmbFunc.Name = "cmbFunc";
            this.cmbFunc.Size = new System.Drawing.Size(121, 21);
            this.cmbFunc.TabIndex = 2;
            this.cmbFunc.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(502, 36);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "=";
            // 
            // FormOrienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.cmbFunc);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "FormOrienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrienta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.ComboBox cmbFunc;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
    }
}