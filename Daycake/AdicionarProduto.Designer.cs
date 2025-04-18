namespace Daycake
{
    partial class AdicionarProduto
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
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.mtxIdProduto = new System.Windows.Forms.MaskedTextBox();
            this.mtxPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTempoPreparo = new System.Windows.Forms.Label();
            this.mtxTempoPreparo = new System.Windows.Forms.MaskedTextBox();
            this.gbxAtivoInativo = new System.Windows.Forms.GroupBox();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.gbxAtivoInativo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.Location = new System.Drawing.Point(49, 35);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(61, 13);
            this.lblIdProduto.TabIndex = 0;
            this.lblIdProduto.Text = "ID Produto:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(206, 35);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(38, 13);
            this.lblPreco.TabIndex = 1;
            this.lblPreco.Text = "Preço:";
            // 
            // mtxIdProduto
            // 
            this.mtxIdProduto.Location = new System.Drawing.Point(52, 51);
            this.mtxIdProduto.Name = "mtxIdProduto";
            this.mtxIdProduto.Size = new System.Drawing.Size(140, 20);
            this.mtxIdProduto.TabIndex = 2;
            // 
            // mtxPreco
            // 
            this.mtxPreco.Location = new System.Drawing.Point(207, 51);
            this.mtxPreco.Name = "mtxPreco";
            this.mtxPreco.Size = new System.Drawing.Size(146, 20);
            this.mtxPreco.TabIndex = 3;
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Location = new System.Drawing.Point(49, 92);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(85, 13);
            this.lblNomeCompleto.TabIndex = 4;
            this.lblNomeCompleto.Text = "Nome Completo:";
            this.lblNomeCompleto.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Location = new System.Drawing.Point(52, 108);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(301, 20);
            this.txtNomeCompleto.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(49, 147);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 6;
            this.lblDescricao.Text = "Descrição:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 163);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 90);
            this.textBox1.TabIndex = 7;
            // 
            // lblTempoPreparo
            // 
            this.lblTempoPreparo.AutoSize = true;
            this.lblTempoPreparo.Location = new System.Drawing.Point(165, 269);
            this.lblTempoPreparo.Name = "lblTempoPreparo";
            this.lblTempoPreparo.Size = new System.Drawing.Size(98, 13);
            this.lblTempoPreparo.TabIndex = 8;
            this.lblTempoPreparo.Text = "Tempo de Preparo:";
            // 
            // mtxTempoPreparo
            // 
            this.mtxTempoPreparo.Location = new System.Drawing.Point(168, 285);
            this.mtxTempoPreparo.Mask = "00:00";
            this.mtxTempoPreparo.Name = "mtxTempoPreparo";
            this.mtxTempoPreparo.Size = new System.Drawing.Size(184, 20);
            this.mtxTempoPreparo.TabIndex = 9;
            // 
            // gbxAtivoInativo
            // 
            this.gbxAtivoInativo.Controls.Add(this.rdbInativo);
            this.gbxAtivoInativo.Controls.Add(this.rdbAtivo);
            this.gbxAtivoInativo.Location = new System.Drawing.Point(52, 269);
            this.gbxAtivoInativo.Name = "gbxAtivoInativo";
            this.gbxAtivoInativo.Size = new System.Drawing.Size(95, 78);
            this.gbxAtivoInativo.TabIndex = 11;
            this.gbxAtivoInativo.TabStop = false;
            this.gbxAtivoInativo.Text = "Ativo / Inativo";
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(18, 23);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 0;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(18, 46);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbInativo.TabIndex = 1;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            this.rdbInativo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Location = new System.Drawing.Point(252, 361);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(101, 28);
            this.btnCadastrarProduto.TabIndex = 12;
            this.btnCadastrarProduto.Text = "Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 424);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.gbxAtivoInativo);
            this.Controls.Add(this.mtxTempoPreparo);
            this.Controls.Add(this.lblTempoPreparo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.lblNomeCompleto);
            this.Controls.Add(this.mtxPreco);
            this.Controls.Add(this.mtxIdProduto);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblIdProduto);
            this.Name = "AdicionarProduto";
            this.Text = "AdicionarProduto";
            this.gbxAtivoInativo.ResumeLayout(false);
            this.gbxAtivoInativo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.MaskedTextBox mtxIdProduto;
        private System.Windows.Forms.MaskedTextBox mtxPreco;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTempoPreparo;
        private System.Windows.Forms.MaskedTextBox mtxTempoPreparo;
        private System.Windows.Forms.GroupBox gbxAtivoInativo;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Button btnCadastrarProduto;
    }
}