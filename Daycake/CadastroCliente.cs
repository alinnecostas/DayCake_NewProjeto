using MySql.Data.MySqlClient;
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

namespace Daycake
{
    public partial class CadastroConsultaClientes : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;database=daycake";
        public int? id_cliente_selecionado = null;

        public CadastroConsultaClientes()
        {
            InitializeComponent();

            lstListaClientes.View = View.Details;
            lstListaClientes.Columns.Clear();
            lstListaClientes.Items.Clear();

            lstListaClientes.Columns.Add("ID", 50);
            lstListaClientes.Columns.Add("Nome", 50);
            lstListaClientes.Columns.Add("Telefone", 100);
            lstListaClientes.Columns.Add("Email", 100);
            lstListaClientes.Columns.Add("Endereço", 100);
            lstListaClientes.Columns.Add("Bairro", 30);
            lstListaClientes.Columns.Add("Número", 80);
            lstListaClientes.Columns.Add("Data Cadastro", 50);

        }


        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar a conexão com o MySQL
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                // Habilitando o Update para o meu botão salvar

                if (id_cliente_selecionado == null)
                {
                    // insert
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "INSERT INTO cliente " +
                        "(nome, telefone, email, endereco, bairro, numero, data_cadastro) " +
                        "VALUES " +
                        "(@nome, @telefone, @email, @endereco, @bairro, @numero, @data_cadastro)";

                    cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@telefone", mtxTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@data_cadastro", mtbDataCadastro.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente Inserido com Sucesso", "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    // update
                    cmd.Parameters.Clear(); // limpa os parâmetros antigos
                    cmd.CommandText =
                        "UPDATE cliente " +
                        "SET nome = @nome, telefone = @telefone, email = @email, endereco = @endereco, bairro = @bairro, numero = @numero, data_cadastro = @data_cadastro " +
                        "WHERE idCliente = @idCliente";

                    cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                    cmd.Parameters.AddWithValue("@telefone", mtxTelefone.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                    cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                    cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                    cmd.Parameters.AddWithValue("@data_cadastro", mtbDataCadastro.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente Atualizado com Sucesso", "Sucesso",
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



        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                string termoBusca = "%" + txtBusca.Text + "%";

                // Criar a conexão com o MySQL
                Conexao = new MySqlConnection(data_source);

                // Query com busca por nome, email ou telefone
                string sql = @"SELECT idCliente, nome, telefone, email, endereco, bairro, data_cadastro 
                       FROM Cliente 
                       WHERE nome LIKE @termo 
                       OR email LIKE @termo 
                       OR telefone LIKE @termo";

                Conexao.Open();

                // Buscar as informações
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@termo", termoBusca);

                // Armazena as informações da busca
                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa a lista antes de adicionar novos resultados
                lstListaClientes.Items.Clear();

                while (reader.Read())
                {
                    string[] row = new string[8];

                    // Preenche usando índices numéricos
                    row[0] = reader.GetInt32(0).ToString();       // idCliente
                    row[1] = reader.GetString(1);                // nome
                    row[2] = reader.GetString(2);                // telefone
                    row[3] = reader.GetString(3);                // email
                    row[4] = reader.GetString(4);                // endereco
                    row[5] = reader.GetString(5);                // bairro
                    row[6] = "";                                // número (não existe)
                    row[7] = reader.GetString(6);               // data_cadastro

                    lstListaClientes.Items.Add(new ListViewItem(row));
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

        private void carregar_contatos()

        {
            try
            {

                // Criar a conexão com o MySQL
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM contato ORDER BY id ASC";

                Conexao.Open();

                // Buscar as informações
                MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                // armazena as informacoes que temos na busca para mostrar na tela
                MySqlDataReader reader = buscar.ExecuteReader();

                // como iremos mostrar os dados na tela para o usuário
                lstListaClientes.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                         // obtendo as informações do banco de dados (vetor de strings)
                         reader.GetInt32(0).ToString(),
                         reader.GetString(1),
                         reader.GetString(2),
                         reader.GetString(3),
                         reader.GetString(4),
                         reader.GetString(5),
                         reader.GetString(7)
                     };

                    var linha_list_view = new ListViewItem(row);
                    lstListaClientes.Items.Add(linha_list_view);

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


        private void lstListaClientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = lstListaClientes.SelectedItems;


            foreach (ListViewItem item in itens_selecionados)
            {
                id_cliente_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNomeCompleto.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                mtxTelefone.Text = item.SubItems[3].Text;
                txtEndereco.Text = item.SubItems[4].Text;
                txtBairro.Text = item.SubItems[5].Text;
                txtNumero.Text = item.SubItems[6].Text;
                mtbDataCadastro.Text = item.SubItems[7].Text;

                //  MessageBox.Show("Id Selecionado = " + id_contato_selecionado);
            }

            // menuStrip1.Visible = true;

                     
        }

        private void lstContatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            ListView.SelectedListViewItemCollection itens_selecionados = lstListaClientes.SelectedItems;

            foreach (ListViewItem item in itens_selecionados)
            {
                id_cliente_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                // extrai o valor de cada uma das variáveis (colunas)
                txtNomeCompleto.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                mtxTelefone.Text = item.SubItems[3].Text;       
                txtEndereco.Text = item.SubItems[4].Text;
                txtBairro.Text = item.SubItems[5].Text;
                txtNumero.Text = item.SubItems[6].Text;
                mtbDataCadastro.Text = item.SubItems[7].Text;

                //  MessageBox.Show("Id Selecionado = " + id_contato_selecionado);
            }

            //btnExcluir.Visible = true;

        }

        private void excluir_contato()
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
                    cmd.Parameters.AddWithValue("@id", id_cliente_selecionado);

                    cmd.ExecuteNonQuery();


                    MessageBox.Show(
                            "Contato Excluido com Sucesso!",
                            "Sucesso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                            );


                   carregar_contatos();


                   // zerar_forms();
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

        private void button1_Click(object sender, EventArgs e)
        {
            excluir_contato();
        }


        private void zerarFormulario()
        {
            //id_contato_selecionado = null;
            //txtNome.Text = String.Empty;
            //txtEmail.Text = "";
            //txtTelefone.Text = "";
            //txtNome.Focus();

        }
    }
}
