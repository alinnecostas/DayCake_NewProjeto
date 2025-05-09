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
using Org.BouncyCastle.Asn1.Cmp;
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

            // Ajuste as colunas para corresponder à ordem dos dados que você está lendo
            // COLUNAS OCULTAS (largura = 0) - DEVEM SER AS PRIMEIRAS
            lstListaPedidos.Columns.Add("ID Pedido", 0);       // SubItems[0] - Acessível mas invisível
            lstListaPedidos.Columns.Add("ID Cliente", 0);      // SubItems[1] - Acessível mas invisível

            lstListaPedidos.Columns.Add("Nome do Cliente", 150);      // lin[2]
            lstListaPedidos.Columns.Add("Data do Pedido", 100);       // lin[3]
            lstListaPedidos.Columns.Add("Data da Entrega", 100);      // lin[4]
            lstListaPedidos.Columns.Add("Valor", 80);                 // lin[5]
            lstListaPedidos.Columns.Add("Tipos de Doce", 180);        // lin[6]
            lstListaPedidos.Columns.Add("Descrição", 180);            // lin[7]
            lstListaPedidos.Columns.Add("Forma de Pagamento", 120);   // lin[8]
            lstListaPedidos.Columns.Add("Status", 100);               // lin[9]

            // Configuração do ListView para tipos de doce (está correto)
            lstTipoDoce.View = View.Details;
            lstTipoDoce.Columns.Add("Tipo Doce", 200);
            lstTipoDoce.Columns.Add("Preço", 80);
            lstTipoDoce.Columns.Add("Quantidade", 100);

            carregar_pedido();
        }

        private void btnFazerPedido_Click_1(object sender, EventArgs e)
        {
            // 1. Validação do Cliente
            if (cbxNomeCliente.Items.Count == 0)
            {
                MessageBox.Show("Nenhum cliente cadastrado. Por favor, cadastre clientes primeiro.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClienteItem clienteSelecionado = cbxNomeCliente.SelectedItem as ClienteItem;

            if (clienteSelecionado == null || cbxNomeCliente.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente válido.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validação das Datas
            if (!DateTime.TryParseExact(mtbDataPedido.Text, "dd/MM/yyyy",
                                       CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataPedido))
            {
                MessageBox.Show("Data do pedido inválida. Use o formato DD/MM/AAAA.",
                              "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParseExact(mtbDataEntrega.Text, "dd/MM/yyyy",
                                       CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataEntrega))
            {
                MessageBox.Show("Data de entrega inválida. Use o formato DD/MM/AAAA.",
                              "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Validação do Valor
            decimal valor;
            try
            {
                string valorTexto = txtValor.Text.Replace("R$", "").Replace(" ", "").Trim();

                if (!decimal.TryParse(valorTexto, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valor))
                {
                    if (!decimal.TryParse(valorTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out valor))
                    {
                        MessageBox.Show("Formato de valor inválido. Use números com vírgula decimal (ex: 125,99)",
                                      "Formato inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if (valor <= 0)
                {
                    MessageBox.Show("O valor deve ser maior que zero.",
                                  "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao converter valor: {ex.Message}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Validação dos Doces
            string tiposDoces = ConcatenarDocesDoListView(lstTipoDoce);
            if (string.IsNullOrWhiteSpace(tiposDoces))
            {
                MessageBox.Show("Selecione pelo menos um tipo de doce.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 5. Validação da Forma de Pagamento
            if (string.IsNullOrWhiteSpace(cbxFormaPagamento.Text))
            {
                MessageBox.Show("Selecione uma forma de pagamento.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 6. Validação do Status
            if (string.IsNullOrWhiteSpace(cbxStatus.Text))
            {
                MessageBox.Show("Selecione um status para o pedido.",
                              "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conexao = new MySqlConnection(data_source))
                {
                    conexao.Open();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conexao;

                    // Sempre força novo cadastro (remove qualquer lógica de atualização)
                    cmd.CommandText = @"
                INSERT INTO pedido (
                    idPedido,
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
                    @idPedido,
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
                    cmd.Parameters.AddWithValue("@nomeCliente", cbxNomeCliente.Text);
                    cmd.Parameters.AddWithValue("@data_pedido", dataPedido.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@data_entrega", dataEntrega.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@valor", valor);
                    cmd.Parameters.AddWithValue("@tipoDoce", tiposDoces);
                    cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                    cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                    cmd.Parameters.AddWithValue("@status", cbxStatus.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Pedido cadastrado com sucesso!",
                                  "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpa os campos após o cadastro
                    zerar_forms();

                    // Atualiza a lista de pedidos
                    carregar_pedido();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro no banco de dados: {ex.Message}\nCódigo: {ex.Number}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro inesperado: {ex.Message}",
                              "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string sql = "SELECT * FROM pedido ORDER BY idPedido ASC";

                    Conexao.Open();

                    MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                    MySqlDataReader reader = buscar.ExecuteReader();

                    lstListaPedidos.Items.Clear();

                    while (reader.Read())
                    {
                        string[] lin = new string[10];
                        //idPedido, clienteid, nomeCliente, data_pedido, data_entrega, valor, tipo_de_doce, descricao, forma_pagamento, status
                        lin[0] = reader["idPedido"].ToString();
                        lin[1] = reader["clienteid"].ToString();
                        lin[2] = reader["nomeCliente"].ToString();
                        lin[3] = reader["data_pedido"].ToString();
                        lin[4] = reader["data_entrega"].ToString();
                        lin[5] = Convert.ToDecimal(reader["valor"]).ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
                        lin[6] = reader["tipo_de_doce"].ToString();
                        lin[7] = reader["descricao"].ToString();
                        lin[8] = reader["forma_pagamento"].ToString();
                        lin[9] = reader["status"].ToString();

                        var linha_list_view = new ListViewItem(lin);
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

            cbxNomeCliente.SelectedIndex = -1;
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
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM pedido ORDER BY idPedido ASC";

                Conexao.Open();

                MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = buscar.ExecuteReader();

                lstListaPedidos.Items.Clear();

                while (reader.Read())
                {
                    string[] lin = new string[10];
                    //idPedido, clienteid, nomeCliente, data_pedido, data_entrega, valor, tipo_de_doce, descricao, forma_pagamento, status
                    lin[0] = reader["idPedido"].ToString();
                    lin[1] = reader["clienteid"].ToString();
                    lin[2] = reader["nomeCliente"].ToString();
                    lin[3] = reader["data_pedido"].ToString();
                    lin[4] = reader["data_entrega"].ToString();
                    lin[5] = reader["valor"].ToString();
                    lin[6] = reader["tipo_de_doce"].ToString();
                    lin[7] = reader["descricao"].ToString();
                    lin[8] = reader["forma_pagamento"].ToString();
                    lin[9] = reader["status"].ToString();

                    var linha_list_view = new ListViewItem(lin);
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
            {
                if (id_pedido_selecionado == null)
                {
                    MessageBox.Show("Nenhum pedido selecionado para atualização.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    decimal valor;
                    string textoLimpo = txtValor.Text.Replace("R$", "").Trim();

                    if (!decimal.TryParse(textoLimpo, NumberStyles.Currency, CultureInfo.CurrentCulture, out valor))
                    {
                        MessageBox.Show("Valor inválido. Verifique o campo 'Valor'.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Obter o nome completo do cliente selecionado
                    string nomeCliente = cbxNomeCliente.Text;

                    // Concatenar os itens do ListView de tipos de doces
                    string tiposDoces = "";
                    foreach (ListViewItem item in lstTipoDoce.Items)
                    {
                        tiposDoces += item.Text + "; ";
                    }
                    tiposDoces = tiposDoces.TrimEnd(' ', ';');

                    using (MySqlConnection conexao = new MySqlConnection(data_source))
                    {
                        conexao.Open();

                        // Usar UPDATE em vez de INSERT
                        MySqlCommand cmd = new MySqlCommand(
                            @"UPDATE pedido SET 
                                pedidoid = @pedidoid,
                                clienteid = @clienteid,
                                nomeCliente = @nomeCliente,
                                data_pedido = @data_pedido,
                                data_entrega = @data_entrega,
                                valor = @valor,
                                tipo_de_doce = @tipoDoce,
                                descricao = @descricao,
                                forma_pagamento = @forma_pagamento,
                                status = @status
                            WHERE idPedido = @idPedido", conexao);

                        // Adicionar parâmetros na ordem correta
                        cmd.Parameters.AddWithValue("@idPedido", id_pedido_selecionado);

                        // Obter o ID do cliente a partir do ComboBox
                        if (cbxNomeCliente.SelectedItem is ClienteItem clienteSelecionado)
                        {
                            cmd.Parameters.AddWithValue("@clienteid", clienteSelecionado.IDCliente);
                        }
                        else
                        {
                            // Fallback caso não tenha um objeto ClienteItem selecionado
                            cmd.Parameters.AddWithValue("@clienteid", DBNull.Value);
                        }
                                               

                        cmd.Parameters.AddWithValue("@nomeCliente", nomeCliente);
                        cmd.Parameters.AddWithValue("@data_pedido", mtbDataPedido.Text);
                        cmd.Parameters.AddWithValue("@data_entrega", mtbDataEntrega.Text);
                        cmd.Parameters.AddWithValue("@valor", valor);
                        cmd.Parameters.AddWithValue("@tipoDoce", tiposDoces);
                        cmd.Parameters.AddWithValue("@descricao", txtDescricao.Text);
                        cmd.Parameters.AddWithValue("@forma_pagamento", cbxFormaPagamento.Text);
                        cmd.Parameters.AddWithValue("@status", cbxStatus.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pedido atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            carregar_pedido(); // Atualiza a lista de pedidos
                            zerar_forms(); // Limpa os campos
                        }
                        else
                        {
                            MessageBox.Show("Nenhum pedido foi atualizado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro no banco de dados: {ex.Message}\nCódigo: {ex.Number}",
                                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro inesperado: {ex.Message}",
                                   "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void lstListaPedidos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                var item = e.Item;

                // Verifica se há subitens suficientes (considerando que temos 10 colunas no total)
                if (item.SubItems.Count >= 10) // Alterado para 10 porque temos 10 colunas
                {
                    try
                    {
                        // Atualiza o ID do pedido selecionado
                        id_pedido_selecionado = Convert.ToInt32(item.SubItems[0].Text); // ID Pedido
                        string clienteId = item.SubItems[1].Text; // ID Pedido/Cliente (oculto)              
                        string nomeCliente = item.SubItems[2].Text;

                        cbxNomeCliente.SelectedIndex = cbxNomeCliente.FindStringExact(nomeCliente);
                        mtbDataPedido.Text = item.SubItems[3].Text;
                        mtbDataEntrega.Text = item.SubItems[4].Text;

                        // Valor (formata como moeda)
                        decimal valorDecimal;
                        string valorText = item.SubItems[5].Text.Replace("R$", "").Trim();
                        if (Decimal.TryParse(valorText, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valorDecimal))
                        {
                            txtValor.Text = valorDecimal.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
                        }
                        else
                        {
                            txtValor.Text = "R$ 0,00";
                        }

                        // Tipos de doces (SubItems[6])
                        // Você precisará implementar a lógica para preencher o lstTipoDoce
                        // baseado no conteúdo de item.SubItems[6].Text

                       lstTipoDoce.Text = item.SubItems[6].Text;

                        txtDescricao.Text = item.SubItems[7].Text;

                        // Forma de pagamento e status
                        cbxFormaPagamento.Text = item.SubItems[8].Text;
                        cbxStatus.Text = item.SubItems[9].Text;

                        btnExcluirPedido.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar os dados do pedido: {ex.Message}",
                                      "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro: O item selecionado não contém todos os dados necessários.",
                                   "Dados incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //    if (e.IsSelected)
        //    {
        //        var item = e.Item;

        //        if (item.SubItems.Count >= 9) // Verifica se há pelo menos 9 subitens
        //        {
        //            id_pedido_selecionado = Convert.ToInt32(item.SubItems[0].Text);

        //            cbxNomeCliente.Text = item.SubItems[1].Text;
        //            mtbDataPedido.Text = item.SubItems[2].Text;
        //            mtbDataEntrega.Text = item.SubItems[3].Text;

        //            // Tipo de doce
        //            lstTipoDoce.Text = item.SubItems[4].Text;

        //            // Valor
        //            decimal valorDecimal;
        //            if (Decimal.TryParse(item.SubItems[5].Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valorDecimal))
        //            {
        //                txtValor.Text = valorDecimal.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
        //            }
        //            else
        //            {
        //                txtValor.Text = "R$ 0,00";
        //            }

        //            txtDescricao.Text = item.SubItems[6].Text;
        //            cbxFormaPagamento.Text = item.SubItems[7].Text;
        //            cbxStatus.Text = item.SubItems[8].Text;

        //            btnExcluirPedido.Visible = true;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Erro: item selecionado não tem todos os dados esperados.");
        //        }
        //    }
        //}

        private void lstTipoDoce_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstTipoDoce.SelectedItems.Count > 0)
            {
                ListViewItem itemSelecionado = lstTipoDoce.SelectedItems[0];
                if (itemSelecionado != null)
                {
                    string precoTexto = itemSelecionado.SubItems[1].Text;
                    decimal preco = ConverterValorMonetario(precoTexto);
                    txtValor.Text = preco.ToString("C2", CultureInfo.GetCultureInfo("pt-BR"));
                }
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

