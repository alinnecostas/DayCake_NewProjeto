using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daycake
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Aplica no MenuStrip
            mnsMenu.BackColor = ColorTranslator.FromHtml("255; 235; 223"); // Rosa bebê
            mnsMenu.ForeColor = ColorTranslator.FromHtml("141; 98; 98");

            // Para cada item (Cliente, Pedidos, etc)
            foreach (ToolStripMenuItem item in mnsMenu.Items)
            {
                item.BackColor = ColorTranslator.FromHtml("255; 235; 223"); // Fundo
                item.ForeColor = ColorTranslator.FromHtml("141; 98; 98"); // Texto

                // Também aplica nos submenus, se tiver
                foreach (ToolStripItem subItem in item.DropDownItems)
                {
                    subItem.BackColor = ColorTranslator.FromHtml("141; 98; 98");
                    subItem.ForeColor = ColorTranslator.FromHtml("255; 235; 223");
                }
            }

        }

        private void mnsAdicionarProduto_Click(object sender, EventArgs e)
        {
            Form adicionarProduto = new AdicionarProduto();
            adicionarProduto.Show();
        }

        private void mnsAgendarPedido_Click(object sender, EventArgs e)
        {
            Form Pedidos = new Pedido();
            Pedidos.Show();
        }

        private void mnsCadastro_Click(object sender, EventArgs e)
        {
            Form CadastroCliente = new CadastroCliente();
            CadastroCliente.Show();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            // Fecha o programa
            Application.Exit();


        }
    }
}
