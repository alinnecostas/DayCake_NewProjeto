namespace Daycake
{
    partial class Status
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
            this.tabControlStatus = new System.Windows.Forms.TabControl();
            this.tabStatusPedido = new System.Windows.Forms.TabPage();
            this.tblPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluirPedidos = new System.Windows.Forms.Button();
            this.lstListaPedidos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.dtpDatapedido = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlStatus.SuspendLayout();
            this.tabStatusPedido.SuspendLayout();
            this.tblPanelBase.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStatus
            // 
            this.tabControlStatus.Controls.Add(this.tabStatusPedido);
            this.tabControlStatus.Controls.Add(this.tabRelatorio);
            this.tabControlStatus.Location = new System.Drawing.Point(-3, 1);
            this.tabControlStatus.Name = "tabControlStatus";
            this.tabControlStatus.SelectedIndex = 0;
            this.tabControlStatus.Size = new System.Drawing.Size(802, 447);
            this.tabControlStatus.TabIndex = 0;
            // 
            // tabStatusPedido
            // 
            this.tabStatusPedido.Controls.Add(this.tblPanelBase);
            this.tabStatusPedido.Location = new System.Drawing.Point(4, 22);
            this.tabStatusPedido.Name = "tabStatusPedido";
            this.tabStatusPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatusPedido.Size = new System.Drawing.Size(794, 421);
            this.tabStatusPedido.TabIndex = 0;
            this.tabStatusPedido.Text = "Status do Pedido";
            this.tabStatusPedido.UseVisualStyleBackColor = true;
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
            this.tblPanelBase.Location = new System.Drawing.Point(-4, 0);
            this.tblPanelBase.Name = "tblPanelBase";
            this.tblPanelBase.RowCount = 4;
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblPanelBase.Size = new System.Drawing.Size(802, 425);
            this.tblPanelBase.TabIndex = 4;
            // 
            // btnExcluirPedidos
            // 
            this.btnExcluirPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluirPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnExcluirPedidos.Location = new System.Drawing.Point(598, 390);
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
            this.lstListaPedidos.Size = new System.Drawing.Size(716, 268);
            this.lstListaPedidos.TabIndex = 1;
            this.lstListaPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnFiltrar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFiltre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(43, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 97);
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
            this.btnFiltrar.Size = new System.Drawing.Size(710, 22);
            this.btnFiltrar.TabIndex = 36;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // lblFiltre
            // 
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblFiltre.Location = new System.Drawing.Point(4, 0);
            this.lblFiltre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltre.Name = "lblFiltre";
            this.lblFiltre.Size = new System.Drawing.Size(99, 13);
            this.lblFiltre.TabIndex = 35;
            this.lblFiltre.Text = "Filtre aqui o pedido:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dateTimePicker1, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDataEntrega, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxStatus, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpDatapedido, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblStatus, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDataPedido, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(710, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 20);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblDataEntrega.Location = new System.Drawing.Point(238, 0);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(87, 13);
            this.lblDataEntrega.TabIndex = 15;
            this.lblDataEntrega.Text = "Data do entrega:";
            // 
            // cbxStatus
            // 
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(472, 23);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(235, 21);
            this.cbxStatus.TabIndex = 14;
            // 
            // dtpDatapedido
            // 
            this.dtpDatapedido.Location = new System.Drawing.Point(3, 23);
            this.dtpDatapedido.Name = "dtpDatapedido";
            this.dtpDatapedido.Size = new System.Drawing.Size(214, 20);
            this.dtpDatapedido.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblStatus.Location = new System.Drawing.Point(472, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status:";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblDataPedido.Location = new System.Drawing.Point(3, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(83, 13);
            this.lblDataPedido.TabIndex = 9;
            this.lblDataPedido.Text = "Data do pedido:";
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.tableLayoutPanel3);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(794, 421);
            this.tabRelatorio.TabIndex = 1;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImage = global::Daycake.Properties.Resources.Fundo_login1;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.listView1, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(-4, -2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(802, 425);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.button1.Location = new System.Drawing.Point(598, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 116);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(716, 268);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(43, 13);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.89691F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(716, 97);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.button2.Location = new System.Drawing.Point(3, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(710, 22);
            this.button2.TabIndex = 36;
            this.button2.Text = "Filtrar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 241F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(710, 47);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Status";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status";
            this.tabControlStatus.ResumeLayout(false);
            this.tabStatusPedido.ResumeLayout(false);
            this.tblPanelBase.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabRelatorio.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStatus;
        private System.Windows.Forms.TabPage tabStatusPedido;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.TableLayoutPanel tblPanelBase;
        private System.Windows.Forms.Button btnExcluirPedidos;
        private System.Windows.Forms.ListView lstListaPedidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.DateTimePicker dtpDatapedido;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}