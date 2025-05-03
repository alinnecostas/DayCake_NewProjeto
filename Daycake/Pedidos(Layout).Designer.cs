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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedido));
            this.tabControlPedidos = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.tblPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tblPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAtualizarCliente = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnFazerPedido = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoDoce = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lstTipoDoce = new System.Windows.Forms.ListView();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxTipoDoce = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.mtbDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.lblDataEntrega = new System.Windows.Forms.Label();
            this.mtbDataPedido = new System.Windows.Forms.MaskedTextBox();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.tblPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.mtbIdCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.tabConsultarPedidos = new System.Windows.Forms.TabPage();
            this.tblPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluirPedido = new System.Windows.Forms.Button();
            this.lstListaPedidos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscarPedidos = new System.Windows.Forms.Button();
            this.txtBuscarPedidos = new System.Windows.Forms.TextBox();
            this.lblBuscarPedidos = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excluirPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlPedidos.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            this.tblPanel5.SuspendLayout();
            this.tblPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tblPanel3.SuspendLayout();
            this.tblPanel1.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tabConsultarPedidos.SuspendLayout();
            this.tblPanelBase.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPedidos
            // 
            this.tabControlPedidos.Controls.Add(this.tabPedidos);
            this.tabControlPedidos.Controls.Add(this.tabConsultarPedidos);
            this.tabControlPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPedidos.Location = new System.Drawing.Point(0, 0);
            this.tabControlPedidos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tabControlPedidos.Name = "tabControlPedidos";
            this.tabControlPedidos.Padding = new System.Drawing.Point(0, 0);
            this.tabControlPedidos.SelectedIndex = 0;
            this.tabControlPedidos.Size = new System.Drawing.Size(893, 461);
            this.tabControlPedidos.TabIndex = 0;
            this.tabControlPedidos.Click += new System.EventHandler(this.excluirPedidosToolStripMenuItem_Click);
            // 
            // tabPedidos
            // 
            this.tabPedidos.BackColor = System.Drawing.Color.White;
            this.tabPedidos.Controls.Add(this.tblPanel5);
            this.tabPedidos.Location = new System.Drawing.Point(4, 29);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(885, 428);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Pedidos";
            // 
            // tblPanel5
            // 
            this.tblPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel5.BackgroundImage = global::Daycake.Properties.Resources.FundoPag_2;
            this.tblPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblPanel5.ColumnCount = 1;
            this.tblPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel5.Controls.Add(this.tblPanel6, 0, 6);
            this.tblPanel5.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tblPanel5.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tblPanel5.Controls.Add(this.tblPanel3, 0, 4);
            this.tblPanel5.Controls.Add(this.tblPanel1, 0, 0);
            this.tblPanel5.Controls.Add(this.tableLayoutPanel6, 0, 3);
            this.tblPanel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblPanel5.Location = new System.Drawing.Point(3, 3);
            this.tblPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblPanel5.Name = "tblPanel5";
            this.tblPanel5.RowCount = 8;
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.60382F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.45585F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.53588F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.33174F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.88783F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.02387F));
            this.tblPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblPanel5.Size = new System.Drawing.Size(886, 429);
            this.tblPanel5.TabIndex = 15;
            // 
            // tblPanel6
            // 
            this.tblPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblPanel6.ColumnCount = 6;
            this.tblPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.03162F));
            this.tblPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.1556F));
            this.tblPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.81278F));
            this.tblPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tblPanel6.Controls.Add(this.btnAtualizarCliente, 3, 0);
            this.tblPanel6.Controls.Add(this.btnNovo, 1, 0);
            this.tblPanel6.Controls.Add(this.btnFazerPedido, 4, 0);
            this.tblPanel6.Location = new System.Drawing.Point(5, 381);
            this.tblPanel6.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tblPanel6.Name = "tblPanel6";
            this.tblPanel6.RowCount = 1;
            this.tblPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel6.Size = new System.Drawing.Size(876, 34);
            this.tblPanel6.TabIndex = 41;
            // 
            // btnAtualizarCliente
            // 
            this.btnAtualizarCliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAtualizarCliente.AutoSize = true;
            this.btnAtualizarCliente.BackColor = System.Drawing.Color.White;
            this.btnAtualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnAtualizarCliente.Location = new System.Drawing.Point(622, 4);
            this.btnAtualizarCliente.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAtualizarCliente.Name = "btnAtualizarCliente";
            this.btnAtualizarCliente.Size = new System.Drawing.Size(80, 26);
            this.btnAtualizarCliente.TabIndex = 41;
            this.btnAtualizarCliente.Text = "Atualizar";
            this.btnAtualizarCliente.UseVisualStyleBackColor = false;
            this.btnAtualizarCliente.Click += new System.EventHandler(this.btnAtualizarCliente_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNovo.BackColor = System.Drawing.Color.White;
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNovo.Location = new System.Drawing.Point(44, 4);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(109, 26);
            this.btnNovo.TabIndex = 40;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnFazerPedido
            // 
            this.btnFazerPedido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFazerPedido.AutoSize = true;
            this.btnFazerPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnFazerPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFazerPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.btnFazerPedido.Location = new System.Drawing.Point(719, 4);
            this.btnFazerPedido.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnFazerPedido.Name = "btnFazerPedido";
            this.btnFazerPedido.Size = new System.Drawing.Size(107, 26);
            this.btnFazerPedido.TabIndex = 39;
            this.btnFazerPedido.Text = "Fazer pedido";
            this.btnFazerPedido.UseVisualStyleBackColor = false;
            this.btnFazerPedido.Click += new System.EventHandler(this.btnFazerPedido_Click_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.Controls.Add(this.lblTipoDoce, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 108);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.52577F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.47423F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(878, 131);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // lblTipoDoce
            // 
            this.lblTipoDoce.AutoSize = true;
            this.lblTipoDoce.ForeColor = System.Drawing.Color.Black;
            this.lblTipoDoce.Location = new System.Drawing.Point(44, 0);
            this.lblTipoDoce.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoce.Name = "lblTipoDoce";
            this.lblTipoDoce.Size = new System.Drawing.Size(100, 20);
            this.lblTipoDoce.TabIndex = 35;
            this.lblTipoDoce.Text = "Tipo de doce:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lstTipoDoce, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(444, 25);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(389, 103);
            this.tableLayoutPanel4.TabIndex = 39;
            // 
            // lstTipoDoce
            // 
            this.lstTipoDoce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTipoDoce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTipoDoce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lstTipoDoce.HideSelection = false;
            this.lstTipoDoce.Location = new System.Drawing.Point(4, 3);
            this.lstTipoDoce.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstTipoDoce.Name = "lstTipoDoce";
            this.lstTipoDoce.Size = new System.Drawing.Size(381, 97);
            this.lstTipoDoce.TabIndex = 40;
            this.lstTipoDoce.UseCompatibleStateImageBehavior = false;
            this.lstTipoDoce.SelectedIndexChanged += new System.EventHandler(this.lstTipoDoce_SelectedIndexChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 389F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.cbxTipoDoce, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(44, 25);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(389, 103);
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
            this.cbxTipoDoce.Size = new System.Drawing.Size(381, 28);
            this.cbxTipoDoce.TabIndex = 39;
            this.cbxTipoDoce.SelectedIndexChanged += new System.EventHandler(this.cbxTipoDoce_SelectedIndexChanged);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.btnAdicionar, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblQuantidade, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txtQuantidade, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 41);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(383, 59);
            this.tableLayoutPanel8.TabIndex = 42;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdicionar.AutoSize = true;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnAdicionar.Location = new System.Drawing.Point(246, 30);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(133, 26);
            this.btnAdicionar.TabIndex = 42;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.ForeColor = System.Drawing.Color.Black;
            this.lblQuantidade.Location = new System.Drawing.Point(4, 0);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(90, 20);
            this.lblQuantidade.TabIndex = 41;
            this.lblQuantidade.Text = "Quantidade:";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtQuantidade.Location = new System.Drawing.Point(4, 30);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(123, 20);
            this.txtQuantidade.TabIndex = 40;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.Controls.Add(this.mtbDataEntrega, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDataEntrega, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.mtbDataPedido, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblDataPedido, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 60);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(878, 42);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // mtbDataEntrega
            // 
            this.mtbDataEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbDataEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbDataEntrega.Location = new System.Drawing.Point(444, 22);
            this.mtbDataEntrega.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbDataEntrega.Mask = "00/00/0000";
            this.mtbDataEntrega.Name = "mtbDataEntrega";
            this.mtbDataEntrega.Size = new System.Drawing.Size(389, 20);
            this.mtbDataEntrega.TabIndex = 48;
            // 
            // lblDataEntrega
            // 
            this.lblDataEntrega.AutoSize = true;
            this.lblDataEntrega.ForeColor = System.Drawing.Color.Black;
            this.lblDataEntrega.Location = new System.Drawing.Point(444, 0);
            this.lblDataEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataEntrega.Name = "lblDataEntrega";
            this.lblDataEntrega.Size = new System.Drawing.Size(120, 19);
            this.lblDataEntrega.TabIndex = 47;
            this.lblDataEntrega.Text = "Data de Entrega:";
            // 
            // mtbDataPedido
            // 
            this.mtbDataPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbDataPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbDataPedido.Location = new System.Drawing.Point(44, 22);
            this.mtbDataPedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbDataPedido.Mask = "00/00/0000";
            this.mtbDataPedido.Name = "mtbDataPedido";
            this.mtbDataPedido.Size = new System.Drawing.Size(389, 20);
            this.mtbDataPedido.TabIndex = 46;
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.ForeColor = System.Drawing.Color.Black;
            this.lblDataPedido.Location = new System.Drawing.Point(44, 0);
            this.lblDataPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(116, 19);
            this.lblDataPedido.TabIndex = 31;
            this.lblDataPedido.Text = "Data do Pedido:";
            // 
            // tblPanel3
            // 
            this.tblPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel3.ColumnCount = 5;
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblPanel3.Controls.Add(this.cbxFormaPagamento, 3, 1);
            this.tblPanel3.Controls.Add(this.label1, 1, 0);
            this.tblPanel3.Controls.Add(this.txtValor, 1, 1);
            this.tblPanel3.Controls.Add(this.lblFormaPagamento, 3, 0);
            this.tblPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel3.Location = new System.Drawing.Point(4, 326);
            this.tblPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblPanel3.Name = "tblPanel3";
            this.tblPanel3.RowCount = 2;
            this.tblPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.88889F));
            this.tblPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.11111F));
            this.tblPanel3.Size = new System.Drawing.Size(878, 48);
            this.tblPanel3.TabIndex = 2;
            // 
            // cbxFormaPagamento
            // 
            this.cbxFormaPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxFormaPagamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.cbxFormaPagamento.FormattingEnabled = true;
            this.cbxFormaPagamento.Location = new System.Drawing.Point(444, 21);
            this.cbxFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxFormaPagamento.Name = "cbxFormaPagamento";
            this.cbxFormaPagamento.Size = new System.Drawing.Size(389, 28);
            this.cbxFormaPagamento.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(44, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtValor.Location = new System.Drawing.Point(44, 21);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(389, 20);
            this.txtValor.TabIndex = 37;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.ForeColor = System.Drawing.Color.Black;
            this.lblFormaPagamento.Location = new System.Drawing.Point(444, 0);
            this.lblFormaPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(154, 18);
            this.lblFormaPagamento.TabIndex = 35;
            this.lblFormaPagamento.Text = "Forma de Pagamento:";
            // 
            // tblPanel1
            // 
            this.tblPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel1.ColumnCount = 5;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tblPanel1.Controls.Add(this.cbxStatus, 3, 1);
            this.tblPanel1.Controls.Add(this.lblStatus, 3, 0);
            this.tblPanel1.Controls.Add(this.mtbIdCliente, 1, 1);
            this.tblPanel1.Controls.Add(this.lblIdCliente, 1, 0);
            this.tblPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel1.Location = new System.Drawing.Point(4, 3);
            this.tblPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 2;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel1.Size = new System.Drawing.Size(878, 51);
            this.tblPanel1.TabIndex = 0;
            // 
            // cbxStatus
            // 
            this.cbxStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxStatus.FormattingEnabled = true;
            this.cbxStatus.Location = new System.Drawing.Point(443, 22);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(391, 28);
            this.cbxStatus.TabIndex = 37;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(443, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 19);
            this.lblStatus.TabIndex = 36;
            this.lblStatus.Text = "Status:";
            // 
            // mtbIdCliente
            // 
            this.mtbIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtbIdCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbIdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mtbIdCliente.Location = new System.Drawing.Point(44, 22);
            this.mtbIdCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mtbIdCliente.Name = "mtbIdCliente";
            this.mtbIdCliente.Size = new System.Drawing.Size(389, 20);
            this.mtbIdCliente.TabIndex = 35;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.ForeColor = System.Drawing.Color.Black;
            this.lblIdCliente.Location = new System.Drawing.Point(44, 0);
            this.lblIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(77, 19);
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
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 245);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(878, 75);
            this.tableLayoutPanel6.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(44, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtDescricao.Location = new System.Drawing.Point(44, 24);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(790, 48);
            this.txtDescricao.TabIndex = 35;
            // 
            // tabConsultarPedidos
            // 
            this.tabConsultarPedidos.Controls.Add(this.tblPanelBase);
            this.tabConsultarPedidos.Location = new System.Drawing.Point(4, 29);
            this.tabConsultarPedidos.Name = "tabConsultarPedidos";
            this.tabConsultarPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultarPedidos.Size = new System.Drawing.Size(885, 428);
            this.tabConsultarPedidos.TabIndex = 1;
            this.tabConsultarPedidos.Text = "Consulta Pedidos";
            this.tabConsultarPedidos.UseVisualStyleBackColor = true;
            // 
            // tblPanelBase
            // 
            this.tblPanelBase.BackgroundImage = global::Daycake.Properties.Resources.FundoPag_2;
            this.tblPanelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblPanelBase.ColumnCount = 3;
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblPanelBase.Controls.Add(this.btnExcluirPedido, 1, 3);
            this.tblPanelBase.Controls.Add(this.lstListaPedidos, 1, 2);
            this.tblPanelBase.Controls.Add(this.tableLayoutPanel7, 1, 1);
            this.tblPanelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelBase.Location = new System.Drawing.Point(3, 3);
            this.tblPanelBase.Name = "tblPanelBase";
            this.tblPanelBase.RowCount = 4;
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tblPanelBase.Size = new System.Drawing.Size(879, 422);
            this.tblPanelBase.TabIndex = 2;
            // 
            // btnExcluirPedido
            // 
            this.btnExcluirPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluirPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnExcluirPedido.Location = new System.Drawing.Point(43, 387);
            this.btnExcluirPedido.Name = "btnExcluirPedido";
            this.btnExcluirPedido.Size = new System.Drawing.Size(793, 32);
            this.btnExcluirPedido.TabIndex = 5;
            this.btnExcluirPedido.Text = "Excluir";
            this.btnExcluirPedido.UseVisualStyleBackColor = true;
            this.btnExcluirPedido.Visible = false;
            this.btnExcluirPedido.Click += new System.EventHandler(this.excluirPedidosToolStripMenuItem_Click);
            // 
            // lstListaPedidos
            // 
            this.lstListaPedidos.BackColor = System.Drawing.Color.White;
            this.lstListaPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstListaPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstListaPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lstListaPedidos.FullRowSelect = true;
            this.lstListaPedidos.HideSelection = false;
            this.lstListaPedidos.Location = new System.Drawing.Point(43, 83);
            this.lstListaPedidos.MultiSelect = false;
            this.lstListaPedidos.Name = "lstListaPedidos";
            this.lstListaPedidos.Size = new System.Drawing.Size(793, 298);
            this.lstListaPedidos.TabIndex = 1;
            this.lstListaPedidos.UseCompatibleStateImageBehavior = false;
            this.lstListaPedidos.View = System.Windows.Forms.View.Details;
            this.lstListaPedidos.SelectedIndexChanged += new System.EventHandler(this.lstListaPedidos_SelectedIndexChanged);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.51402F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.485981F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel7.Controls.Add(this.btnBuscarPedidos, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.txtBuscarPedidos, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblBuscarPedidos, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(43, 13);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(793, 64);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // btnBuscarPedidos
            // 
            this.btnBuscarPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnBuscarPedidos.Location = new System.Drawing.Point(693, 26);
            this.btnBuscarPedidos.Name = "btnBuscarPedidos";
            this.btnBuscarPedidos.Size = new System.Drawing.Size(97, 29);
            this.btnBuscarPedidos.TabIndex = 6;
            this.btnBuscarPedidos.Text = "Buscar";
            this.btnBuscarPedidos.UseVisualStyleBackColor = true;
            this.btnBuscarPedidos.Click += new System.EventHandler(this.btnBuscarPedidos_Click_1);
            // 
            // txtBuscarPedidos
            // 
            this.txtBuscarPedidos.BackColor = System.Drawing.Color.White;
            this.txtBuscarPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtBuscarPedidos.Location = new System.Drawing.Point(3, 26);
            this.txtBuscarPedidos.Name = "txtBuscarPedidos";
            this.txtBuscarPedidos.Size = new System.Drawing.Size(611, 20);
            this.txtBuscarPedidos.TabIndex = 5;
            // 
            // lblBuscarPedidos
            // 
            this.lblBuscarPedidos.AutoSize = true;
            this.lblBuscarPedidos.ForeColor = System.Drawing.Color.Black;
            this.lblBuscarPedidos.Location = new System.Drawing.Point(3, 0);
            this.lblBuscarPedidos.Name = "lblBuscarPedidos";
            this.lblBuscarPedidos.Size = new System.Drawing.Size(133, 20);
            this.lblBuscarPedidos.TabIndex = 4;
            this.lblBuscarPedidos.Text = "Digite a sua busca:";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excluirPedidosToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(122, 28);
            // 
            // excluirPedidosToolStripMenuItem
            // 
            this.excluirPedidosToolStripMenuItem.Name = "excluirPedidosToolStripMenuItem";
            this.excluirPedidosToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.excluirPedidosToolStripMenuItem.Text = "Excluir";
            this.excluirPedidosToolStripMenuItem.Click += new System.EventHandler(this.excluirPedidosToolStripMenuItem_Click);
            // 
            // FormPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 461);
            this.Controls.Add(this.tabControlPedidos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FormPedido_Load);
            this.tabControlPedidos.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            this.tblPanel5.ResumeLayout(false);
            this.tblPanel6.ResumeLayout(false);
            this.tblPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPedidos;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.TableLayoutPanel tblPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTipoDoce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ListView lstTipoDoce;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.MaskedTextBox mtbDataEntrega;
        private System.Windows.Forms.Label lblDataEntrega;
        private System.Windows.Forms.MaskedTextBox mtbDataPedido;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.TableLayoutPanel tblPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.MaskedTextBox mtbIdCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TabPage tabConsultarPedidos;
        private System.Windows.Forms.TableLayoutPanel tblPanelBase;
        private System.Windows.Forms.Button btnExcluirPedido;
        private System.Windows.Forms.ListView lstListaPedidos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnBuscarPedidos;
        private System.Windows.Forms.TextBox txtBuscarPedidos;
        private System.Windows.Forms.Label lblBuscarPedidos;
        private System.Windows.Forms.ComboBox cbxFormaPagamento;
        private System.Windows.Forms.ComboBox cbxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbxTipoDoce;
        private System.Windows.Forms.TableLayoutPanel tblPanel6;
        private System.Windows.Forms.Button btnAtualizarCliente;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnFazerPedido;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem excluirPedidosToolStripMenuItem;
    }
}