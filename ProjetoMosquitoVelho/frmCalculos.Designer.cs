
namespace ProjetoMosquitoVelho
{
    partial class frmCalculos
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
            this.txbN1 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txbN2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbN1
            // 
            this.txbN1.Location = new System.Drawing.Point(231, 129);
            this.txbN1.MaxLength = 10;
            this.txbN1.Name = "txbN1";
            this.txbN1.Size = new System.Drawing.Size(199, 20);
            this.txbN1.TabIndex = 0;
            this.txbN1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(479, 128);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(75, 23);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "somar";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(231, 108);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(49, 20);
            this.lblNum1.TabIndex = 2;
            this.lblNum1.Text = "num1";
            this.lblNum1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(479, 186);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(231, 163);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(49, 20);
            this.lblNum2.TabIndex = 5;
            this.lblNum2.Text = "num2";
            // 
            // txbN2
            // 
            this.txbN2.Location = new System.Drawing.Point(231, 187);
            this.txbN2.MaxLength = 10;
            this.txbN2.Name = "txbN2";
            this.txbN2.Size = new System.Drawing.Size(199, 20);
            this.txbN2.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(227, 242);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(79, 20);
            this.lblResultado.TabIndex = 6;
            this.lblResultado.Text = "resultado:";
            this.lblResultado.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(323, 242);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 20);
            this.lblResposta.TabIndex = 7;
            this.lblResposta.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(479, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmCalculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.txbN2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txbN1);
            this.Name = "frmCalculos";
            this.Text = "frmCalculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbN1;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txbN2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button button1;
    }
}