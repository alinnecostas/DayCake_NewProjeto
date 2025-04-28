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
using MySql.Data.MySqlClient;

namespace Daycake
{
    public partial class FormListaPedidos : Form
    {
        MySqlConnection Conexao;

        private string data_source = "server=localhost;port=3306;user=root;password=1007;database=daycake";

        public int ? id_pedido_selecionado = null;

        public FormListaPedidos()
        {
            InitializeComponent();

            lstListaPedidos.View = View.Details;
            lstListaPedidos.Columns.Clear();
            lstListaPedidos.Items.Clear();

            lstListaPedidos.Columns.Add("ID Pedido", 50);
            lstListaPedidos.Columns.Add("ID Cliente", 50);
            lstListaPedidos.Columns.Add("Data do Pedido", 100);
            lstListaPedidos.Columns.Add("Data da Entrega", 100);
            lstListaPedidos.Columns.Add("Tipo do Produto", 100);
            lstListaPedidos.Columns.Add("Valor", 30);
            lstListaPedidos.Columns.Add("Observação", 80);
            lstListaPedidos.Columns.Add("Forma de Pagamento", 50);

           

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try 
            { 
            Conexao.Open();

            string sql = "SELECT * FROM Pedido";

            MySqlCommand cmd = new MySqlCommand(sql, Conexao);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] row =
                {
                        reader.GetInt32(0).ToString(), //id pedido
                        reader.GetInt32(1).ToString(), // id cliente
                        reader.GetString(2), // data pedido
                        reader.GetString(3), // data entrega
                        reader.GetString(4), // tipo produto
                        reader.GetString(5), // valor
                        reader.GetString(6), // observação
                        reader.GetString(7), // forma pagamento
                       };
                var linha_list_view = new ListViewItem(row);
                lstListaPedidos.Items.Add(linha_list_view);
            }

        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
