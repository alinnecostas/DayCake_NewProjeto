namespace Daycake
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.picSenha = new System.Windows.Forms.PictureBox();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tlpLoginSenha = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtonAcessar = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tlpLoginSenha.SuspendLayout();
            this.tlpButtonAcessar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(209)))));
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtLogin.Location = new System.Drawing.Point(35, 4);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(216, 26);
            this.txtLogin.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(210)))), ((int)(((byte)(209)))));
            this.txtSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSenha.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(98)))), ((int)(((byte)(98)))));
            this.txtSenha.Location = new System.Drawing.Point(35, 38);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(216, 27);
            this.txtSenha.TabIndex = 4;
            // 
            // picSenha
            // 
            this.picSenha.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picSenha.BackColor = System.Drawing.Color.Transparent;
            this.picSenha.BackgroundImage = global::Daycake.Properties.Resources.senha_de_usuario;
            this.picSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSenha.Location = new System.Drawing.Point(5, 38);
            this.picSenha.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picSenha.Name = "picSenha";
            this.picSenha.Size = new System.Drawing.Size(20, 27);
            this.picSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSenha.TabIndex = 7;
            this.picSenha.TabStop = false;
            // 
            // picLogin
            // 
            this.picLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picLogin.BackColor = System.Drawing.Color.Transparent;
            this.picLogin.BackgroundImage = global::Daycake.Properties.Resources.login_de_usuario;
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogin.ErrorImage = global::Daycake.Properties.Resources.login_de_usuario;
            this.picLogin.Location = new System.Drawing.Point(5, 4);
            this.picLogin.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(20, 22);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogin.TabIndex = 6;
            this.picLogin.TabStop = false;
            // 
            // btnAcessar
            // 
            this.btnAcessar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnAcessar.BackColor = System.Drawing.Color.Transparent;
            this.btnAcessar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAcessar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAcessar.FlatAppearance.BorderSize = 0;
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcessar.ForeColor = System.Drawing.Color.Black;
            this.btnAcessar.Location = new System.Drawing.Point(4, 4);
            this.btnAcessar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAcessar.Size = new System.Drawing.Size(249, 26);
            this.btnAcessar.TabIndex = 5;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(-394, -173);
            this.picLogo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(1059, 437);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // tlpLoginSenha
            // 
            this.tlpLoginSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpLoginSenha.BackColor = System.Drawing.Color.Transparent;
            this.tlpLoginSenha.ColumnCount = 2;
            this.tlpLoginSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlpLoginSenha.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tlpLoginSenha.Controls.Add(this.picLogin, 0, 0);
            this.tlpLoginSenha.Controls.Add(this.picSenha, 0, 1);
            this.tlpLoginSenha.Controls.Add(this.txtSenha, 1, 1);
            this.tlpLoginSenha.Controls.Add(this.txtLogin, 1, 0);
            this.tlpLoginSenha.Location = new System.Drawing.Point(79, 277);
            this.tlpLoginSenha.Margin = new System.Windows.Forms.Padding(4);
            this.tlpLoginSenha.Name = "tlpLoginSenha";
            this.tlpLoginSenha.RowCount = 2;
            this.tlpLoginSenha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.61111F));
            this.tlpLoginSenha.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.38889F));
            this.tlpLoginSenha.Size = new System.Drawing.Size(257, 71);
            this.tlpLoginSenha.TabIndex = 10;
            // 
            // tlpButtonAcessar
            // 
            this.tlpButtonAcessar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpButtonAcessar.BackColor = System.Drawing.Color.Transparent;
            this.tlpButtonAcessar.ColumnCount = 1;
            this.tlpButtonAcessar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonAcessar.Controls.Add(this.btnAcessar, 0, 0);
            this.tlpButtonAcessar.Location = new System.Drawing.Point(79, 377);
            this.tlpButtonAcessar.Margin = new System.Windows.Forms.Padding(4);
            this.tlpButtonAcessar.Name = "tlpButtonAcessar";
            this.tlpButtonAcessar.RowCount = 1;
            this.tlpButtonAcessar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtonAcessar.Size = new System.Drawing.Size(257, 37);
            this.tlpButtonAcessar.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Location = new System.Drawing.Point(62, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 131);
            this.panel1.TabIndex = 13;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Daycake.Properties.Resources.Dbk_5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(413, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpButtonAcessar);
            this.Controls.Add(this.tlpLoginSenha);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tlpLoginSenha.ResumeLayout(false);
            this.tlpLoginSenha.PerformLayout();
            this.tlpButtonAcessar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.PictureBox picSenha;
        private System.Windows.Forms.TableLayoutPanel tlpLoginSenha;
        private System.Windows.Forms.TableLayoutPanel tlpButtonAcessar;
        private System.Windows.Forms.Panel panel1;
    }
}

