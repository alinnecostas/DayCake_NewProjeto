namespace Daycake
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAgendarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsConsultarPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRecebimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsProducao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAdicionarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsListaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCliente,
            this.mnsPedidos,
            this.mnsProducao,
            this.mnsSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsCliente
            // 
            this.mnsCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastro,
            this.mnsClientes});
            this.mnsCliente.Name = "mnsCliente";
            this.mnsCliente.Size = new System.Drawing.Size(56, 20);
            this.mnsCliente.Text = "Cliente";
            // 
            // mnsCadastro
            // 
            this.mnsCadastro.Name = "mnsCadastro";
            this.mnsCadastro.Size = new System.Drawing.Size(121, 22);
            this.mnsCadastro.Text = "Cadastro";
            this.mnsCadastro.Click += new System.EventHandler(this.mnsCadastro_Click);
            // 
            // mnsClientes
            // 
            this.mnsClientes.Name = "mnsClientes";
            this.mnsClientes.Size = new System.Drawing.Size(121, 22);
            this.mnsClientes.Text = "Clientes";
            this.mnsClientes.Click += new System.EventHandler(this.mnsClientes_Click);
            // 
            // mnsPedidos
            // 
            this.mnsPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAgendarPedido,
            this.mnsConsultarPedidos,
            this.mnsRecebimentos});
            this.mnsPedidos.Name = "mnsPedidos";
            this.mnsPedidos.Size = new System.Drawing.Size(61, 20);
            this.mnsPedidos.Text = "Pedidos";
            // 
            // mnsAgendarPedido
            // 
            this.mnsAgendarPedido.Name = "mnsAgendarPedido";
            this.mnsAgendarPedido.Size = new System.Drawing.Size(170, 22);
            this.mnsAgendarPedido.Text = "Agendar Pedido";
            this.mnsAgendarPedido.Click += new System.EventHandler(this.mnsAgendarPedido_Click);
            // 
            // mnsConsultarPedidos
            // 
            this.mnsConsultarPedidos.Name = "mnsConsultarPedidos";
            this.mnsConsultarPedidos.Size = new System.Drawing.Size(170, 22);
            this.mnsConsultarPedidos.Text = "Consultar Pedidos";
            this.mnsConsultarPedidos.Click += new System.EventHandler(this.mnsConsultarPedidos_Click);
            // 
            // mnsRecebimentos
            // 
            this.mnsRecebimentos.Name = "mnsRecebimentos";
            this.mnsRecebimentos.Size = new System.Drawing.Size(170, 22);
            this.mnsRecebimentos.Text = "Recebimentos";
            // 
            // mnsProducao
            // 
            this.mnsProducao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAdicionarProduto,
            this.mnsListaProdutos,
            this.mnsStatus});
            this.mnsProducao.Name = "mnsProducao";
            this.mnsProducao.Size = new System.Drawing.Size(70, 20);
            this.mnsProducao.Text = "Produção";
            // 
            // mnsAdicionarProduto
            // 
            this.mnsAdicionarProduto.Name = "mnsAdicionarProduto";
            this.mnsAdicionarProduto.Size = new System.Drawing.Size(180, 22);
            this.mnsAdicionarProduto.Text = "Adicionar Produto";
            this.mnsAdicionarProduto.Click += new System.EventHandler(this.mnsAdicionarProduto_Click);
            // 
            // mnsListaProdutos
            // 
            this.mnsListaProdutos.Name = "mnsListaProdutos";
            this.mnsListaProdutos.Size = new System.Drawing.Size(180, 22);
            this.mnsListaProdutos.Text = "Lista Produtos";
            this.mnsListaProdutos.Click += new System.EventHandler(this.mnsListaProdutos_Click);
            // 
            // mnsStatus
            // 
            this.mnsStatus.Name = "mnsStatus";
            this.mnsStatus.Size = new System.Drawing.Size(180, 22);
            this.mnsStatus.Text = "Status";
            // 
            // mnsSair
            // 
            this.mnsSair.Name = "mnsSair";
            this.mnsSair.Size = new System.Drawing.Size(38, 20);
            this.mnsSair.Text = "Sair";
            this.mnsSair.Click += new System.EventHandler(this.mnsSair_Click);
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 24);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(672, 426);
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsCliente;
        private System.Windows.Forms.ToolStripMenuItem mnsPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnsSair;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.ToolStripMenuItem mnsCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnsClientes;
        private System.Windows.Forms.ToolStripMenuItem mnsAgendarPedido;
        private System.Windows.Forms.ToolStripMenuItem mnsConsultarPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnsRecebimentos;
        private System.Windows.Forms.ToolStripMenuItem mnsProducao;
        private System.Windows.Forms.ToolStripMenuItem mnsAdicionarProduto;
        private System.Windows.Forms.ToolStripMenuItem mnsListaProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnsStatus;
    }
}