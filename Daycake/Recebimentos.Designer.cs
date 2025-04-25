namespace Daycake
{
    partial class Recebimentos
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
            this.lstRecebimentos = new System.Windows.Forms.ListView();
            this.gbxFiltro = new System.Windows.Forms.GroupBox();
            this.mtbIdcliente = new System.Windows.Forms.MaskedTextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.mtbIdpedido = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dtpDatapedido = new System.Windows.Forms.DateTimePicker();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.gbxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRecebimentos
            // 
            this.lstRecebimentos.HideSelection = false;
            this.lstRecebimentos.Location = new System.Drawing.Point(13, 142);
            this.lstRecebimentos.Name = "lstRecebimentos";
            this.lstRecebimentos.Size = new System.Drawing.Size(571, 297);
            this.lstRecebimentos.TabIndex = 0;
            this.lstRecebimentos.UseCompatibleStateImageBehavior = false;
            // 
            // gbxFiltro
            // 
            this.gbxFiltro.Controls.Add(this.mtbIdcliente);
            this.gbxFiltro.Controls.Add(this.lblIdCliente);
            this.gbxFiltro.Controls.Add(this.mtbIdpedido);
            this.gbxFiltro.Controls.Add(this.lblStatus);
            this.gbxFiltro.Controls.Add(this.lblDataPedido);
            this.gbxFiltro.Controls.Add(this.lblIdPedido);
            this.gbxFiltro.Controls.Add(this.btnFiltrar);
            this.gbxFiltro.Controls.Add(this.cbxStatus);
            this.gbxFiltro.Controls.Add(this.dtpDatapedido);
            this.gbxFiltro.Location = new System.Drawing.Point(12, 12);
            this.gbxFiltro.Name = "gbxFiltro";
            this.gbxFiltro.Size = new System.Drawing.Size(572, 115);
            this.gbxFiltro.TabIndex = 1;
            this.gbxFiltro.TabStop = false;
            this.gbxFiltro.Text = "Filtro";
            // 
            // mtbIdcliente
            // 
            this.mtbIdcliente.Location = new System.Drawing.Point(122, 48);
            this.mtbIdcliente.Name = "mtbIdcliente";
            this.mtbIdcliente.Size = new System.Drawing.Size(100, 20);
            this.mtbIdcliente.TabIndex = 8;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(119, 30);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(56, 13);
            this.lblIdCliente.TabIndex = 7;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // mtbIdpedido
            // 
            this.mtbIdpedido.Location = new System.Drawing.Point(17, 48);
            this.mtbIdpedido.Name = "mtbIdpedido";
            this.mtbIdpedido.Size = new System.Drawing.Size(100, 20);
            this.mtbIdpedido.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(397, 31);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Location = new System.Drawing.Point(226, 32);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(83, 13);
            this.lblDataPedido.TabIndex = 4;
            this.lblDataPedido.Text = "Data do pedido:";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.Location = new System.Drawing.Point(14, 30);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(57, 13);
            this.lblIdPedido.TabIndex = 3;
            this.lblIdPedido.Text = "ID Pedido:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(441, 75);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(117, 26);
            this.btnFiltrar.TabIndex = 2;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(400, 47);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(157, 21);
            this.cbxStatus.TabIndex = 1;
            // 
            // dtpDatapedido
            // 
            this.dtpDatapedido.Location = new System.Drawing.Point(229, 48);
            this.dtpDatapedido.Name = "dtpDatapedido";
            this.dtpDatapedido.Size = new System.Drawing.Size(165, 20);
            this.dtpDatapedido.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(490, 446);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(94, 26);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // Recebimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 479);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.gbxFiltro);
            this.Controls.Add(this.lstRecebimentos);
            this.Name = "Recebimentos";
            this.Text = "Recebimentos";
            this.gbxFiltro.ResumeLayout(false);
            this.gbxFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstRecebimentos;
        private System.Windows.Forms.GroupBox gbxFiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.DateTimePicker dtpDatapedido;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.MaskedTextBox mtbIdpedido;
        private System.Windows.Forms.MaskedTextBox mtbIdcliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Button btnExcluir;
    }
}