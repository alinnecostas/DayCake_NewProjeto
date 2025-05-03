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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Daycake
{
    public partial class FormPedido : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=adminADMIN;database=daycake";
        public int? id_pedido_selecionado = null;

        public FormPedido()
        {
            InitializeComponent();

            lstListaPedidos.View = View.Details;
            lstListaPedidos.Columns.Clear();
            lstListaPedidos.Items.Clear();

            lstListaPedidos.Columns.Add("ID Pedido", 100);
            lstListaPedidos.Columns.Add("ID Cliente", 100);
            lstListaPedidos.Columns.Add("Data do Pedido", 100);
            lstListaPedidos.Columns.Add("Data da Entrega", 100);
            lstListaPedidos.Columns.Add("Tipo de Pedido", 100);
            lstListaPedidos.Columns.Add("Valor", 100);
            lstListaPedidos.Columns.Add("Descrição", 100);
            lstListaPedidos.Columns.Add("Forma de Pagamento", 100);
            lstListaPedidos.Columns.Add("Status", 100);

            lstTipoDoce.View = View.Details;
            lstTipoDoce.Columns.Add("Tipo Doce", 200);

            carregar_pedido();
        }

        private void btnFazerPedido_Click_1(object sender, EventArgs e)
        {

            try
            {
                // Verificações de segurança antes de continuar
                if (mtbIdCliente == null || mtbDataPedido == null || mtbDataEntrega == null || txtValor == null ||
                    txtDescricao == null || cbxFormaPagamento == null || cbxStatus == null || lstTipoDoce == null)
                {
                    MessageBox.Show("Há campos do formulário não carregados corretamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txtValor.Text, out decimal valorDecimal))
                {
                    MessageBox.Show("Valor inválido. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Concatena os tipos de doce
                StringBuilder tiposDeDoce = new StringBuilder();
                foreach (ListViewItem item in lstTipoDoce.Items)
                {
                    tiposDeDoce.Append(item.Text + ", ");
                }
                if (tiposDeDoce.Length > 0)
                    tiposDeDoce.Length -= 2; // remove última vírgula

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                if (id_pedido_selecionado == null)
                {
                    cmd.CommandText =
                        "INSERT INTO pedido (clienteid, data_pedido, data_entrega, valor, tipo_de_doce, descricao, forma_pagamento, status) " +
                        "VALUES (@clienteid, @data_pedido, @data_entrega, @valor, @tipoDoce, @descricao, @forma_pagamento, @status)";
                }
                else
                {
                    cmd.CommandText =
                        "UPDATE pedido SET clienteid = @clienteid, data_pedido = @data_pedido, data_entrega = @data_entrega, valor = @valor, " +
                        "tipo_de_doce = @tipoDoce, descricao = @descricao, forma_pagamento = @forma_pagamento, status = @status WHERE idPedido = @idPedido";
                    cmd.Parameters.AddWithValue("@idPedido", id_pedido_selecionado);
                }

                cmd.Parameters.AddWithValue("@clienteid", mtbIdCliente.Text);
                cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);
                cmd.Parameters.AddWithValue("@valor", valorDecimal);
                cmd.Parameters.AddWithValue("@tipoDoce", tiposDeDoce.ToString());
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                cmd.Parameters.AddWithValue("@status", cbxStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                carregar_pedido();
                zerar_forms();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexao != null)
                    Conexao.Close();
            }
        }

        private void carregar_pedido()
        {
            try
            {
                // Desvincula o evento para evitar disparos automáticos
                lstListaPedidos.SelectedIndexChanged -= lstListaPedidos_SelectedIndexChanged;

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                string sql = "SELECT * FROM pedido ORDER BY idPedido ASC";
                MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                MySqlDataReader reader = buscar.ExecuteReader();

                lstListaPedidos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                reader.GetInt32(0).ToString(),
                reader.GetInt32(1).ToString(),
                reader.GetString(2),
                reader.GetString(3),
                reader.GetDecimal(4).ToString("F2"),
                reader.GetString(5),
                reader.GetString(6),
                reader.GetString(7),
                reader.GetString(8)
            };
                    lstListaPedidos.Items.Add(new ListViewItem(row));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar pedidos: " + ex.Message);
            }
            finally
            {
                Conexao.Close();
                // Reassocia o evento após o carregamento
                lstListaPedidos.SelectedIndexChanged += lstListaPedidos_SelectedIndexChanged;
            }
        }


        private void lstListaPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstListaPedidos.SelectedItems.Count == 0)
            {
                btnExcluirPedido.Visible = false;
                return;
            }

            ListViewItem item = lstListaPedidos.SelectedItems[0];

            if (!int.TryParse(item.SubItems[0].Text, out int id))
            {
                id_pedido_selecionado = null;
                MessageBox.Show("ID do pedido inválido. Verifique a seleção.",
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            id_pedido_selecionado = id;

            mtbIdCliente.Text = item.SubItems[1].Text;
            mtbDataPedido.Text = item.SubItems[2].Text;
            mtbDataEntrega.Text = item.SubItems[3].Text;
            txtValor.Text = item.SubItems[4].Text;
            txtDescricao.Text = item.SubItems[5].Text;

            // Evita falhas de conversão para índice
            string tipoDoce = item.SubItems[6].Text;
            string formaPagamento = item.SubItems[7].Text;
            string status = item.SubItems[8].Text;

            // Atualiza os comboboxes sem disparar eventos
            cbxTipoDoce.SelectedIndexChanged -= cbxTipoDoce_SelectedIndexChanged;
            cbxTipoDoce.SelectedIndex = cbxTipoDoce.Items.IndexOf(tipoDoce);
            cbxTipoDoce.SelectedIndexChanged += cbxTipoDoce_SelectedIndexChanged;

            cbxFormaPagamento.SelectedIndex = cbxFormaPagamento.Items.IndexOf(formaPagamento);
            cbxStatus.SelectedIndex = cbxStatus.Items.IndexOf(status);

            // Carrega os tipos de doce
            lstTipoDoce.Items.Clear();
            string[] tiposDoces = tipoDoce.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string doce in tiposDoces)
            {
                lstTipoDoce.Items.Add(new ListViewItem(doce));
            }

            btnExcluirPedido.Visible = true; // Exibe o botão de exclusão
        }


        private void FormPedido_Load(object sender, EventArgs e)
        {
            cbxStatus.Items.AddRange(new string[] { "Em andamento", "Finalizado", "Cancelado", "Entregue" });
            cbxStatus.SelectedIndex = 0;

            cbxFormaPagamento.Items.AddRange(new string[] { "PIX", "Cartão de crédito", "Dinheiro", "Débito" });
            cbxFormaPagamento.SelectedIndex = 0;

            string query = "SELECT nome FROM Produto";
            using (MySqlConnection conn = new MySqlConnection(data_source))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbxTipoDoce.Items.Add(reader.GetString("nome"));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
                }
            }
        }

        private void cbxTipoDoce_SelectedIndexChanged(object sender, EventArgs e)
        {
            string doceSelecionado = cbxTipoDoce.SelectedItem.ToString();
            lstTipoDoce.Items.Add(new ListViewItem(doceSelecionado));
        }

        private void lstTipoDoce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstTipoDoce.SelectedItems.Count > 0)
            {
                lstTipoDoce.Items.Remove(lstTipoDoce.SelectedItems[0]);
            }
        }

        private void btnExcluirPedidos_Click(object sender, EventArgs e)
        {
            excluir_pedido();
        }

        private void zerar_forms()
        {
            id_pedido_selecionado = null;
            mtbIdCliente.Clear();
            mtbDataPedido.Clear();
            mtbDataEntrega.Clear();
            txtValor.Clear();
            txtDescricao.Clear();
            cbxTipoDoce.SelectedIndex = -1;
            cbxFormaPagamento.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1;
            lstTipoDoce.Items.Clear();
        }

        private void excluir_pedido()
        {
            if (lstListaPedidos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um pedido antes de tentar excluir.",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            int id_pedido_selecionado = Convert.ToInt32(lstListaPedidos.SelectedItems[0].SubItems[0].Text);

            try
            {
                DialogResult confirmacao = MessageBox.Show(
                    "Tem certeza de que deseja excluir este pedido?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmacao != DialogResult.Yes)
                {
                    return;
                }

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand checkCmd = new MySqlCommand(
                    "SELECT COUNT(*) FROM pedido WHERE idPedido = @id", Conexao);
                checkCmd.Parameters.AddWithValue("@id", id_pedido_selecionado);

                int existe = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (existe == 0)
                {
                    MessageBox.Show("O pedido não foi encontrado no banco de dados.",
                                    "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                MySqlCommand cmd = new MySqlCommand(
                    "DELETE FROM pedido WHERE idPedido = @id", Conexao);
                cmd.Parameters.AddWithValue("@id", id_pedido_selecionado);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido excluído com sucesso!",
                                "Sucesso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                carregar_pedido();
                zerar_forms();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + ": " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexao != null)
                    Conexao.Close();
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            zerar_forms();

        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_pedido_selecionado == null)
                {
                    MessageBox.Show("Selecione um pedido para atualizar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.CommandText =
                    "UPDATE pedido SET " +
                    "clienteid = @clienteid, " +
                    "data_pedido = @data_pedido, " +
                    "data_entrega = @data_entrega, " +
                    "valor = @valor, " +
                    "tipo_de_doce = @tipoDoce, " +
                    "descricao = @descricao, " +
                    "forma_pagamento = @forma_pagamento, " +
                    "status = @status " +
                    "WHERE idPedido = @id";

                cmd.Parameters.AddWithValue("@clienteid", mtbIdCliente.Text);
                cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);

                // Conversão segura do valor
                if (decimal.TryParse(txtValor.Text, out decimal valorDecimal))
                    cmd.Parameters.AddWithValue("@valor", valorDecimal);
                else
                {
                    MessageBox.Show("Valor inválido. Insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Concatenar os itens da lista de tipos de doce
                string tiposDoces = string.Join(", ", lstTipoDoce.Items
                    .Cast<ListViewItem>()
                    .Select(item => item.Text));

                cmd.Parameters.AddWithValue("@tipoDoce", tiposDoces);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                cmd.Parameters.AddWithValue("@status", cbxStatus.Text);
                cmd.Parameters.AddWithValue("@id", id_pedido_selecionado);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Pedido atualizado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                carregar_pedido();
                zerar_forms();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (Conexao != null)
                    Conexao.Close();
            }

        }

        private void lstTipoDoce_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void btnBuscarPedidos_Click_1(object sender, EventArgs e)
        {
            try
            {
                string termoBusca = "%" + txtBuscarPedidos.Text + "%";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM pedido " +
                             "WHERE clienteid LIKE @termo OR " +
                             "data_pedido LIKE @termo OR " +
                             "data_entrega LIKE @termo OR " +
                             "valor LIKE @termo OR " +
                             "tipo_de_doce LIKE @termo OR " +
                             "descricao LIKE @termo OR " +
                             "forma_pagamento LIKE @termo OR " +
                             "status LIKE @termo";

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@termo", termoBusca);

                MySqlDataReader reader = cmd.ExecuteReader();

                lstListaPedidos.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                reader.GetInt32(0).ToString(), // idPedido
                reader.GetInt32(1).ToString(), // clienteid
                reader.GetString(2),           // data_pedido
                reader.GetString(3),           // data_entrega
                reader.GetDecimal(4).ToString("F2"), // valor
                reader.GetString(5),           // tipo_de_doce
                reader.GetString(6),           // descricao
                reader.GetString(7),           // forma_pagamento
                reader.GetString(8)            // status
            };

                    lstListaPedidos.Items.Add(new ListViewItem(row));
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


        private void excluirPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            excluir_pedido();
        }
    }
}


