namespace Daycake
{
    partial class FormPedido
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
            this.tabControlPedidos = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tblPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoDoce = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lvwTipoDoce = new System.Windows.Forms.ListView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxTipoDoce = new System.Windows.Forms.ComboBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mtbDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.mtbDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tblPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mtbIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabConsultarPedidos = new System.Windows.Forms.TabPage();
            this.tblPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluirPedidos = new System.Windows.Forms.Button();
            this.lstListaPedidos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarPedidos = new System.Windows.Forms.Button();
            this.txtBuscarPedidos = new System.Windows.Forms.TextBox();
            this.lblBuscarPedidos = new System.Windows.Forms.Label();
            this.tabControlPedidos.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.tblPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblPanel3.SuspendLayout();
            this.tblPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabConsultarPedidos.SuspendLayout();
            this.tblPanelBase.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPedidos
            // 
            this.tabControlPedidos.Controls.Add(this.tabPedidos);
            this.tabControlPedidos.Controls.Add(this.tabConsultarPedidos);
            this.tabControlPedidos.Location = new System.Drawing.Point(0, -3);
            this.tabControlPedidos.Name = "tabControlPedidos";
            this.tabControlPedidos.SelectedIndex = 0;
            this.tabControlPedidos.Size = new System.Drawing.Size(878, 462);
            this.tabControlPedidos.TabIndex = 0;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.tblPanel5);
            this.tabPedidos.Location = new System.Drawing.Point(4, 24);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(870, 434);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // tblPanel5
            // 
            this.tblPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel5.BackgroundImage = global::Daycake.Properties.Resources.Fundo_login;
            this.tblPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblPanel5.ColumnCount = 1;
            this.tblPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel5.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tblPanel5.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tblPanel5.Controls.Add(this.tableLayoutPanel1, 0, 7);
            this.tblPanel5.Controls.Add(this.tblPanel3, 0, 5);
            this.tblPanel5.Controls.Add(this.tblPanel1, 0, 1);
            this.tblPanel5.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tblPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblPanel5.Location = new System.Drawing.Point(3, 3);
            this.tblPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblPanel5.Name = "tblPanel5";
            this.tblPanel5.RowCount = 9;
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.40909F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.72727F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.81818F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.97561F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.12195F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90909F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tblPanel5.Size = new System.Drawing.Size(864, 428);
            this.tblPanel5.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 385F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.lblTipoDoce, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 120);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.52577F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.47423F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(856, 98);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lblTipoDoce
            // 
            this.lblTipoDoce.AutoSize = true;
            this.lblTipoDoce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblTipoDoce.Location = new System.Drawing.Point(44, 0);
            this.lblTipoDoce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoce.Name = "lblTipoDoce";
            this.lblTipoDoce.Size = new System.Drawing.Size(79, 15);
            this.lblTipoDoce.TabIndex = 35;
            this.lblTipoDoce.Text = "Tipo de doce:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lvwTipoDoce, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(435, 20);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(377, 75);
            this.tableLayoutPanel4.TabIndex = 39;
            // 
            // lvwTipoDoce
            // 
            this.lvwTipoDoce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwTipoDoce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lvwTipoDoce.HideSelection = false;
            this.lvwTipoDoce.Location = new System.Drawing.Point(4, 3);
            this.lvwTipoDoce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvwTipoDoce.Name = "lvwTipoDoce";
            this.lvwTipoDoce.Size = new System.Drawing.Size(369, 69);
            this.lvwTipoDoce.TabIndex = 40;
            this.lvwTipoDoce.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 361F));
            this.tableLayoutPanel5.Controls.Add(this.cbxTipoDoce, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnAdicionar, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(44, 20);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(361, 75);
            this.tableLayoutPanel5.TabIndex = 40;
            // 
            // cbxTipoDoce
            // 
            this.cbxTipoDoce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxTipoDoce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cbxTipoDoce.FormattingEnabled = true;
            this.cbxTipoDoce.Location = new System.Drawing.Point(4, 3);
            this.cbxTipoDoce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxTipoDoce.Name = "cbxTipoDoce";
            this.cbxTipoDoce.Size = new System.Drawing.Size(353, 23);
            this.cbxTipoDoce.TabIndex = 39;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnAdicionar.Location = new System.Drawing.Point(269, 40);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(88, 27);
            this.btnAdicionar.TabIndex = 40;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.67442F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.842377F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4832F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Controls.Add(this.mtbDataEntrega, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDataEntrega, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mtbDataPedido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDataPedido, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 71);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(856, 43);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // mtbDataEntrega
            // 
            this.mtbDataEntrega.Location = new System.Drawing.Point(433, 17);
            this.mtbDataEntrega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbDataEntrega.Mask = "00/00/0000";
            this.mtbDataEntrega.Name = "mtbDataEntrega";
            this.mtbDataEntrega.Size = new System.Drawing.Size(374, 23);
            this.mtbDataEntrega.TabIndex = 48;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblDataEntrega.Location = new System.Drawing.Point(433, 0);
            this.lblDataEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(93, 14);
            this.lblDataEntrega.TabIndex = 47;
            this.lblDataEntrega.Text = "Data de Entrega:";
            // 
            // mtbDataPedido
            // 
            this.mtbDataPedido.Location = new System.Drawing.Point(44, 17);
            this.mtbDataPedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbDataPedido.Mask = "00/00/0000";
            this.mtbDataPedido.Name = "mtbDataPedido";
            this.mtbDataPedido.Size = new System.Drawing.Size(360, 23);
            this.mtbDataPedido.TabIndex = 46;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblDataPedido.Location = new System.Drawing.Point(44, 0);
            this.lblDataPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(91, 14);
            this.lblDataPedido.TabIndex = 31;
            this.lblDataPedido.Text = "Data do Pedido:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.54522F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.971576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Controls.Add(this.btnFazerPedido, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVoltar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 363);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 36);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFazerPedido.AutoSize = true;
            this.btnFazerPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnFazerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.btnFazerPedido.Location = new System.Drawing.Point(685, 4);
            this.btnFazerPedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(122, 27);
            this.btnFazerPedido.TabIndex = 39;
            this.btnFazerPedido.Text = "Fazer Pedido";
            this.btnFazerPedido.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFazerPedido.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnVoltar.Location = new System.Drawing.Point(44, 4);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(83, 27);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // tblPanel3
            // 
            this.tblPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel3.ColumnCount = 5;
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.6129F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.709677F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.67742F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblPanel3.Controls.Add(this.label1, 1, 0);
            this.tblPanel3.Controls.Add(this.txtValor, 1, 1);
            this.tblPanel3.Controls.Add(this.txtFormaPagamento, 3, 1);
            this.tblPanel3.Controls.Add(this.lblFormaPagamento, 3, 0);
            this.tblPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel3.Location = new System.Drawing.Point(4, 305);
            this.tblPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblPanel3.Name = "tblPanel3";
            this.tblPanel3.RowCount = 2;
            this.tblPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.04878F));
            this.tblPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.95122F));
            this.tblPanel3.Size = new System.Drawing.Size(856, 52);
            this.tblPanel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label1.Location = new System.Drawing.Point(44, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 38;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtValor.Location = new System.Drawing.Point(44, 17);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(360, 32);
            this.txtValor.TabIndex = 37;
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtFormaPagamento.Location = new System.Drawing.Point(432, 17);
            this.txtFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFormaPagamento.Multiline = true;
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(376, 32);
            this.txtFormaPagamento.TabIndex = 36;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblFormaPagamento.Location = new System.Drawing.Point(432, 0);
            this.lblFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(124, 14);
            this.lblFormaPagamento.TabIndex = 35;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // tblPanel1
            // 
            this.tblPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel1.ColumnCount = 3;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tblPanel1.Controls.Add(this.mtbIdCliente, 1, 1);
            this.tblPanel1.Controls.Add(this.lblIdCliente, 1, 0);
            this.tblPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel1.Location = new System.Drawing.Point(4, 19);
            this.tblPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 2;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel1.Size = new System.Drawing.Size(856, 46);
            this.tblPanel1.TabIndex = 0;
            // 
            // mtbIdCliente
            // 
            this.mtbIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mtbIdCliente.Location = new System.Drawing.Point(44, 20);
            this.mtbIdCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbIdCliente.Name = "mtbIdCliente";
            this.mtbIdCliente.Size = new System.Drawing.Size(766, 23);
            this.mtbIdCliente.TabIndex = 35;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblIdCliente.Location = new System.Drawing.Point(44, 0);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(61, 15);
            this.lblIdCliente.TabIndex = 34;
            this.lblIdCliente.Text = "ID Cliente:";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.txtDescricao, 1, 1);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 224);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(856, 75);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.label2.Location = new System.Drawing.Point(44, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtDescricao.Location = new System.Drawing.Point(44, 16);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(768, 56);
            this.txtDescricao.TabIndex = 35;
            // 
            // tabConsultarPedidos
            // 
            this.tabConsultarPedidos.Controls.Add(this.tblPanelBase);
            this.tabConsultarPedidos.Location = new System.Drawing.Point(4, 24);
            this.tabConsultarPedidos.Name = "tabConsultarPedidos";
            this.tabConsultarPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarPedidos.Size = new System.Drawing.Size(870, 434);
            this.tabConsultarPedidos.TabIndex = 1;
            this.tabConsultarPedidos.Text = "Consultar Pedidos";
            this.tabConsultarPedidos.UseVisualStyleBackColor = true;
            this.tabConsultarPedidos.Click += new System.EventHandler(this.tabConsultarPedidos_Click);
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
            this.tblPanelBase.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tblPanelBase.Location = new System.Drawing.Point(-4, 0);
            this.tblPanelBase.Name = "tblPanelBase";
            this.tblPanelBase.RowCount = 4;
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblPanelBase.Size = new System.Drawing.Size(878, 434);
            this.tblPanelBase.TabIndex = 2;
            // 
            // btnExcluirPedidos
            // 
            this.btnExcluirPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnExcluirPedidos.Location = new System.Drawing.Point(43, 399);
            this.btnExcluirPedidos.Name = "btnExcluirPedidos";
            this.btnExcluirPedidos.Size = new System.Drawing.Size(792, 24);
            this.btnExcluirPedidos.TabIndex = 5;
            this.btnExcluirPedidos.Text = "Excluir";
            this.btnExcluirPedidos.UseVisualStyleBackColor = true;
            // 
            // lstListaPedidos
            // 
            this.lstListaPedidos.BackColor = System.Drawing.Color.White;
            this.lstListaPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lstListaPedidos.HideSelection = false;
            this.lstListaPedidos.Location = new System.Drawing.Point(43, 83);
            this.lstListaPedidos.Name = "lstListaPedidos";
            this.lstListaPedidos.Size = new System.Drawing.Size(792, 287);
            this.lstListaPedidos.TabIndex = 1;
            this.lstListaPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.51402F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.485981F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel7.Controls.Add(this.btnBuscarPedidos, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.txtBuscarPedidos, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblBuscarPedidos, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(43, 13);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(792, 54);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // btnBuscarPedidos
            // 
            this.btnBuscarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnBuscarPedidos.Location = new System.Drawing.Point(692, 22);
            this.btnBuscarPedidos.Name = "btnBuscarPedidos";
            this.btnBuscarPedidos.Size = new System.Drawing.Size(97, 23);
            this.btnBuscarPedidos.TabIndex = 6;
            this.btnBuscarPedidos.Text = "Buscar";
            this.btnBuscarPedidos.UseVisualStyleBackColor = true;
            // 
            // txtBuscarPedidos
            // 
            this.txtBuscarPedidos.BackColor = System.Drawing.Color.White;
            this.txtBuscarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtBuscarPedidos.Location = new System.Drawing.Point(3, 22);
            this.txtBuscarPedidos.Name = "txtBuscarPedidos";
            this.txtBuscarPedidos.Size = new System.Drawing.Size(639, 23);
            this.txtBuscarPedidos.TabIndex = 5;
            // 
            // lblBuscarPedidos
            // 
            this.lblBuscarPedidos.AutoSize = true;
            this.lblBuscarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lblBuscarPedidos.Location = new System.Drawing.Point(3, 0);
            this.lblBuscarPedidos.Name = "lblBuscarPedidos";
            this.lblBuscarPedidos.Size = new System.Drawing.Size(105, 15);
            this.lblBuscarPedidos.TabIndex = 4;
            this.lblBuscarPedidos.Text = "Digite a sua busca:";
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daycake.Properties.Resources.Fundo_login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 459);
            this.Controls.Add(this.tabControlPedidos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.tabControlPedidos.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tblPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblPanel3.ResumeLayout(false);
            this.tblPanel3.PerformLayout();
            this.tblPanel1.ResumeLayout(false);
            this.tblPanel1.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tabConsultarPedidos.ResumeLayout(false);
            this.tblPanelBase.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPedidos;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TableLayoutPanel tblPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTipoDoce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListView lvwTipoDoce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cbxTipoDoce;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox mtbDataEntrega;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.MaskedTextBox mtbDataPedido;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TableLayoutPanel tblPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.MaskedTextBox mtbIdCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TabPage tabConsultarPedidos;
        private System.Windows.Forms.TableLayoutPanel tblPanelBase;
        private System.Windows.Forms.Button btnExcluirPedidos;
        private System.Windows.Forms.ListView lstListaPedidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnBuscarPedidos;
        private System.Windows.Forms.TextBox txtBuscarPedidos;
        private System.Windows.Forms.Label lblBuscarPedidos;
    }
}