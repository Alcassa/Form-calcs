namespace SolucaoCalcs
{
    partial class Form1
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
            this.lblSinal = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnImparPars = new System.Windows.Forms.Button();
            this.bntDividir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.Location = new System.Drawing.Point(621, 146);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(13, 13);
            this.lblSinal.TabIndex = 0;
            this.lblSinal.Text = "?";
            this.lblSinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumber1
            // 
            this.txtNumber1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNumber1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumber1.Location = new System.Drawing.Point(584, 77);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(100, 20);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumber2
            // 
            this.txtNumber2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumber2.Location = new System.Drawing.Point(584, 213);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(100, 20);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(621, 261);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSomar.Location = new System.Drawing.Point(161, 515);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(87, 31);
            this.btnSomar.TabIndex = 4;
            this.btnSomar.Text = "&Somar";
            this.btnSomar.UseVisualStyleBackColor = false;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnMultiplicar.Location = new System.Drawing.Point(347, 515);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(87, 31);
            this.btnMultiplicar.TabIndex = 5;
            this.btnMultiplicar.Text = "&Multiplicar";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.btnMultiplicar_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSubtrair.Location = new System.Drawing.Point(254, 515);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(87, 31);
            this.btnSubtrair.TabIndex = 6;
            this.btnSubtrair.Text = "Su&btrair";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnCompara
            // 
            this.btnCompara.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCompara.Location = new System.Drawing.Point(347, 438);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(87, 31);
            this.btnCompara.TabIndex = 7;
            this.btnCompara.Text = "&Comparar";
            this.btnCompara.UseVisualStyleBackColor = false;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btnImparPars
            // 
            this.btnImparPars.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnImparPars.Location = new System.Drawing.Point(254, 438);
            this.btnImparPars.Name = "btnImparPars";
            this.btnImparPars.Size = new System.Drawing.Size(87, 31);
            this.btnImparPars.TabIndex = 8;
            this.btnImparPars.Text = "&Impar/Par";
            this.btnImparPars.UseVisualStyleBackColor = false;
            this.btnImparPars.Click += new System.EventHandler(this.btnImparPars_Click);
            // 
            // bntDividir
            // 
            this.bntDividir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntDividir.Location = new System.Drawing.Point(161, 438);
            this.bntDividir.Name = "bntDividir";
            this.bntDividir.Size = new System.Drawing.Size(87, 31);
            this.bntDividir.TabIndex = 9;
            this.bntDividir.Text = "&Dividir";
            this.bntDividir.UseVisualStyleBackColor = false;
            this.bntDividir.Click += new System.EventHandler(this.bntDividir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpar.Location = new System.Drawing.Point(597, 515);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(87, 31);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFechar.Location = new System.Drawing.Point(1015, 515);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(87, 31);
            this.btnFechar.TabIndex = 11;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1297, 599);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.bntDividir);
            this.Controls.Add(this.btnImparPars);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.lblSinal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnImparPars;
        private System.Windows.Forms.Button bntDividir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFechar;
    }
}

