namespace Daycake
{
    partial class Menu
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
            this.picMenu = new System.Windows.Forms.PictureBox();
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
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picMenu
            // 
            this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMenu.Location = new System.Drawing.Point(0, 28);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(1215, 686);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            // 
            // mnsCliente
            // 
            this.mnsCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastro,
            this.mnsClientes});
            this.mnsCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsCliente.Name = "mnsCliente";
            this.mnsCliente.Size = new System.Drawing.Size(69, 24);
            this.mnsCliente.Text = "Cliente";
            // 
            // mnsCadastro
            // 
            this.mnsCadastro.Name = "mnsCadastro";
            this.mnsCadastro.Size = new System.Drawing.Size(151, 26);
            this.mnsCadastro.Text = "Cadastro";
            this.mnsCadastro.Click += new System.EventHandler(this.mnsCadastro_Click);
            // 
            // mnsClientes
            // 
            this.mnsClientes.Name = "mnsClientes";
            this.mnsClientes.Size = new System.Drawing.Size(151, 26);
            this.mnsClientes.Text = "Clientes";
            // 
            // mnsPedidos
            // 
            this.mnsPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAgendarPedido,
            this.mnsConsultarPedidos,
            this.mnsRecebimentos});
            this.mnsPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsPedidos.Name = "mnsPedidos";
            this.mnsPedidos.Size = new System.Drawing.Size(75, 24);
            this.mnsPedidos.Text = "Pedidos";
            // 
            // mnsAgendarPedido
            // 
            this.mnsAgendarPedido.Name = "mnsAgendarPedido";
            this.mnsAgendarPedido.Size = new System.Drawing.Size(210, 26);
            this.mnsAgendarPedido.Text = "Agendar Pedido";
            this.mnsAgendarPedido.Click += new System.EventHandler(this.mnsAgendarPedido_Click);
            // 
            // mnsConsultarPedidos
            // 
            this.mnsConsultarPedidos.Name = "mnsConsultarPedidos";
            this.mnsConsultarPedidos.Size = new System.Drawing.Size(210, 26);
            this.mnsConsultarPedidos.Text = "Consultar Pedidos";
            // 
            // mnsRecebimentos
            // 
            this.mnsRecebimentos.Name = "mnsRecebimentos";
            this.mnsRecebimentos.Size = new System.Drawing.Size(210, 26);
            this.mnsRecebimentos.Text = "Recebimentos";
            // 
            // mnsProducao
            // 
            this.mnsProducao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAdicionarProduto,
            this.mnsListaProdutos,
            this.mnsStatus});
            this.mnsProducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsProducao.Name = "mnsProducao";
            this.mnsProducao.Size = new System.Drawing.Size(86, 24);
            this.mnsProducao.Text = "Produção";
            // 
            // mnsAdicionarProduto
            // 
            this.mnsAdicionarProduto.Name = "mnsAdicionarProduto";
            this.mnsAdicionarProduto.Size = new System.Drawing.Size(213, 26);
            this.mnsAdicionarProduto.Text = "Adicionar Produto";
            this.mnsAdicionarProduto.Click += new System.EventHandler(this.mnsAdicionarProduto_Click);
            // 
            // mnsListaProdutos
            // 
            this.mnsListaProdutos.Name = "mnsListaProdutos";
            this.mnsListaProdutos.Size = new System.Drawing.Size(213, 26);
            this.mnsListaProdutos.Text = "Lista Produtos";
            // 
            // mnsStatus
            // 
            this.mnsStatus.Name = "mnsStatus";
            this.mnsStatus.Size = new System.Drawing.Size(213, 26);
            this.mnsStatus.Text = "Status";
            // 
            // mnsSair
            // 
            this.mnsSair.ForeColor = System.Drawing.Color.IndianRed;
            this.mnsSair.Name = "mnsSair";
            this.mnsSair.Size = new System.Drawing.Size(48, 24);
            this.mnsSair.Text = "Sair";
            this.mnsSair.Click += new System.EventHandler(this.mnsSair_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.Color.White;
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCliente,
            this.mnsPedidos,
            this.mnsProducao,
            this.mnsSair});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(1215, 28);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1215, 714);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnsMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.ToolStripMenuItem mnsCliente;
        private System.Windows.Forms.ToolStripMenuItem mnsCadastro;
        private System.Windows.Forms.ToolStripMenuItem mnsClientes;
        private System.Windows.Forms.ToolStripMenuItem mnsPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnsAgendarPedido;
        private System.Windows.Forms.ToolStripMenuItem mnsConsultarPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnsRecebimentos;
        private System.Windows.Forms.ToolStripMenuItem mnsProducao;
        private System.Windows.Forms.ToolStripMenuItem mnsAdicionarProduto;
        private System.Windows.Forms.ToolStripMenuItem mnsListaProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnsStatus;
        private System.Windows.Forms.ToolStripMenuItem mnsSair;
        private System.Windows.Forms.MenuStrip mnsMenu;
    }
}