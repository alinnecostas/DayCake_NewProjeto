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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsCliente
            // 
            this.mnsCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCadastro});
            this.mnsCliente.ForeColor = System.Drawing.Color.Black;
            this.mnsCliente.Name = "mnsCliente";
            this.mnsCliente.Size = new System.Drawing.Size(81, 24);
            this.mnsCliente.Text = "Cliente";
            // 
            // mnsCadastro
            // 
            this.mnsCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsCadastro.Name = "mnsCadastro";
            this.mnsCadastro.Size = new System.Drawing.Size(181, 30);
            this.mnsCadastro.Text = "Cadastro";
            this.mnsCadastro.Click += new System.EventHandler(this.mnsCadastro_Click);
            // 
            // mnsPedidos
            // 
            this.mnsPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAgendarPedido,
            this.mnsRecebimentos});
            this.mnsPedidos.ForeColor = System.Drawing.Color.Black;
            this.mnsPedidos.Name = "mnsPedidos";
            this.mnsPedidos.Size = new System.Drawing.Size(88, 24);
            this.mnsPedidos.Text = "Pedidos";
            // 
            // mnsAgendarPedido
            // 
            this.mnsAgendarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsAgendarPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsAgendarPedido.Name = "mnsAgendarPedido";
            this.mnsAgendarPedido.Size = new System.Drawing.Size(245, 30);
            this.mnsAgendarPedido.Text = "Agendar Pedido";
            this.mnsAgendarPedido.Click += new System.EventHandler(this.mnsAgendarPedido_Click);
            // 
            // mnsRecebimentos
            // 
            this.mnsRecebimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsRecebimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsRecebimentos.Name = "mnsRecebimentos";
            this.mnsRecebimentos.Size = new System.Drawing.Size(245, 30);
            this.mnsRecebimentos.Text = "Recebimentos";
            this.mnsRecebimentos.Click += new System.EventHandler(this.mnsRecebimentos_Click_1);
            // 
            // mnsProducao
            // 
            this.mnsProducao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAdicionarProduto});
            this.mnsProducao.ForeColor = System.Drawing.Color.Black;
            this.mnsProducao.Name = "mnsProducao";
            this.mnsProducao.Size = new System.Drawing.Size(102, 24);
            this.mnsProducao.Text = "Produção";
            // 
            // mnsAdicionarProduto
            // 
            this.mnsAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsAdicionarProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(223)))));
            this.mnsAdicionarProduto.Name = "mnsAdicionarProduto";
            this.mnsAdicionarProduto.Size = new System.Drawing.Size(263, 30);
            this.mnsAdicionarProduto.Text = "Adicionar Produto";
            this.mnsAdicionarProduto.Click += new System.EventHandler(this.mnsAdicionarProduto_Click);
            // 
            // mnsSair
            // 
            this.mnsSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.mnsSair.Name = "mnsSair";
            this.mnsSair.Size = new System.Drawing.Size(56, 24);
            this.mnsSair.Text = "Sair";
            this.mnsSair.Click += new System.EventHandler(this.mnsSair_Click);
            // 
            // mnsMenu
            // 
            this.mnsMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mnsMenu.BackColor = System.Drawing.Color.Transparent;
            this.mnsMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mnsMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mnsMenu.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCliente,
            this.mnsPedidos,
            this.mnsProducao,
            this.statusToolStripMenuItem,
            this.mnsSair});
            this.mnsMenu.Location = new System.Drawing.Point(12, 20);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(413, 28);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            this.mnsMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnsMenu_ItemClicked);
            // 
            // statusToolStripMenuItem
            // 
            this.statusToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.statusToolStripMenuItem.Name = "statusToolStripMenuItem";
            this.statusToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.statusToolStripMenuItem.Text = "Status";
            this.statusToolStripMenuItem.Click += new System.EventHandler(this.statusToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-72, -121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(434, 398);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 203);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.mnsMenu);
            this.panel2.Location = new System.Drawing.Point(317, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 59);
            this.panel2.TabIndex = 4;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Daycake.Properties.Resources.FundoPag_3_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 509);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}