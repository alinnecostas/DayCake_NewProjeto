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
        private string data_source = "datasource=localhost;username=root;password=1007;database=daycake";
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
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar a conexão com o MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                // Habilitando o Update para o meu botão salvar

                if (id_produto_selecionado == null)
                {
                    // insert
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "INSERT INTO produto " +
                        "(idProduto, nomeProduto, descricao, preco, tempo_preparo, status) " +
                        "VALUES " +
                        "(@idProduto, @nomeProduto, @descricao, @preco, @tempo_preparo, @status)";

                    cmd.Parameters.AddWithValue("@idProduto", mtbIdProduto.Text);
                    cmd.Parameters.AddWithValue("@nomeProduto", txtNomeProduto.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@preco", mtbPreco.Text);
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
                        "SET idProduto = @idProduto, nomeProduto = @nomeProduto, descricao = @descricao, preco = @preco, tempo_preparo = @tempo_preparo, status = @status " +
                        "WHERE idProduto = @idProduto";

                    cmd.Parameters.AddWithValue("@idProduto", mtbIdProduto.Text);
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


        private void carregar_produtos()
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM contato ORDER BY id ASC";

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
            cbxAtivoInativo.SelectedIndex = 0;
            txtNomeProduto.Focus();
        }

        private void excluir_produto()
        {
            try
            {

                DialogResult conf = MessageBox.Show("Deseja Excluir o Registro com ?",
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
                    cmd.CommandText = "DELETE FROM contato WHERE id=@id";
                    cmd.Parameters.AddWithValue("@id", id_produto_selecionado);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(
                            "Contato Excluido com Sucesso!",
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

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            excluir_produto();
        }
    }
}