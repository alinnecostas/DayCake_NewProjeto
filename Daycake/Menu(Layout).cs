using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Daycake
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void mnsSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsCadastro_Click(object sender, EventArgs e)
        {
            CadastroConsultaClientes form = new CadastroConsultaClientes();
            form.ShowDialog();
        }

        private void mnsAgendarPedido_Click(object sender, EventArgs e)
        {
            FormPedido form = new FormPedido();
            form.ShowDialog();
        }

        private void mnsAdicionarProduto_Click(object sender, EventArgs e)
        {
            AdicionarProduto form = new AdicionarProduto();
            form.ShowDialog();
        }

        private void mnsClientes_Click(object sender, EventArgs e)
        {
            CadastroConsultaClientes form = new CadastroConsultaClientes();
            form.ShowDialog();
        }

        private void mnsListaProdutos_Click(object sender, EventArgs e)
        {
            FormListaProdutos form = new FormListaProdutos();
            form.ShowDialog();
        }

        private void mnsRecebimentos_Click(object sender, EventArgs e)
        {
            Recebimentos form = new Recebimentos();
            form.ShowDialog();
        }

        private void picMenu_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void mnsConsultarPedidos_Click_1(object sender, EventArgs e)
        {
            FormListaPedidos form = new FormListaPedidos();
            form.ShowDialog();
        }

        private void mnsListaProdutos_Click_1(object sender, EventArgs e)
        {
            Form form = new FormListaProdutos();
            form.ShowDialog();
        }

        private void mnsClientes_Click_1(object sender, EventArgs e)
        {
         
        }
    }
}
