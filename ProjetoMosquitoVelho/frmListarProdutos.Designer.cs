﻿
namespace ProjetoMosquitoVelho
{
    partial class frmListarProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProdutos));
            this.btnCarregar = new System.Windows.Forms.Button();
            this.lblProdutos = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.ltbListaprodutos = new System.Windows.Forms.ListBox();
            this.cbbProdutos = new System.Windows.Forms.ComboBox();
            this.lblListadeprodutos = new System.Windows.Forms.Label();
            this.cbbListaritems = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTestarPessoa = new System.Windows.Forms.Button();
            this.lblMostrapessoa = new System.Windows.Forms.Label();
            this.btnReserva = new System.Windows.Forms.Button();
            this.lblDocumentos = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblnumerocartao = new System.Windows.Forms.Label();
            this.lblMostrardocumento = new System.Windows.Forms.Label();
            this.mtbNumerocartao = new System.Windows.Forms.MaskedTextBox();
            this.lblMostrarnumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCarregar
            // 
            this.btnCarregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregar.Location = new System.Drawing.Point(558, 375);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(105, 36);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // lblProdutos
            // 
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.Location = new System.Drawing.Point(17, 69);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(73, 20);
            this.lblProdutos.TabIndex = 1;
            this.lblProdutos.Text = "Produtos";
            this.lblProdutos.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(713, 375);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(105, 36);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // ltbListaprodutos
            // 
            this.ltbListaprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbListaprodutos.FormattingEnabled = true;
            this.ltbListaprodutos.ItemHeight = 20;
            this.ltbListaprodutos.Location = new System.Drawing.Point(558, 92);
            this.ltbListaprodutos.Name = "ltbListaprodutos";
            this.ltbListaprodutos.Size = new System.Drawing.Size(260, 204);
            this.ltbListaprodutos.TabIndex = 9;
            // 
            // cbbProdutos
            // 
            this.cbbProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbProdutos.FormattingEnabled = true;
            this.cbbProdutos.Location = new System.Drawing.Point(21, 92);
            this.cbbProdutos.Name = "cbbProdutos";
            this.cbbProdutos.Size = new System.Drawing.Size(121, 28);
            this.cbbProdutos.TabIndex = 10;
            this.cbbProdutos.SelectedIndexChanged += new System.EventHandler(this.cbbProdutos_SelectedIndexChanged);
            // 
            // lblListadeprodutos
            // 
            this.lblListadeprodutos.AutoSize = true;
            this.lblListadeprodutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadeprodutos.Location = new System.Drawing.Point(554, 69);
            this.lblListadeprodutos.Name = "lblListadeprodutos";
            this.lblListadeprodutos.Size = new System.Drawing.Size(132, 20);
            this.lblListadeprodutos.TabIndex = 11;
            this.lblListadeprodutos.Text = "Lista de produtos";
            // 
            // cbbListaritems
            // 
            this.cbbListaritems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbListaritems.FormattingEnabled = true;
            this.cbbListaritems.Items.AddRange(new object[] {
            "abobora",
            "jaca",
            "manga",
            "peixe"});
            this.cbbListaritems.Location = new System.Drawing.Point(211, 92);
            this.cbbListaritems.Name = "cbbListaritems";
            this.cbbListaritems.Size = new System.Drawing.Size(121, 28);
            this.cbbListaritems.TabIndex = 13;
            this.cbbListaritems.SelectedIndexChanged += new System.EventHandler(this.cbbListaritems_SelectedIndexChanged);
            this.cbbListaritems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbbListaritems_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Listar items";
            // 
            // btnTestarPessoa
            // 
            this.btnTestarPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestarPessoa.Location = new System.Drawing.Point(21, 169);
            this.btnTestarPessoa.Name = "btnTestarPessoa";
            this.btnTestarPessoa.Size = new System.Drawing.Size(121, 36);
            this.btnTestarPessoa.TabIndex = 14;
            this.btnTestarPessoa.Text = "Testar pessoa";
            this.btnTestarPessoa.UseVisualStyleBackColor = true;
            this.btnTestarPessoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMostrapessoa
            // 
            this.lblMostrapessoa.AutoSize = true;
            this.lblMostrapessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrapessoa.Location = new System.Drawing.Point(165, 169);
            this.lblMostrapessoa.Name = "lblMostrapessoa";
            this.lblMostrapessoa.Size = new System.Drawing.Size(114, 20);
            this.lblMostrapessoa.TabIndex = 15;
            this.lblMostrapessoa.Text = "Mostra pessoa";
            this.lblMostrapessoa.Click += new System.EventHandler(this.lblMostrapessoa_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserva.Location = new System.Drawing.Point(21, 260);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(121, 36);
            this.btnReserva.TabIndex = 16;
            this.btnReserva.Text = "Reservar";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
            // 
            // lblDocumentos
            // 
            this.lblDocumentos.AutoSize = true;
            this.lblDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentos.Location = new System.Drawing.Point(165, 244);
            this.lblDocumentos.Name = "lblDocumentos";
            this.lblDocumentos.Size = new System.Drawing.Size(100, 20);
            this.lblDocumentos.TabIndex = 18;
            this.lblDocumentos.Text = "Documentos";
            this.lblDocumentos.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(169, 270);
            this.txtDocumento.MaxLength = 30;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 19;
            // 
            // lblnumerocartao
            // 
            this.lblnumerocartao.AutoSize = true;
            this.lblnumerocartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerocartao.Location = new System.Drawing.Point(165, 324);
            this.lblnumerocartao.Name = "lblnumerocartao";
            this.lblnumerocartao.Size = new System.Drawing.Size(139, 20);
            this.lblnumerocartao.TabIndex = 21;
            this.lblnumerocartao.Text = "Numero do Cartão";
            // 
            // lblMostrardocumento
            // 
            this.lblMostrardocumento.AutoSize = true;
            this.lblMostrardocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrardocumento.Location = new System.Drawing.Point(309, 270);
            this.lblMostrardocumento.Name = "lblMostrardocumento";
            this.lblMostrardocumento.Size = new System.Drawing.Size(150, 20);
            this.lblMostrardocumento.TabIndex = 22;
            this.lblMostrardocumento.Text = "Mostrar Documento";
            // 
            // mtbNumerocartao
            // 
            this.mtbNumerocartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtbNumerocartao.Location = new System.Drawing.Point(169, 347);
            this.mtbNumerocartao.Mask = "000,000,000-00";
            this.mtbNumerocartao.Name = "mtbNumerocartao";
            this.mtbNumerocartao.Size = new System.Drawing.Size(128, 26);
            this.mtbNumerocartao.TabIndex = 26;
            this.mtbNumerocartao.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNumerocartao_MaskInputRejected);
            // 
            // lblMostrarnumero
            // 
            this.lblMostrarnumero.AutoSize = true;
            this.lblMostrarnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarnumero.Location = new System.Drawing.Point(309, 347);
            this.lblMostrarnumero.Name = "lblMostrarnumero";
            this.lblMostrarnumero.Size = new System.Drawing.Size(172, 20);
            this.lblMostrarnumero.TabIndex = 25;
            this.lblMostrarnumero.Text = "mostrar Número cartão";
            // 
            // frmListarProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.mtbNumerocartao);
            this.Controls.Add(this.lblMostrarnumero);
            this.Controls.Add(this.lblMostrardocumento);
            this.Controls.Add(this.lblnumerocartao);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumentos);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.lblMostrapessoa);
            this.Controls.Add(this.btnTestarPessoa);
            this.Controls.Add(this.cbbListaritems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblListadeprodutos);
            this.Controls.Add(this.cbbProdutos);
            this.Controls.Add(this.ltbListaprodutos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblProdutos);
            this.Controls.Add(this.btnCarregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmListarProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListarProdutos";
            this.Load += new System.EventHandler(this.frmListarProdutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ListBox ltbListaprodutos;
        private System.Windows.Forms.ComboBox cbbProdutos;
        private System.Windows.Forms.Label lblListadeprodutos;
        private System.Windows.Forms.ComboBox cbbListaritems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTestarPessoa;
        private System.Windows.Forms.Label lblMostrapessoa;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Label lblDocumentos;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblnumerocartao;
        private System.Windows.Forms.Label lblMostrardocumento;
        private System.Windows.Forms.MaskedTextBox mtbNumerocartao;
        private System.Windows.Forms.Label lblMostrarnumero;
    }
}