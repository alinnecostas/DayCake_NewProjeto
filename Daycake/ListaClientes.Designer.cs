namespace Daycake
{
    partial class FormListaClientes
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
            this.lvwListaClientes = new System.Windows.Forms.ListView();
            this.txtBarraBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwListaClientes
            // 
            this.lvwListaClientes.HideSelection = false;
            this.lvwListaClientes.Location = new System.Drawing.Point(12, 75);
            this.lvwListaClientes.Name = "lvwListaClientes";
            this.lvwListaClientes.Size = new System.Drawing.Size(558, 363);
            this.lvwListaClientes.TabIndex = 0;
            this.lvwListaClientes.UseCompatibleStateImageBehavior = false;
            // 
            // txtBarraBuscar
            // 
            this.txtBarraBuscar.Location = new System.Drawing.Point(12, 36);
            this.txtBarraBuscar.Name = "txtBarraBuscar";
            this.txtBarraBuscar.Size = new System.Drawing.Size(450, 20);
            this.txtBarraBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(474, 35);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(98, 13);
            this.lblBuscar.TabIndex = 3;
            this.lblBuscar.Text = "Digite a sua busca:";
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBarraBuscar);
            this.Controls.Add(this.lvwListaClientes);
            this.Name = "FormListaClientes";
            this.Text = "ListaClientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwListaClientes;
        private System.Windows.Forms.TextBox txtBarraBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblBuscar;
    }
}