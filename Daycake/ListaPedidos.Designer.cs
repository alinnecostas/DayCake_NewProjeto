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
            this.lvwListaPedidos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(98, 13);
            this.lblBuscar.TabIndex = 7;
            this.lblBuscar.Text = "Digite a sua busca:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(474, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBarraBuscar
            // 
            this.txtBarraBuscar.Location = new System.Drawing.Point(12, 36);
            this.txtBarraBuscar.Name = "txtBarraBuscar";
            this.txtBarraBuscar.Size = new System.Drawing.Size(450, 20);
            this.txtBarraBuscar.TabIndex = 5;
            // 
            // lvwListaPedidos
            // 
            this.lvwListaPedidos.HideSelection = false;
            this.lvwListaPedidos.Location = new System.Drawing.Point(12, 75);
            this.lvwListaPedidos.Name = "lvwListaPedidos";
            this.lvwListaPedidos.Size = new System.Drawing.Size(558, 363);
            this.lvwListaPedidos.TabIndex = 4;
            this.lvwListaPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // FormListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscar);
            this.Controls.Add(this.lvwListaPedidos);
            this.Name = "FormListaPedidos";
            this.Text = "ListaPedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBarraBuscar;
        private System.Windows.Forms.ListView lvwListaPedidos;
    }
}