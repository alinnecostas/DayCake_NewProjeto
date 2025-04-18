namespace Daycake
{
    partial class Pedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtxIdPedido = new System.Windows.Forms.MaskedTextBox();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.mtxIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.lblTipoDoce = new System.Windows.Forms.Label();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbxTipoDoce = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvwListaDoce = new System.Windows.Forms.ListView();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnCadastrarPedido = new System.Windows.Forms.Button();
            this.mtxDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtxDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // mtxIdPedido
            // 
            this.mtxIdPedido.Location = new System.Drawing.Point(32, 58);
            this.mtxIdPedido.Name = "mtxIdPedido";
            this.mtxIdPedido.Size = new System.Drawing.Size(200, 20);
            this.mtxIdPedido.TabIndex = 1;
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(28, 42);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(57, 13);
            this.lblIdPedido.TabIndex = 2;
            this.lblIdPedido.Text = "ID Pedido:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(265, 42);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(56, 13);
            this.lblIdCliente.TabIndex = 5;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // mtxIdCliente
            // 
            this.mtxIdCliente.Location = new System.Drawing.Point(266, 58);
            this.mtxIdCliente.Name = "mtxIdCliente";
            this.mtxIdCliente.Size = new System.Drawing.Size(197, 20);
            this.mtxIdCliente.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(30, 99);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(69, 13);
            this.lblDataPedido.TabIndex = 6;
            this.lblDataPedido.Text = "Data Pedido:";
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.Location = new System.Drawing.Point(264, 98);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(73, 13);
            this.lblDataEntrega.TabIndex = 8;
            this.lblDataEntrega.Text = "Data Entrega:";
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(32, 153);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(111, 13);
            this.lblFormaPagamento.TabIndex = 10;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(32, 172);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(200, 20);
            this.txtFormaPagamento.TabIndex = 11;
            // 
            // lblTipoDoce
            // 
            this.lblTipoDoce.AutoSize = true;
            this.lblTipoDoce.Location = new System.Drawing.Point(29, 228);
            this.lblTipoDoce.Name = "lblTipoDoce";
            this.lblTipoDoce.Size = new System.Drawing.Size(75, 13);
            this.lblTipoDoce.TabIndex = 12;
            this.lblTipoDoce.Text = "Tipo de Doce:";
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Location = new System.Drawing.Point(29, 306);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(73, 13);
            this.lblObservacoes.TabIndex = 14;
            this.lblObservacoes.Text = "Observações:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 323);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(434, 89);
            this.textBox1.TabIndex = 15;
            // 
            // cbxTipoDoce
            // 
            this.cbxTipoDoce.FormattingEnabled = true;
            this.cbxTipoDoce.Location = new System.Drawing.Point(32, 246);
            this.cbxTipoDoce.Name = "cbxTipoDoce";
            this.cbxTipoDoce.Size = new System.Drawing.Size(200, 21);
            this.cbxTipoDoce.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 172);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Forma de Pagamento:";
            // 
            // lvwListaDoce
            // 
            this.lvwListaDoce.HideSelection = false;
            this.lvwListaDoce.Location = new System.Drawing.Point(266, 228);
            this.lvwListaDoce.Name = "lvwListaDoce";
            this.lvwListaDoce.Size = new System.Drawing.Size(197, 74);
            this.lvwListaDoce.TabIndex = 18;
            this.lvwListaDoce.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(157, 273);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarPedido
            // 
            this.btnCadastrarPedido.Location = new System.Drawing.Point(364, 428);
            this.btnCadastrarPedido.Name = "btnCadastrarPedido";
            this.btnCadastrarPedido.Size = new System.Drawing.Size(99, 33);
            this.btnCadastrarPedido.TabIndex = 20;
            this.btnCadastrarPedido.Text = "Cadastrar";
            this.btnCadastrarPedido.UseVisualStyleBackColor = true;
            // 
            // mtxDataEntrega
            // 
            this.mtxDataEntrega.Location = new System.Drawing.Point(266, 115);
            this.mtxDataEntrega.Mask = "00/00/0000";
            this.mtxDataEntrega.Name = "mtxDataEntrega";
            this.mtxDataEntrega.Size = new System.Drawing.Size(197, 20);
            this.mtxDataEntrega.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 22;
            // 
            // mtxDataPedido
            // 
            this.mtxDataPedido.Location = new System.Drawing.Point(32, 116);
            this.mtxDataPedido.Mask = "00/00/0000";
            this.mtxDataPedido.Name = "mtxDataPedido";
            this.mtxDataPedido.Size = new System.Drawing.Size(197, 20);
            this.mtxDataPedido.TabIndex = 25;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 482);
            this.Controls.Add(this.mtxDataPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxDataEntrega);
            this.Controls.Add(this.btnCadastrarPedido);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lvwListaDoce);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblObservacoes);
            this.Controls.Add(this.cbxTipoDoce);
            this.Controls.Add(this.lblTipoDoce);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.lblFormaPagamento);
            this.Controls.Add(this.lblDataEntrega);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.mtxIdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdPedido);
            this.Controls.Add(this.mtxIdPedido);
            this.Controls.Add(this.label1);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxIdPedido;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.MaskedTextBox mtxIdCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label lblTipoDoce;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbxTipoDoce;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvwListaDoce;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnCadastrarPedido;
        private System.Windows.Forms.MaskedTextBox mtxDataEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtxDataPedido;
    }
}