namespace Daycake
{
    partial class FormListaPedidos
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBarraBuscar = new System.Windows.Forms.TextBox();
            this.lstListaPedidos = new System.Windows.Forms.ListView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(16, 25);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(121, 16);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Digite a sua busca:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(632, 43);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(125, 28);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBarraBuscar
            // 
            this.txtBarraBuscar.Location = new System.Drawing.Point(19, 43);
            this.txtBarraBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBarraBuscar.Name = "txtBarraBuscar";
            this.txtBarraBuscar.Size = new System.Drawing.Size(599, 22);
            this.txtBarraBuscar.TabIndex = 5;
            // 
            // lstListaPedidos
            // 
            this.lstListaPedidos.HideSelection = false;
            this.lstListaPedidos.Location = new System.Drawing.Point(16, 92);
            this.lstListaPedidos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstListaPedidos.Name = "lstListaPedidos";
            this.lstListaPedidos.Size = new System.Drawing.Size(743, 392);
            this.lstListaPedidos.TabIndex = 4;
            this.lstListaPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(635, 492);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(125, 32);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FormListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 534);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscar);
            this.Controls.Add(this.lstListaPedidos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormListaPedidos";
            this.Text = "ListaPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBarraBuscar;
        private System.Windows.Forms.ListView lstListaPedidos;
        private System.Windows.Forms.Button btnExcluir;
    }
}