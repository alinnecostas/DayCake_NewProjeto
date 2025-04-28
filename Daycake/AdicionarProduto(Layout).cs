using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Daycake
{
    public partial class AdicionarProduto : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=adminADMIN;database=daycake";
        private int? id_contato_selecionado = null;

        public AdicionarProduto()
        {
            InitializeComponent();
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (id_contato_selecionado == null)
                {
                    // insert
                    cmd.Parameters.Clear();
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
                    cmd.Parameters.AddWithValue("@status", cbxAtivo.Text);
                    cmd.Parameters.AddWithValue("@status", cbxInativo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Inserido com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // update
                    cmd.Parameters.Clear();
                    cmd.CommandText =
                        "UPDATE produto " +
                        "SET nomeProduto = @nomeProduto, descricao = @descricao, preco = @preco, tempo_preparo = @tempo_preparo, status = @status " +
                        "WHERE idProduto = @idProduto";

                    cmd.Parameters.AddWithValue("@idProduto", mtbIdProduto.Text);
                    cmd.Parameters.AddWithValue("@nomeProduto", txtNomeProduto.Text);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@preco", mtbPreco.Text);
                    cmd.Parameters.AddWithValue("@tempo_preparo", mtbTempoPreparo.Text);
                    cmd.Parameters.AddWithValue("@status", cbxAtivo.Text);
                    cmd.Parameters.AddWithValue("@status", cbxInativo.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Atualizado com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro MySQL: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexao != null)
                    Conexao.Close();
            }
        }
    }
}

