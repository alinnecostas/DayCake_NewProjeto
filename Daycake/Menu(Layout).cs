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


        private void mnsClientes_Click(object sender, EventArgs e)
        {
            CadastroConsultaClientes form = new CadastroConsultaClientes();
            form.ShowDialog();
        }

        private void mnsListaProdutos_Click(object sender, EventArgs e)
        {
            Produtos form = new Produtos();
            form.ShowDialog();
        }

        private void mnsRecebimentos_Click(object sender, EventArgs e)
        {
            Recebimento form = new Recebimento();
            form.ShowDialog();
        }

        private void mnsAdicionarProduto_Click(object sender, EventArgs e)
        {
            Produtos form = new Produtos();
            form.ShowDialog();
        }

        private void mnsRecebimentos_Click_1(object sender, EventArgs e)
        {
            Recebimento form = new Recebimento();
            form.ShowDialog();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Status form = new Status();
            form.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            // Define o tamanho do formulário para a área útil da tela (sem a barra de tarefas)
            this.Bounds = Screen.PrimaryScreen.WorkingArea;
        }

        private void mnsMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}