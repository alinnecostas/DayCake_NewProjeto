using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace Daycake
{
    public partial class FormPedido : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=;database=Daycake";
        public int? id_pedido_selecionado = null;
        decimal valorTotal = 0;

        List<ClienteItem> ListaClientes = new List<ClienteItem>();
        private bool estaSelecionando = false;

        public FormPedido()
        {
            InitializeComponent();


            lstListaPedidos.View = View.Details;
            lstListaPedidos.Columns.Clear();
            lstListaPedidos.Items.Clear();

            // lstListaPedidos.Columns.Add("ID Pedido", 100);
            lstListaPedidos.Columns.Add("Cliente", 100);
            lstListaPedidos.Columns.Add("Nome do Cliente", 100);
            lstListaPedidos.Columns.Add("Data do Pedido", 100);
            lstListaPedidos.Columns.Add("Data da Entrega", 100);
            lstListaPedidos.Columns.Add("Tipo de Pedido", 180);
            lstListaPedidos.Columns.Add("Valor", 100);
            lstListaPedidos.Columns.Add("Descrição", 180);
            lstListaPedidos.Columns.Add("Forma de Pagamento", 100);
            lstListaPedidos.Columns.Add("Status", 150);

            lstTipoDoce.View = View.Details;
            lstTipoDoce.Columns.Add("Tipo Doce", 200);
            lstTipoDoce.Columns.Add("Preço", 80);
            lstTipoDoce.Columns.Add("Quantidade", 100);

            carregar_pedido();

        }

        private void btnFazerPedido_Click_1(object sender, EventArgs e)
        {            
                ClienteItem clienteSelecionado = cbxNomeCliente.SelectedItem as ClienteItem;

                if (clienteSelecionado == null)
                {
                    MessageBox.Show("Selecione um cliente válido.");
                    return;
                }

                // Validação e conversão do valor monetário
                decimal valor;
                try
                {
                    string valorTexto = txtValor.Text.Replace("R$", "").Replace(" ", "").Trim();

                    // Primeiro tenta converter com formato brasileiro (vírgula como decimal)
                    if (!decimal.TryParse(valorTexto, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valor))
                    {
                        // Se falhar, tenta com formato internacional (ponto como decimal)
                        if (!decimal.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                        {
                            MessageBox.Show("Formato de valor inválido. Use números com vírgula ou ponto decimal (ex: 125,99 ou 125.99)",
                                          "Formato inválido",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao converter valor: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obter a lista de doces como string formatada
                string tiposDoces = ConcatenarDocesDoListView(lstTipoDoce);

                try
                {
                    using (MySqlConnection conexao = new MySqlConnection(data_source))
                    {
                        conexao.Open();
                        MySqlCommand cmd = new MySqlCommand();
                        cmd.Connection = conexao;

                        // CORREÇÃO: A lógica estava invertida - quando id_pedido_selecionado é null, deve ser INSERT
                        if (id_pedido_selecionado == null) // INSERIR novo pedido
                        {
                            cmd.CommandText = @"
                                INSERT INTO pedido (
                                    clienteid, 
                                    nomeCliente, 
                                    data_pedido, 
                                    data_entrega, 
                                    valor, 
                                    tipo_de_doce, 
                                    descricao, 
                                    forma_pagamento, 
                                    status
                                ) 
                                VALUES (
                                    @clienteid, 
                                    @nomeCliente, 
                                    @data_pedido, 
                                    @data_entrega, 
                                    @valor, 
                                    @tipoDoce, 
                                    @descricao, 
                                    @forma_pagamento, 
                                    @status
                                )";

                            cmd.Parameters.AddWithValue("@clienteid", clienteSelecionado.IDCliente);
                            cmd.Parameters.AddWithValue("@nomeCliente", clienteSelecionado.nomeCliente);
                            cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                            cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);
                            cmd.Parameters.AddWithValue("@valor", valor);
                            cmd.Parameters.AddWithValue("@tipoDoce", tiposDoces);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                            cmd.Parameters.AddWithValue("@status", cbxStatus.Text);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Pedido cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else // ATUALIZAR pedido existente
                        {
                            cmd.CommandText = @"
                                UPDATE pedido 
                                SET 
                                    clienteid = @clienteid, 
                                    nomeCliente = @nomeCliente,
                                    data_pedido = @data_pedido, 
                                    data_entrega = @data_entrega, 
                                    valor = @valor, 
                                    tipo_de_doce = @tipoDoce, 
                                    descricao = @descricao, 
                                    forma_pagamento = @forma_pagamento, 
                                    status = @status 
                                WHERE idPedido = @idPedido";

                            cmd.Parameters.AddWithValue("@clienteid", clienteSelecionado.IDCliente);
                            cmd.Parameters.AddWithValue("@nomeCliente", clienteSelecionado.nomeCliente);
                            cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                            cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);
                            cmd.Parameters.AddWithValue("@valor", valor);
                            cmd.Parameters.AddWithValue("@tipoDoce", tiposDoces);
                            cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                            cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                            cmd.Parameters.AddWithValue("@status", cbxStatus.Text);
                            cmd.Parameters.AddWithValue("@idPedido", id_pedido_selecionado);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Pedido atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        // Atualiza a lista e limpa os campos
                        carregar_pedido();
                        zerar_forms();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro no banco de dados: {ex.Message}\nCódigo: {ex.Number}",
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado: {ex.Message}",
                                   "Erro",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }

            private void txtValor_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtValor.Text.Replace("R$", "").Trim(),
                NumberStyles.Currency,
                CultureInfo.GetCultureInfo("pt-BR"),
                out decimal valor))
            {
                txtValor.Text = valor.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
            }
        }

        private void carregar_pedido()
        {
            {
                try
                {
                    Conexao = new MySqlConnection(data_source);
                    // Consulta com JOIN para obter o nome do cliente corretamente
                    string sql = @"SELECT p.idPedido, p.clienteid, c.nome AS nomeCliente, 
                      p.data_pedido, p.data_entrega, p.valor, 
                      p.tipo_de_doce, p.descricao, p.forma_pagamento, p.status 
                      FROM pedido p
                      LEFT JOIN cliente c ON p.clienteid = c.idCliente
                      ORDER BY p.idPedido ASC";

                    Conexao.Open();
                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);
                    MySqlDataReader reader = buscar.ExecuteReader();

                    lstListaPedidos.Items.Clear();

                    while (reader.Read())
                    {
                        try
                        {
                            string[] row =
                            {
                    reader["idPedido"].ToString(),
                    reader["clienteid"].ToString(),
                    reader["nomeCliente"] != DBNull.Value ? reader["nomeCliente"].ToString() : "N/A",
                    reader["data_pedido"].ToString(),
                    reader["data_entrega"].ToString(),
                    reader["valor"] != DBNull.Value ?
                        Convert.ToDecimal(reader["valor"]).ToString("C2", CultureInfo.GetCultureInfo("pt-BR")) : "R$ 0,00",
                    reader["tipo_de_doce"].ToString(),
                    reader["descricao"].ToString(),
                    reader["forma_pagamento"].ToString(),
                    reader["status"].ToString()
                };

                            var linha_list_view = new ListViewItem(row);
                            lstListaPedidos.Items.Add(linha_list_view);
                        }
                        catch (Exception ex)
                        {
                            // Log do erro sem interromper o carregamento
                            Debug.WriteLine($"Erro ao processar registro: {ex.Message}");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro no banco de dados: {ex.Message}\nCódigo: {ex.Number}",
                                  "Erro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar pedidos: {ex.Message}",
                                  "Erro",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                }
                finally
                {
                    if (Conexao != null && Conexao.State == ConnectionState.Open)
                    {
                        Conexao.Close();
                    }
                }
            }
        }



            private void FormPedido_Load(object sender, EventArgs e)
        {
            cbxNomeCliente.DropDownStyle = ComboBoxStyle.DropDown;

            CarregarCliente();

            cbxNomeCliente.TextChanged += cbxNomeCliente_TextChanged;
            cbxNomeCliente.SelectedIndexChanged += cbxNomeCliente_SelectedIndexChanged;
            cbxNomeCliente.Enter += cbxNomeCliente_Enter;
            cbxNomeCliente.Leave += cbxNomeCliente_Leave;


            cbxStatus.Items.Add("Em andamento");
            cbxStatus.Items.Add("Finalizado");
            cbxStatus.Items.Add("Cancelado");
            cbxStatus.Items.Add("Entregue");

            cbxStatus.SelectedIndex = 0;

            cbxFormaPagamento.Items.Add("PIX");
            cbxFormaPagamento.Items.Add("Cartão de crédito");
            cbxFormaPagamento.Items.Add("Dinheiro");
            cbxFormaPagamento.Items.Add("Débito");

            cbxFormaPagamento.SelectedIndex = 0;

            cbxNomeCliente.DropDownStyle = ComboBoxStyle.DropDown;

            CarregarCliente();

            string connectionString = "datasource=localhost;username=root;password=;database=daycake";
            string query = "SELECT nome FROM Produto";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Adiciona o nome do produto no ComboBox
                        string nome = reader.GetString("nome");
                        cbxTipoDoce.Items.Add(nome);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message);


                }
            }

        }

        private void CarregarCliente()
        {
            ListaClientes.Clear();
            cbxNomeCliente.Items.Clear();

            cbxNomeCliente.DropDownStyle = ComboBoxStyle.DropDown;
            cbxNomeCliente.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxNomeCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection nomes = new AutoCompleteStringCollection();

            using (MySqlConnection conexao = new MySqlConnection("datasource = localhost; username = root; password =; database = daycake"))
            {
                try
                {

                    conexao.Open();
                    string sql = "SELECT idCliente, nome FROM Cliente";

                    using (MySqlCommand cmd = new MySqlCommand(sql, conexao))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ClienteItem cliente = new ClienteItem()
                            {
                                IDCliente = Convert.ToInt32(reader["idCliente"]),
                                nomeCliente = reader["nome"].ToString()
                            };

                            ListaClientes.Add(cliente);
                            cbxNomeCliente.Items.Add(cliente);
                            nomes.Add(cliente.nomeCliente);
                        }
                    }
                    cbxNomeCliente.AutoCompleteCustomSource = nomes;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar clientes: " + ex.Message);
                }
            }
        }



        private void cbxTipoDoce_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoDoce.SelectedItem == null)
                return;

            string doceSelecionado = cbxTipoDoce.SelectedItem.ToString();
            try
            {
                using (MySqlConnection Conexao = new MySqlConnection(data_source))
                {
                    if (Conexao.State == ConnectionState.Closed)
                        Conexao.Close();

                    Conexao.Open();
                    string query = ("SELECT preco FROM Produto Where nome = @nome");

                    using (MySqlCommand cmd = new MySqlCommand(query, Conexao))
                    {
                        cmd.Parameters.AddWithValue("@nome", doceSelecionado);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal preco = Convert.ToDecimal(reader["preco"]);

                                ListViewItem item = new ListViewItem(doceSelecionado);
                                item.SubItems.Add(preco.ToString("C2"));
                                item.Tag = preco;
                                lstTipoDoce.Items.Add(item);
                            }
                        }
                    }
                }
                AtualizarValorTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar preço: " + ex.Message);
            }
        }

        private string ConcatenarDocesDoListView(ListView listView)
        {
            List<string> docesConcatenados = new List<string>();

            foreach (ListViewItem item in listView.Items)
            {
                string nome = item.SubItems[0].Text;
                string preco = item.SubItems[1].Text;
                string quantidade = item.SubItems.Count > 2 ? item.SubItems[2].Text : "1";

                string linha = $"{nome} - {preco} - {quantidade}";
                docesConcatenados.Add(linha);
            }

            return string.Join("; ", docesConcatenados);
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

            cbxNomeCliente.Text = "";
            mtbDataPedido.Text = "";
            mtbDataEntrega.Text = "";
            txtValor.Text = "";
            txtDescricao.Text = "";
            lstTipoDoce.Items.Clear();
            cbxFormaPagamento.SelectedIndex = -1;
            cbxStatus.SelectedIndex = -1; 



        }

        private void excluir_pedido()
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
                    cmd.CommandText = "DELETE FROM pedido WHERE idPedido=@id";
                    cmd.Parameters.AddWithValue("@id", id_pedido_selecionado);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(
                            "Contato Excluido com Sucesso!",
                            "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );


                    carregar_pedido();

                    zerar_forms();
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



        private void btnNovo_Click(object sender, EventArgs e)
        {
            zerar_forms();

        }



        private void lstTipoDoce_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private void btnBuscarPedidos_Click_1(object sender, EventArgs e)
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
                        reader.GetInt32(0).ToString(),  //id pedido
                        reader.GetInt32(1).ToString(),  // id cliente
                        reader.GetString(2),  // data pedido
                        reader.GetString(3),  // data entrega
                        reader.GetString(4),  // valor
                        reader.GetString(5),  // tipo doce
                        reader.GetString(6),  // observação
                        reader.GetString(7),  // forma pagamento
                        reader.GetString(8),  // forma pagamento
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


        private void excluirPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            excluir_pedido();
        }


        private void AtualizarValorTotal()
        {
            decimal total = 0;
            foreach (ListViewItem item in lstTipoDoce.Items)
            {
                if (item.Tag != null)
                {
                    total += (decimal)item.Tag;
                }
            }
            txtValor.Text = total.ToString("C2");
        }



        private void cbxNomeCliente_TextChangedChanged(object sender, EventArgs e)
        {

        }

        private void cbxNomeCliente_Enter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void cbxNomeCliente_Leave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void cbxNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            estaSelecionando = true;
            ClienteItem clienteSelecionado = cbxNomeCliente.SelectedItem as ClienteItem;
            estaSelecionando = false;
        }

        private void cbxNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (estaSelecionando)
                return;

            string textoDigitado = cbxNomeCliente.Text.ToLower();

            if (!cbxNomeCliente.Focused)

                return;

            cbxNomeCliente.BeginUpdate();
            cbxNomeCliente.Items.Clear();

            foreach (ClienteItem cliente in ListaClientes)
            {
                if (cliente.nomeCliente.ToLower().Contains(textoDigitado))
                {
                    cbxNomeCliente.Items.Add(cliente);
                }
            }

            cbxNomeCliente.EndUpdate();
            if (cbxNomeCliente.Items.Count > 0)
            {
                cbxNomeCliente.DroppedDown = false;
            }
            cbxNomeCliente.SelectionStart = textoDigitado.Length;
            cbxNomeCliente.SelectionLength = 0;

            this.Cursor = Cursors.Default;
        }

        private void cbxNomeCliente_Enter_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void cbxNomeCliente_Leave_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnAtualizarPedido_Click(object sender, EventArgs e)
        {

            try
            {
                decimal valor;
                string textoLimpo = txtValor.Text.Replace("R$", "").Trim();

                if (!decimal.TryParse(textoLimpo, NumberStyles.Currency, CultureInfo.CurrentCulture, out valor))
                {
                    MessageBox.Show("Valor inválido. Verifique o campo 'Valor'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                MySqlCommand cmd = new MySqlCommand("INSERT INTO pedidos (clienteid, data_pedido, data_entrega, valor, tipoDoce, descricao, forma_pagamento, status) VALUES (@clienteid, @data_pedido, @data_entrega, @valor, @tipoDoce, @descricao, @forma_pagamento, @status)");


                cmd.Parameters.AddWithValue("@clienteid", cbxNomeCliente.SelectedItem);
                
                cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);
                cmd.Parameters.AddWithValue("@valor", valor);  // <- valor validado
                cmd.Parameters.AddWithValue("@tipoDoce", lstTipoDoce.Text);
                cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                cmd.Parameters.AddWithValue("@status", cbxStatus.Text);


                Conexao = new MySqlConnection(data_source);
                Conexao.Open();


                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente atualizado com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void lstListaPedidos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {            
                if (lstListaPedidos.SelectedItems.Count == 0) return;

                try
                {
                    ListViewItem item = lstListaPedidos.SelectedItems[0];

                    id_pedido_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                    // Preenche os campos do formulário
                    cbxNomeCliente.Text = item.SubItems[2].Text; // Nome do cliente está no índice 2 agora
                    mtbDataPedido.Text = item.SubItems[3].Text;
                    mtbDataEntrega.Text = item.SubItems[4].Text;
                    txtValor.Text = item.SubItems[5].Text;
                    txtDescricao.Text = item.SubItems[7].Text;

                    // Limpa e adiciona os itens do tipo de doce
                    lstTipoDoce.Items.Clear();
                    string[] doces = item.SubItems[6].Text.Split(';');
                    foreach (string doce in doces)
                    {
                        if (!string.IsNullOrWhiteSpace(doce))
                        {
                            lstTipoDoce.Items.Add(new ListViewItem(doce.Trim()));
                        }
                    }

                    cbxFormaPagamento.Text = item.SubItems[8].Text;
                    cbxStatus.Text = item.SubItems[9].Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar pedido: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        

        private void AtualizarTotalGeral()
        {
            decimal totalGeral = 0;

            foreach (ListViewItem item in lstTipoDoce.Items)
            {
                if (item.SubItems.Count >= 4 &&
                    decimal.TryParse(item.SubItems[1].Text.Replace("R$", "").Trim(), out decimal preco) &&
                    int.TryParse(item.SubItems[2].Text, out int quantidade))
                {
                    decimal totalItem = preco * quantidade;
                    item.SubItems[3].Text = totalItem.ToString("C"); // Atualiza o valor total do item
                    totalGeral += totalItem;

                }
            }
            txtValor.Text = totalGeral.ToString("C");

        }

        private decimal ConverterValorMonetario(string valorTexto)
        {
            // Remove símbolos de moeda e espaços
            valorTexto = valorTexto.Replace("R$", "").Replace(" ", "").Trim();

            // Tenta converter considerando o formato brasileiro
            if (decimal.TryParse(valorTexto, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valor))
            {
                return valor;
            }

            // Tenta converter com formato invariante como fallback
            if (decimal.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
            {
                return valor;
            }

            throw new FormatException("Formato de valor inválido. Use números com vírgula decimal (ex: 125,99)");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (lstTipoDoce.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item no ListView.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int novaQuantidade) || novaQuantidade < 1)
            {
                MessageBox.Show("Digite uma quantidade válida.");
                return;
            }

            ListViewItem itemSelecionado = lstTipoDoce.SelectedItems[0];

            if (itemSelecionado.SubItems.Count < 3)
            {
                itemSelecionado.SubItems.Add(novaQuantidade.ToString());
            }
            else
            {
                itemSelecionado.SubItems[2].Text = novaQuantidade.ToString();
            }

            AtualizarTotalGeral();
        }

        private void lstTipoDoce_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lstTipoDoce.HitTest(e.Location);

            if (info.Item != null && info.SubItem != null)
            {
                int subItemIndex = info.Item.SubItems.IndexOf(info.SubItem);

                if (subItemIndex == 2) // coluna da quantidade
                {
                    txtQuantidade.Text = info.SubItem.Text;
                    txtQuantidade.Visible = true;
                    txtQuantidade.Focus();
                    txtQuantidade.SelectAll();

                    // Opcional: seleciona o item
                    info.Item.Selected = true;
                }
            }
        }
    }

}

