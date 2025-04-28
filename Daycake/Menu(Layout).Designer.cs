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
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsCliente
            // 
            this.mnsCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastro,
            this.mnsClientes});
            this.mnsCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsCliente.Name = "mnsCliente";
            this.mnsCliente.Size = new System.Drawing.Size(56, 20);
            this.mnsCliente.Text = "Cliente";
            // 
            // mnsCadastro
            // 
            this.mnsCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsCadastro.Name = "mnsCadastro";
            this.mnsCadastro.Size = new System.Drawing.Size(180, 22);
            this.mnsCadastro.Text = "Cadastro";
            this.mnsCadastro.Click += new System.EventHandler(this.mnsCadastro_Click);
            // 
            // mnsClientes
            // 
            this.mnsClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsClientes.Name = "mnsClientes";
            this.mnsClientes.Size = new System.Drawing.Size(180, 22);
            this.mnsClientes.Text = "Clientes";
            this.mnsClientes.Click += new System.EventHandler(this.mnsClientes_Click_1);
            // 
            // mnsPedidos
            // 
            this.mnsPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAgendarPedido,
            this.mnsConsultarPedidos,
            this.mnsRecebimentos});
            this.mnsPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsPedidos.Name = "mnsPedidos";
            this.mnsPedidos.Size = new System.Drawing.Size(61, 20);
            this.mnsPedidos.Text = "Pedidos";
            // 
            // mnsAgendarPedido
            // 
            this.mnsAgendarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsAgendarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsAgendarPedido.Name = "mnsAgendarPedido";
            this.mnsAgendarPedido.Size = new System.Drawing.Size(170, 22);
            this.mnsAgendarPedido.Text = "Agendar Pedido";
            this.mnsAgendarPedido.Click += new System.EventHandler(this.mnsAgendarPedido_Click);
            // 
            // mnsConsultarPedidos
            // 
            this.mnsConsultarPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsConsultarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsConsultarPedidos.Name = "mnsConsultarPedidos";
            this.mnsConsultarPedidos.Size = new System.Drawing.Size(170, 22);
            this.mnsConsultarPedidos.Text = "Consultar Pedidos";
            this.mnsConsultarPedidos.Click += new System.EventHandler(this.mnsConsultarPedidos_Click_1);
            // 
            // mnsRecebimentos
            // 
            this.mnsRecebimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsRecebimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
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
            this.mnsProducao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsProducao.Name = "mnsProducao";
            this.mnsProducao.Size = new System.Drawing.Size(70, 20);
            this.mnsProducao.Text = "Produção";
            // 
            // mnsAdicionarProduto
            // 
            this.mnsAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsAdicionarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsAdicionarProduto.Name = "mnsAdicionarProduto";
            this.mnsAdicionarProduto.Size = new System.Drawing.Size(171, 22);
            this.mnsAdicionarProduto.Text = "Adicionar Produto";
            this.mnsAdicionarProduto.Click += new System.EventHandler(this.mnsAdicionarProduto_Click);
            // 
            // mnsListaProdutos
            // 
            this.mnsListaProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsListaProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsListaProdutos.Name = "mnsListaProdutos";
            this.mnsListaProdutos.Size = new System.Drawing.Size(171, 22);
            this.mnsListaProdutos.Text = "Lista Produtos";
            this.mnsListaProdutos.Click += new System.EventHandler(this.mnsListaProdutos_Click_1);
            // 
            // mnsStatus
            // 
            this.mnsStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsStatus.Name = "mnsStatus";
            this.mnsStatus.Size = new System.Drawing.Size(171, 22);
            this.mnsStatus.Text = "Status";
            // 
            // mnsSair
            // 
            this.mnsSair.ForeColor = System.Drawing.Color.IndianRed;
            this.mnsSair.Name = "mnsSair";
            this.mnsSair.Size = new System.Drawing.Size(38, 20);
            this.mnsSair.Text = "Sair";
            this.mnsSair.Click += new System.EventHandler(this.mnsSair_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCliente,
            this.mnsPedidos,
            this.mnsProducao,
            this.mnsSair});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(811, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // picMenu
            // 
            this.picMenu.BackgroundImage = global::Daycake.Properties.Resources.Fundo_login;
            this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMenu.Location = new System.Drawing.Point(0, 24);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(811, 485);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(811, 509);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Segoe Fluent Icons", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.mnsMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.White;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
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