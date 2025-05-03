namespace Daycake
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.tabControlProdutos = new System.Windows.Forms.TabControl();
            this.tabCadastroProdutos = new System.Windows.Forms.TabPage();
            this.tblPanelBaseProduto = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.tblPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.tblPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.tblPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mtbIdProduto = new System.Windows.Forms.MaskedTextBox();
            this.mtbPreco = new System.Windows.Forms.MaskedTextBox();
            this.lblIdProduto = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.tblPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.mtbTempoPreparo = new System.Windows.Forms.MaskedTextBox();
            this.lblTempoPreparo = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblAtivoInativo = new System.Windows.Forms.Label();
            this.cbxAtivoInativo = new System.Windows.Forms.ComboBox();
            this.tabConsultaProdutos = new System.Windows.Forms.TabPage();
            this.tblPanelBase = new System.Windows.Forms.TableLayoutPanel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lstListaProdutos = new System.Windows.Forms.ListView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tabControlProdutos.SuspendLayout();
            this.tabCadastroProdutos.SuspendLayout();
            this.tblPanelBaseProduto.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblPanel3.SuspendLayout();
            this.tblPanel2.SuspendLayout();
            this.tblPanel1.SuspendLayout();
            this.tblPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabConsultaProdutos.SuspendLayout();
            this.tblPanelBase.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProdutos
            // 
            this.tabControlProdutos.Controls.Add(this.tabCadastroProdutos);
            this.tabControlProdutos.Controls.Add(this.tabConsultaProdutos);
            this.tabControlProdutos.Location = new System.Drawing.Point(1, -1);
            this.tabControlProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlProdutos.Name = "tabControlProdutos";
            this.tabControlProdutos.SelectedIndex = 0;
            this.tabControlProdutos.Size = new System.Drawing.Size(1068, 556);
            this.tabControlProdutos.TabIndex = 0;
            // 
            // tabCadastroProdutos
            // 
            this.tabCadastroProdutos.Controls.Add(this.tblPanelBaseProduto);
            this.tabCadastroProdutos.Location = new System.Drawing.Point(4, 25);
            this.tabCadastroProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.tabCadastroProdutos.Name = "tabCadastroProdutos";
            this.tabCadastroProdutos.Padding = new System.Windows.Forms.Padding(4);
            this.tabCadastroProdutos.Size = new System.Drawing.Size(1060, 527);
            this.tabCadastroProdutos.TabIndex = 0;
            this.tabCadastroProdutos.Text = "Cadastro Produto";
            this.tabCadastroProdutos.UseVisualStyleBackColor = true;
            // 
            // tblPanelBaseProduto
            // 
            this.tblPanelBaseProduto.BackColor = System.Drawing.Color.Transparent;
            this.tblPanelBaseProduto.BackgroundImage = global::Daycake.Properties.Resources.FundoPag_21;
            this.tblPanelBaseProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblPanelBaseProduto.ColumnCount = 1;
            this.tblPanelBaseProduto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBaseProduto.Controls.Add(this.tableLayoutPanel1, 0, 7);
            this.tblPanelBaseProduto.Controls.Add(this.tblPanel3, 0, 3);
            this.tblPanelBaseProduto.Controls.Add(this.tblPanel2, 0, 2);
            this.tblPanelBaseProduto.Controls.Add(this.tblPanel1, 0, 1);
            this.tblPanelBaseProduto.Controls.Add(this.tblPanel4, 0, 5);
            this.tblPanelBaseProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanelBaseProduto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tblPanelBaseProduto.Location = new System.Drawing.Point(4, 4);
            this.tblPanelBaseProduto.Margin = new System.Windows.Forms.Padding(4);
            this.tblPanelBaseProduto.Name = "tblPanelBaseProduto";
            this.tblPanelBaseProduto.RowCount = 9;
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.57548F));
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.87441F));
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.23047F));
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.583801F));
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.90536F));
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.83049F));
            this.tblPanelBaseProduto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tblPanelBaseProduto.Size = new System.Drawing.Size(1052, 519);
            this.tblPanelBaseProduto.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.btnAdicionarProduto, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnVoltar, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 445);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1044, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdicionarProduto.AutoSize = true;
            this.btnAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.btnAdicionarProduto.Location = new System.Drawing.Point(798, 4);
            this.btnAdicionarProduto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(189, 34);
            this.btnAdicionarProduto.TabIndex = 39;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarProduto.UseVisualStyleBackColor = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVoltar.AutoSize = true;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnVoltar.Location = new System.Drawing.Point(57, 4);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 34);
            this.btnVoltar.TabIndex = 38;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnVoltar.UseVisualStyleBackColor = false;
            // 
            // tblPanel3
            // 
            this.tblPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel3.ColumnCount = 3;
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanel3.Controls.Add(this.txtDescricao, 1, 1);
            this.tblPanel3.Controls.Add(this.lblDescricao, 1, 0);
            this.tblPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel3.Location = new System.Drawing.Point(4, 194);
            this.tblPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tblPanel3.Name = "tblPanel3";
            this.tblPanel3.RowCount = 2;
            this.tblPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.71429F));
            this.tblPanel3.Size = new System.Drawing.Size(1044, 133);
            this.tblPanel3.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtDescricao.Location = new System.Drawing.Point(57, 22);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(930, 107);
            this.txtDescricao.TabIndex = 34;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.ForeColor = System.Drawing.Color.Black;
            this.lblDescricao.Location = new System.Drawing.Point(57, 0);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(77, 18);
            this.lblDescricao.TabIndex = 33;
            this.lblDescricao.Text = "Descrição:";
            // 
            // tblPanel2
            // 
            this.tblPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel2.ColumnCount = 3;
            this.tblPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanel2.Controls.Add(this.txtNomeProduto, 1, 1);
            this.tblPanel2.Controls.Add(this.lblNomeProduto, 1, 0);
            this.tblPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel2.Location = new System.Drawing.Point(4, 111);
            this.tblPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tblPanel2.Name = "tblPanel2";
            this.tblPanel2.RowCount = 2;
            this.tblPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblPanel2.Size = new System.Drawing.Size(1044, 75);
            this.tblPanel2.TabIndex = 1;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNomeProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtNomeProduto.Location = new System.Drawing.Point(57, 34);
            this.txtNomeProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(930, 27);
            this.txtNomeProduto.TabIndex = 35;
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.ForeColor = System.Drawing.Color.Black;
            this.lblNomeProduto.Location = new System.Drawing.Point(57, 0);
            this.lblNomeProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(110, 20);
            this.lblNomeProduto.TabIndex = 34;
            this.lblNomeProduto.Text = "Nome Produto:";
            // 
            // tblPanel1
            // 
            this.tblPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tblPanel1.ColumnCount = 5;
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblPanel1.Controls.Add(this.mtbIdProduto, 1, 1);
            this.tblPanel1.Controls.Add(this.mtbPreco, 3, 1);
            this.tblPanel1.Controls.Add(this.lblIdProduto, 1, 0);
            this.tblPanel1.Controls.Add(this.lblPreco, 3, 0);
            this.tblPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel1.Location = new System.Drawing.Point(4, 29);
            this.tblPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tblPanel1.Name = "tblPanel1";
            this.tblPanel1.RowCount = 2;
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblPanel1.Size = new System.Drawing.Size(1044, 74);
            this.tblPanel1.TabIndex = 0;
            // 
            // mtbIdProduto
            // 
            this.mtbIdProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbIdProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mtbIdProduto.Location = new System.Drawing.Point(57, 33);
            this.mtbIdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.mtbIdProduto.Name = "mtbIdProduto";
            this.mtbIdProduto.Size = new System.Drawing.Size(444, 27);
            this.mtbIdProduto.TabIndex = 33;
            // 
            // mtbPreco
            // 
            this.mtbPreco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbPreco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mtbPreco.Location = new System.Drawing.Point(540, 33);
            this.mtbPreco.Margin = new System.Windows.Forms.Padding(4);
            this.mtbPreco.Name = "mtbPreco";
            this.mtbPreco.Size = new System.Drawing.Size(444, 27);
            this.mtbPreco.TabIndex = 32;
            // 
            // lblIdProduto
            // 
            this.lblIdProduto.AutoSize = true;
            this.lblIdProduto.ForeColor = System.Drawing.Color.Black;
            this.lblIdProduto.Location = new System.Drawing.Point(57, 0);
            this.lblIdProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProduto.Name = "lblIdProduto";
            this.lblIdProduto.Size = new System.Drawing.Size(84, 20);
            this.lblIdProduto.TabIndex = 31;
            this.lblIdProduto.Text = "ID Produto:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.ForeColor = System.Drawing.Color.Black;
            this.lblPreco.Location = new System.Drawing.Point(540, 0);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(49, 20);
            this.lblPreco.TabIndex = 30;
            this.lblPreco.Text = "Preço:";
            // 
            // tblPanel4
            // 
            this.tblPanel4.ColumnCount = 5;
            this.tblPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tblPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 431F));
            this.tblPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanel4.Controls.Add(this.tableLayoutPanel5, 3, 0);
            this.tblPanel4.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tblPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel4.Location = new System.Drawing.Point(4, 347);
            this.tblPanel4.Margin = new System.Windows.Forms.Padding(4);
            this.tblPanel4.Name = "tblPanel4";
            this.tblPanel4.RowCount = 1;
            this.tblPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanel4.Size = new System.Drawing.Size(1044, 90);
            this.tblPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.mtbTempoPreparo, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblTempoPreparo, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(564, 4);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(423, 82);
            this.tableLayoutPanel5.TabIndex = 38;
            // 
            // mtbTempoPreparo
            // 
            this.mtbTempoPreparo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtbTempoPreparo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mtbTempoPreparo.Location = new System.Drawing.Point(4, 36);
            this.mtbTempoPreparo.Margin = new System.Windows.Forms.Padding(4);
            this.mtbTempoPreparo.Mask = "00:00";
            this.mtbTempoPreparo.Name = "mtbTempoPreparo";
            this.mtbTempoPreparo.Size = new System.Drawing.Size(415, 27);
            this.mtbTempoPreparo.TabIndex = 36;
            this.mtbTempoPreparo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTempoPreparo
            // 
            this.lblTempoPreparo.AutoSize = true;
            this.lblTempoPreparo.ForeColor = System.Drawing.Color.Black;
            this.lblTempoPreparo.Location = new System.Drawing.Point(4, 0);
            this.lblTempoPreparo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempoPreparo.Name = "lblTempoPreparo";
            this.lblTempoPreparo.Size = new System.Drawing.Size(135, 20);
            this.lblTempoPreparo.TabIndex = 35;
            this.lblTempoPreparo.Text = "Tempo de Preparo:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblAtivoInativo, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbxAtivoInativo, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(56, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 85);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // lblAtivoInativo
            // 
            this.lblAtivoInativo.AutoSize = true;
            this.lblAtivoInativo.ForeColor = System.Drawing.Color.Black;
            this.lblAtivoInativo.Location = new System.Drawing.Point(4, 0);
            this.lblAtivoInativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtivoInativo.Name = "lblAtivoInativo";
            this.lblAtivoInativo.Size = new System.Drawing.Size(98, 20);
            this.lblAtivoInativo.TabIndex = 36;
            this.lblAtivoInativo.Text = "Ativo/Inativo:";
            // 
            // cbxAtivoInativo
            // 
            this.cbxAtivoInativo.FormattingEnabled = true;
            this.cbxAtivoInativo.Location = new System.Drawing.Point(4, 30);
            this.cbxAtivoInativo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAtivoInativo.Name = "cbxAtivoInativo";
            this.cbxAtivoInativo.Size = new System.Drawing.Size(369, 28);
            this.cbxAtivoInativo.TabIndex = 37;
            // 
            // tabConsultaProdutos
            // 
            this.tabConsultaProdutos.Controls.Add(this.tblPanelBase);
            this.tabConsultaProdutos.Location = new System.Drawing.Point(4, 25);
            this.tabConsultaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.tabConsultaProdutos.Name = "tabConsultaProdutos";
            this.tabConsultaProdutos.Padding = new System.Windows.Forms.Padding(4);
            this.tabConsultaProdutos.Size = new System.Drawing.Size(1060, 527);
            this.tabConsultaProdutos.TabIndex = 1;
            this.tabConsultaProdutos.Text = "Consulta Produtos";
            this.tabConsultaProdutos.UseVisualStyleBackColor = true;
            // 
            // tblPanelBase
            // 
            this.tblPanelBase.BackgroundImage = global::Daycake.Properties.Resources.FundoPag_21;
            this.tblPanelBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblPanelBase.ColumnCount = 3;
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tblPanelBase.Controls.Add(this.btnExcluir, 1, 3);
            this.tblPanelBase.Controls.Add(this.lstListaProdutos, 1, 2);
            this.tblPanelBase.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tblPanelBase.Location = new System.Drawing.Point(-31, 0);
            this.tblPanelBase.Margin = new System.Windows.Forms.Padding(4);
            this.tblPanelBase.Name = "tblPanelBase";
            this.tblPanelBase.RowCount = 4;
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPanelBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblPanelBase.Size = new System.Drawing.Size(1119, 524);
            this.tblPanelBase.TabIndex = 2;
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(57, 481);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(1004, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // lstListaProdutos
            // 
            this.lstListaProdutos.BackColor = System.Drawing.Color.White;
            this.lstListaProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.lstListaProdutos.HideSelection = false;
            this.lstListaProdutos.Location = new System.Drawing.Point(57, 102);
            this.lstListaProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.lstListaProdutos.Name = "lstListaProdutos";
            this.lstListaProdutos.Size = new System.Drawing.Size(1003, 352);
            this.lstListaProdutos.TabIndex = 1;
            this.lstListaProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.51402F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.485981F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel3.Controls.Add(this.btnBuscar, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtBuscar, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblBuscar, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(57, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1004, 66);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.btnBuscar.Location = new System.Drawing.Point(871, 28);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtBuscar.Location = new System.Drawing.Point(4, 28);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(792, 22);
            this.txtBuscar.TabIndex = 5;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblBuscar.Location = new System.Drawing.Point(4, 0);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(121, 16);
            this.lblBuscar.TabIndex = 4;
            this.lblBuscar.Text = "Digite a sua busca:";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControlProdutos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.tabControlProdutos.ResumeLayout(false);
            this.tabCadastroProdutos.ResumeLayout(false);
            this.tblPanelBaseProduto.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblPanel3.ResumeLayout(false);
            this.tblPanel3.PerformLayout();
            this.tblPanel2.ResumeLayout(false);
            this.tblPanel2.PerformLayout();
            this.tblPanel1.ResumeLayout(false);
            this.tblPanel1.PerformLayout();
            this.tblPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabConsultaProdutos.ResumeLayout(false);
            this.tblPanelBase.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProdutos;
        private System.Windows.Forms.TabPage tabCadastroProdutos;
        private System.Windows.Forms.TableLayoutPanel tblPanelBaseProduto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TableLayoutPanel tblPanel3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TableLayoutPanel tblPanel2;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.TableLayoutPanel tblPanel1;
        private System.Windows.Forms.MaskedTextBox mtbIdProduto;
        private System.Windows.Forms.MaskedTextBox mtbPreco;
        private System.Windows.Forms.Label lblIdProduto;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TableLayoutPanel tblPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.MaskedTextBox mtbTempoPreparo;
        private System.Windows.Forms.Label lblTempoPreparo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblAtivoInativo;
        private System.Windows.Forms.ComboBox cbxAtivoInativo;
        private System.Windows.Forms.TabPage tabConsultaProdutos;
        private System.Windows.Forms.TableLayoutPanel tblPanelBase;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ListView lstListaProdutos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}