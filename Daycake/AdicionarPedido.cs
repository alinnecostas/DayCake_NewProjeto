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
    public partial class FormPedido: Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1007;database=daycake";
        public int? id_pedido_selecionado = null;

        public FormPedido()
        {
            InitializeComponent();
        }

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar a conexão com o MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                // Habilitando o Update para o meu botão salvar

                if (id_pedido_selecionado == null)
                {
                    // insert
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "INSERT INTO pedido " +
                        "(idPedido, clienteid, data_pedido, data_entrega, tipoProduto, valor, observacao, forma_pagamento) " +
                        "VALUES " +
                        "(@idPedido, @clienteid, @data_pedido, @data_entrega, @tipoProduto, @valor, @observacao, @forma_pagamento)";

                    cmd.Parameters.AddWithValue("@idPedido", mtbIdPedido.Text);
                    cmd.Parameters.AddWithValue("@clienteid", mtbIdCliente.Text);
                    cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                    cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);
                    cmd.Parameters.AddWithValue("@tipoProduto", lvwListaDoce.Text);
                    cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                    cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pedido Inserido com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // update
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "UPDATE pedido " +
                        "SET clienteid = @clienteid, data_pedido = @data_pedido, data_entrega = @data_entrega, tipoPrduto = @tipoProduto, valor = @valor, observacao = @observacao, forma_pagamento = @forma_pagamento " +
                        "WHERE idPedido = @idPedido";

                    cmd.Parameters.AddWithValue("@clienteid", mtbIdCliente.Text);
                    cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                    cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);
                    cmd.Parameters.AddWithValue("@tipoProduto", lvwListaDoce.Text);
                    cmd.Parameters.AddWithValue("@valor", txtValor.Text);
                    cmd.Parameters.AddWithValue("@observacao", txtObservacao.Text);
                    cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                    cmd.Parameters.AddWithValue("@id", id_pedido_selecionado);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pedido Atualizado com Sucesso", "Sucesso",
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
