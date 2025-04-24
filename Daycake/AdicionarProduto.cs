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
    public partial class FormProduto: Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1007;database=daycake";
        public int? id_produto_selecionado = null;

        public FormProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
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
                    cmd.Parameters.AddWithValue("@status", cbxStatus.Text);

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
                    cmd.Parameters.AddWithValue("@status", cbxStatus.Text);

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
    }
}
