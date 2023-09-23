namespace SolucaoCalcs.Calculadoras
{
    partial class FormCalculadora
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lblSinal = new System.Windows.Forms.Label();
            this.radMultiplicar = new System.Windows.Forms.RadioButton();
            this.radDividir = new System.Windows.Forms.RadioButton();
            this.radSubtrair = new System.Windows.Forms.RadioButton();
            this.radSomar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnFechar);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtResult);
            this.groupBox1.Controls.Add(this.txtN2);
            this.groupBox1.Controls.Add(this.txtN1);
            this.groupBox1.Controls.Add(this.lblSinal);
            this.groupBox1.Controls.Add(this.radMultiplicar);
            this.groupBox1.Controls.Add(this.radDividir);
            this.groupBox1.Controls.Add(this.radSubtrair);
            this.groupBox1.Controls.Add(this.radSomar);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 432);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(363, 243);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 32);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(457, 243);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(88, 32);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(269, 243);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(88, 32);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "=";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(573, 35);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(409, 35);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 20);
            this.txtN2.TabIndex = 6;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(196, 35);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 20);
            this.txtN1.TabIndex = 5;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(344, 43);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(13, 13);
            this.lblSinal.TabIndex = 4;
            this.lblSinal.Text = "?";
            // 
            // radMultiplicar
            // 
            this.radMultiplicar.AutoSize = true;
            this.radMultiplicar.Location = new System.Drawing.Point(7, 89);
            this.radMultiplicar.Name = "radMultiplicar";
            this.radMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.radMultiplicar.TabIndex = 3;
            this.radMultiplicar.TabStop = true;
            this.radMultiplicar.Text = "Multiplicar";
            this.radMultiplicar.UseVisualStyleBackColor = true;
            // 
            // radDividir
            // 
            this.radDividir.AutoSize = true;
            this.radDividir.Location = new System.Drawing.Point(7, 66);
            this.radDividir.Name = "radDividir";
            this.radDividir.Size = new System.Drawing.Size(54, 17);
            this.radDividir.TabIndex = 2;
            this.radDividir.TabStop = true;
            this.radDividir.Text = "Dividir";
            this.radDividir.UseVisualStyleBackColor = true;
            // 
            // radSubtrair
            // 
            this.radSubtrair.AutoSize = true;
            this.radSubtrair.Location = new System.Drawing.Point(7, 43);
            this.radSubtrair.Name = "radSubtrair";
            this.radSubtrair.Size = new System.Drawing.Size(61, 17);
            this.radSubtrair.TabIndex = 1;
            this.radSubtrair.TabStop = true;
            this.radSubtrair.Text = "Subtrair";
            this.radSubtrair.UseVisualStyleBackColor = true;
            // 
            // radSomar
            // 
            this.radSomar.AutoSize = true;
            this.radSomar.Location = new System.Drawing.Point(7, 20);
            this.radSomar.Name = "radSomar";
            this.radSomar.Size = new System.Drawing.Size(55, 17);
            this.radSomar.TabIndex = 0;
            this.radSomar.TabStop = true;
            this.radSomar.Text = "Somar";
            this.radSomar.UseVisualStyleBackColor = true;
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCalculadora";
            this.Text = "FormCalculadora";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSomar;
        private System.Windows.Forms.RadioButton radMultiplicar;
        private System.Windows.Forms.RadioButton radDividir;
        private System.Windows.Forms.RadioButton radSubtrair;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnLimpar;
    }
}