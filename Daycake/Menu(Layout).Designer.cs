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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.mnsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAgendarPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRecebimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsProducao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAdicionarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.statusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsCliente
            // 
            this.mnsCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastro});
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
            // mnsPedidos
            // 
            this.mnsPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAgendarPedido,
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
            this.mnsAgendarPedido.Size = new System.Drawing.Size(159, 22);
            this.mnsAgendarPedido.Text = "Agendar Pedido";
            this.mnsAgendarPedido.Click += new System.EventHandler(this.mnsAgendarPedido_Click);
            // 
            // mnsRecebimentos
            // 
            this.mnsRecebimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsRecebimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsRecebimentos.Name = "mnsRecebimentos";
            this.mnsRecebimentos.Size = new System.Drawing.Size(159, 22);
            this.mnsRecebimentos.Text = "Recebimentos";
            this.mnsRecebimentos.Click += new System.EventHandler(this.mnsRecebimentos_Click_1);
            // 
            // mnsProducao
            // 
            this.mnsProducao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAdicionarProduto});
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
            this.mnsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCliente,
            this.mnsPedidos,
            this.mnsProducao,
            this.statusToolStripMenuItem,
            this.mnsSair});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(811, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // picMenu
            // 
            this.picMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picMenu.BackgroundImage = global::Daycake.Properties.Resources.Fundo_login__1_;
            this.picMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMenu.Cursor = System.Windows.Forms.Cursors.No;
            this.picMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picMenu.InitialImage = global::Daycake.Properties.Resources.Daycake;
            this.picMenu.Location = new System.Drawing.Point(0, 24);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(811, 485);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenu.TabIndex = 1;
            this.picMenu.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(811, 509);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TransparencyKey = System.Drawing.Color.White;
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
        private System.Windows.Forms.ToolStripMenuItem mnsPedidos;
        private System.Windows.Forms.ToolStripMenuItem mnsAgendarPedido;
        private System.Windows.Forms.ToolStripMenuItem mnsRecebimentos;
        private System.Windows.Forms.ToolStripMenuItem mnsProducao;
        private System.Windows.Forms.ToolStripMenuItem mnsAdicionarProduto;
        private System.Windows.Forms.ToolStripMenuItem mnsSair;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem statusToolStripMenuItem;
    }
}