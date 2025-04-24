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
    public partial class FormListaProdutos : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1007;database=Daycake";

        public FormListaProdutos()
        {
            InitializeComponent();

            lstListaProdutos.View = View.Details;
            lstListaProdutos.Columns.Clear();
            lstListaProdutos.Items.Clear();

            lstListaProdutos.Columns.Add("ID Produto", 50);
            lstListaProdutos.Columns.Add("Nome do produto", 50);
            lstListaProdutos.Columns.Add("Descrição", 100);
            lstListaProdutos.Columns.Add("Preço", 100);
            lstListaProdutos.Columns.Add("Tempo de Preparo", 100);
            lstListaProdutos.Columns.Add("Status", 30);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao.Open();

                string sql = "SELECT * FROM Produto";

                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(), //id produto
                        reader.GetString(1), // nome produto
                        reader.GetString(2), // descrição
                        reader.GetDecimal(3).ToString(), // preço
                        reader.GetString(4), // tempo preparo
                        reader.GetString(5), // status
                       };
                    var linha_list_view = new ListViewItem(row);
                    lstListaProdutos.Items.Add(linha_list_view);
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
