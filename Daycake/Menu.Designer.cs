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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRecebimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsConsultaAgendamentos = new System.Windows.Forms.ToolStripMenuItem();
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
            this.mnsCadastroCliente,
            this.mnsAgendamentos,
            this.mnsConsultaAgendamentos,
            this.mnsConsultaClientes,
            this.mnsRecebimentos,
            this.mnsStatus,
            this.mnsSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsCadastroCliente
            // 
            this.mnsCadastroCliente.Name = "mnsCadastroCliente";
            this.mnsCadastroCliente.Size = new System.Drawing.Size(106, 20);
            this.mnsCadastroCliente.Text = "Cadastro Cliente";
            // 
            // mnsAgendamentos
            // 
            this.mnsAgendamentos.Name = "mnsAgendamentos";
            this.mnsAgendamentos.Size = new System.Drawing.Size(100, 20);
            this.mnsAgendamentos.Text = "Agendamentos";
            // 
            // mnsRecebimentos
            // 
            this.mnsRecebimentos.Name = "mnsRecebimentos";
            this.mnsRecebimentos.Size = new System.Drawing.Size(94, 20);
            this.mnsRecebimentos.Text = "Recebimentos";
            // 
            // mnsConsultaClientes
            // 
            this.mnsConsultaClientes.Name = "mnsConsultaClientes";
            this.mnsConsultaClientes.Size = new System.Drawing.Size(111, 20);
            this.mnsConsultaClientes.Text = "Consulta Clientes";
            // 
            // mnsConsultaAgendamentos
            // 
            this.mnsConsultaAgendamentos.Name = "mnsConsultaAgendamentos";
            this.mnsConsultaAgendamentos.Size = new System.Drawing.Size(150, 20);
            this.mnsConsultaAgendamentos.Text = "Consulta Agendamentos";
            // 
            // mnsStatus
            // 
            this.mnsStatus.Name = "mnsStatus";
            this.mnsStatus.Size = new System.Drawing.Size(51, 20);
            this.mnsStatus.Text = "Status";
            // 
            // mnsSair
            // 
            this.mnsSair.Name = "mnsSair";
            this.mnsSair.Size = new System.Drawing.Size(38, 20);
            this.mnsSair.Text = "Sair";
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImage.Location = new System.Drawing.Point(0, 24);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(800, 426);
            this.picImage.TabIndex = 1;
            this.picImage.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem mnsAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem mnsRecebimentos;
        private System.Windows.Forms.ToolStripMenuItem mnsConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem mnsConsultaAgendamentos;
        private System.Windows.Forms.ToolStripMenuItem mnsStatus;
        private System.Windows.Forms.ToolStripMenuItem mnsSair;
        private System.Windows.Forms.PictureBox picImage;
    }
}