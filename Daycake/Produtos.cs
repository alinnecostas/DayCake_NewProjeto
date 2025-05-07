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
    public partial class Produtos : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=adminADMIN;database=daycake";
        public int? id_produto_selecionado = null;

        public Produtos()
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

            carregar_produtos();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;


                if (id_produto_selecionado == null)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        "INSERT INTO produto " +
                        "(nome, descricao, preco, tempo_preparo, status) " +
                        "VALUES " +
                        "(@nome, @descricao, @preco, @tempo_preparo, @status)";

                    cmd.Parameters.AddWithValue("@nome", txtNomeProduto.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    
                    decimal precoDecimal;

                    if (!decimal.TryParse(mtbPreco.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out precoDecimal))
                    {
                        MessageBox.Show("Preço inválido. Digite um valor numérico, como 12.50.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string precoFormatado = precoDecimal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
                    cmd.Parameters.AddWithValue("@preco", precoFormatado);

                    cmd.Parameters.AddWithValue("@tempo_preparo", mtbTempoPreparo.Text);
                    cmd.Parameters.AddWithValue("@status", cbxAtivoInativo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Inserido com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // update
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "UPDATE produto " +
                        "SET nome = @nome, descricao = @descricao, preco = @preco, tempo_preparo = @tempo_preparo, status = @status " +
                        "WHERE idProduto = @idProduto";

                    cmd.Parameters.AddWithValue("@nomeProduto", txtNomeProduto.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@preco", mtbPreco.Text);
                    cmd.Parameters.AddWithValue("@tempo_preparo", mtbTempoPreparo.Text);
                    cmd.Parameters.AddWithValue("@status", cbxAtivoInativo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Atualizado com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)

            {
                MessageBox.Show("Error " + "has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Has occured: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string termoBusca = "%" + txtBuscar.Text + "%";

                Conexao = new MySqlConnection(data_source);

                string sql = @"SELECT idProduto, nome, descricao, preco, tempo_preparo, status
                FROM Produto 
                WHERE nome LIKE @termo 
                OR preco LIKE @termo 
                OR status LIKE @termo";

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@termo", termoBusca);

                MySqlDataReader reader = cmd.ExecuteReader();

                lstListaProdutos.Items.Clear();

                while (reader.Read())
                {
                    string[] row = new string[8];

                    row[0] = reader.GetInt32(0).ToString();      // idProduto
                    row[1] = reader.GetString(1);                // nome
                    row[2] = reader.GetString(2);                // descricao
                    row[3] = reader.GetString(3);                // preço
                    row[4] = reader.GetString(4);                // tempo preparo
                    row[5] = reader.GetString(5);                // status

                    lstListaProdutos.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na busca: " + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexao?.State == ConnectionState.Open)
                    Conexao.Close();
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir_produto();
        }

        private void carregar_produtos()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM Produto ORDER BY idProduto ASC";

                Conexao.Open();

                MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = buscar.ExecuteReader();

                lstListaProdutos.Items.Clear();

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
             
        private void zerar_Forms()
        {
            id_produto_selecionado = null;
            txtNomeProduto.Text = String.Empty;
            txtDescricao.Text = "";
            mtbPreco.Text = null;
            mtbTempoPreparo.Text = null;
            cbxAtivoInativo.Text = "";
            txtNomeProduto.Focus();
        }

        private void excluir_produto()
        {
            try
            {

                DialogResult conf = MessageBox.Show("Deseja Excluir o Registro?",
                                                    "Certeza ?",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (conf == DialogResult.Yes)
                {
                    Conexao = new MySqlConnection(data_source);
                    Conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = Conexao;

                    cmd.Connection = Conexao;
                    cmd.CommandText = "DELETE FROM produto WHERE idProduto=@id";
                    cmd.Parameters.AddWithValue("@id", id_produto_selecionado);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(
                            "Produto Excluido com Sucesso!",
                            "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );


                    carregar_produtos();


                    zerar_Forms();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + "Ocorreu: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                Conexao.Close();
            }
        }

        private void lstListaProdutos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstListaProdutos.SelectedItems;


            foreach (ListViewItem item in itens_selecionados)
            {
                id_produto_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNomeProduto.Text = item.SubItems[1].Text;
                txtDescricao.Text = item.SubItems[2].Text;
                mtbPreco.Text = item.SubItems[3].Text;
                mtbTempoPreparo.Text = item.SubItems[4].Text;
                cbxAtivoInativo.Text = item.SubItems[5].Text;
            }

            btnExcluir.Visible = true;
        }
    }
}