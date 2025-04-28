using MySql.Data.MySqlClient;
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
    public partial class CadastroConsultaClientes : Form
    {
        MySqlConnection Conexao;

        private string data_source = "datasource=localhost;username=root;password=1007;database=Daycake";


        public CadastroConsultaClientes()
        {
            InitializeComponent();

            lstListaClientes.View = View.Details;
            lstListaClientes.Columns.Clear();
            lstListaClientes.Items.Clear();

            lstListaClientes.Columns.Add("ID", 50);
            lstListaClientes.Columns.Add("Nome", 50);
            lstListaClientes.Columns.Add("Telefone", 100);
            lstListaClientes.Columns.Add("Email", 100);
            lstListaClientes.Columns.Add("Endereço", 100);
            lstListaClientes.Columns.Add("Bairro", 30);
            lstListaClientes.Columns.Add("Número", 80);
            lstListaClientes.Columns.Add("Data Cadastro", 50);

        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}