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
    public partial class FormMenu: Form
    {
        //Conexão com o banco de dados
        MySqlConnection Conexao;
        //Conexão com o banco de dados
        private string data_source = "datasource=localhost;username=root;password=1007;database=daycake";
        
        
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
            FormCadastroCliente form = new FormCadastroCliente();
            form.ShowDialog();
        }

        private void mnsAgendarPedido_Click(object sender, EventArgs e)
        {
            FormPedido form = new FormPedido();
            form.ShowDialog();
        }

        private void mnsAdicionarProduto_Click(object sender, EventArgs e)
        {
            FormProduto form = new FormProduto();
            form.ShowDialog();
        }

        private void mnsClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes form = new FormListaClientes();
            form.ShowDialog();
        }

        private void mnsConsultarPedidos_Click(object sender, EventArgs e)
        {
            FormListaPedidos form = new FormListaPedidos();
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
    }
}
