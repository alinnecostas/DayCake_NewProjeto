namespace Daycake
{
    partial class Recebimento
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
            this.tblPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluirPedidos = new System.Windows.Forms.Button();
            this.lstListaPedidos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dtpDatapedido = new System.Windows.Forms.DateTimePicker();
            this.mtbIdcliente = new System.Windows.Forms.MaskedTextBox();
            this.mtbIdpedido = new System.Windows.Forms.MaskedTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblIdPedido = new System.Windows.Forms.Label();
            this.tblPanelBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPanelBase
            // 
            this.tblPanelBase.BackgroundImage = global::Daycake.Properties.Resources.Fundo_login1;
            this.tblPanelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblPanelBase.ColumnCount = 3;
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelBase.Controls.Add(this.btnExcluirPedidos, 1, 3);
            this.tblPanelBase.Controls.Add(this.lstListaPedidos, 1, 2);
            this.tblPanelBase.Controls.Add(this.tableLayoutPanel1, 1, 1);
            this.tblPanelBase.Location = new System.Drawing.Point(-1, -2);
            this.tblPanelBase.Name = "tblPanelBase";
            this.tblPanelBase.RowCount = 4;
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblPanelBase.Size = new System.Drawing.Size(803, 453);
            this.tblPanelBase.TabIndex = 3;
            // 
            // btnExcluirPedidos
            // 
            this.btnExcluirPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnExcluirPedidos.Location = new System.Drawing.Point(599, 418);
            this.btnExcluirPedidos.Name = "btnExcluirPedidos";
            this.btnExcluirPedidos.Size = new System.Drawing.Size(161, 24);
            this.btnExcluirPedidos.TabIndex = 5;
            this.btnExcluirPedidos.Text = "Excluir";
            this.btnExcluirPedidos.UseVisualStyleBackColor = true;
            // 
            // lstListaPedidos
            // 
            this.lstListaPedidos.BackColor = System.Drawing.Color.White;
            this.lstListaPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lstListaPedidos.HideSelection = false;
            this.lstListaPedidos.Location = new System.Drawing.Point(43, 116);
            this.lstListaPedidos.Name = "lstListaPedidos";
            this.lstListaPedidos.Size = new System.Drawing.Size(717, 296);
            this.lstListaPedidos.TabIndex = 1;
            this.lstListaPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnFiltrar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFiltro, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(717, 97);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnFiltrar.Location = new System.Drawing.Point(3, 72);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(711, 22);
            this.btnFiltrar.TabIndex = 36;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblFiltro.Location = new System.Drawing.Point(4, 0);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 35;
            this.lblFiltro.Text = "Filtro:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel2.Controls.Add(this.cbxStatus, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpDatapedido, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.mtbIdcliente, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.mtbIdpedido, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDataPedido, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIdCliente, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIdPedido, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(711, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(528, 23);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(180, 21);
            this.cbxStatus.TabIndex = 14;
            // 
            // dtpDatapedido
            // 
            this.dtpDatapedido.Location = new System.Drawing.Point(353, 23);
            this.dtpDatapedido.Name = "dtpDatapedido";
            this.dtpDatapedido.Size = new System.Drawing.Size(156, 20);
            this.dtpDatapedido.TabIndex = 13;
            // 
            // mtbIdcliente
            // 
            this.mtbIdcliente.Location = new System.Drawing.Point(178, 23);
            this.mtbIdcliente.Name = "mtbIdcliente";
            this.mtbIdcliente.Size = new System.Drawing.Size(157, 20);
            this.mtbIdcliente.TabIndex = 12;
            // 
            // mtbIdpedido
            // 
            this.mtbIdpedido.Location = new System.Drawing.Point(3, 23);
            this.mtbIdpedido.Name = "mtbIdpedido";
            this.mtbIdpedido.Size = new System.Drawing.Size(155, 20);
            this.mtbIdpedido.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblStatus.Location = new System.Drawing.Point(528, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblDataPedido.Location = new System.Drawing.Point(353, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(83, 13);
            this.lblDataPedido.TabIndex = 9;
            this.lblDataPedido.Text = "Data do pedido:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblIdCliente.Location = new System.Drawing.Point(178, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(56, 13);
            this.lblIdCliente.TabIndex = 8;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // lblIdPedido
            // 
            this.lblIdPedido.AutoSize = true;
            this.lblIdPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblIdPedido.Location = new System.Drawing.Point(3, 0);
            this.lblIdPedido.Name = "lblIdPedido";
            this.lblIdPedido.Size = new System.Drawing.Size(57, 13);
            this.lblIdPedido.TabIndex = 4;
            this.lblIdPedido.Text = "ID Pedido:";
            // 
            // Recebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tblPanelBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Recebimento";
            this.Text = "Recebimento";
            this.tblPanelBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPanelBase;
        private System.Windows.Forms.Button btnExcluirPedidos;
        private System.Windows.Forms.ListView lstListaPedidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblIdPedido;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MaskedTextBox mtbIdpedido;
        private System.Windows.Forms.MaskedTextBox mtbIdcliente;
        private System.Windows.Forms.DateTimePicker dtpDatapedido;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Button btnFiltrar;
    }
}