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
        private string data_source = "datasource=localhost;username=root;password=;database=daycake";
        public int? id_cliente_selecionado = null;

        public CadastroConsultaClientes()
        {
            InitializeComponent();

            lstListaClientes.View = View.Details;
            lstListaClientes.Columns.Clear();
            lstListaClientes.Items.Clear();

            lstListaClientes.Columns.Add("ID", 50);
            lstListaClientes.Columns.Add("Nome", 200);
            lstListaClientes.Columns.Add("Telefone", 100);
            lstListaClientes.Columns.Add("Email", 200);
            lstListaClientes.Columns.Add("Endereço", 100);
            lstListaClientes.Columns.Add("Número", 80);
            lstListaClientes.Columns.Add("Bairro", 80);
            lstListaClientes.Columns.Add("Data Cadastro", 150);

            carregar_clientes();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string termoBusca = "%" + txtBuscar.Text + "%";

                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM cliente " +
                             "WHERE nome LIKE @termo OR telefone LIKE @termo OR email LIKE @termo " +
                             "OR endereco LIKE @termo OR numero LIKE @termo OR bairro LIKE @termo " +
                             "ORDER BY idCliente ASC";

                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@termo", termoBusca);

                MySqlDataReader reader = cmd.ExecuteReader();

                lstListaClientes.Items.Clear();

                while (reader.Read())
                {
                    string[] row = new string[8];

                    row[0] = reader.GetInt32(0).ToString();       // idCliente
                    row[1] = reader.GetString(1);                // nome
                    row[2] = reader.GetString(2);                // telefone
                    row[3] = reader.GetString(3);                // email
                    row[4] = reader.GetString(4);                // endereco
                    row[5] = reader.GetString(5);                // bairro
                    row[6] = reader.GetString(6);               // número
                    row[7] = reader.GetString(7);               // data_cadastro


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



        private void carregar_clientes()

        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string sql = "SELECT * FROM cliente ORDER BY idCliente ASC";

                Conexao.Open();

                MySqlCommand buscar = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = buscar.ExecuteReader();

                lstListaClientes.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetInt32(0).ToString(), //id
                        reader.GetString(1), // data de cadastro
                        reader.GetString(2), // nome
                        reader.GetString(3), // email
                        reader.GetString(4), // endereço
                        reader.GetString(5), // numero
                        reader.GetString(6), // bairro
                        reader.GetString(7), // telefone
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

        }

        private void lstContatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

            ListView.SelectedListViewItemCollection itens_selecionados = lstListaClientes.SelectedItems;


            foreach (ListViewItem item in itens_selecionados)
            {
                id_cliente_selecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNomeCompleto.Text = item.SubItems[1].Text;
                mtbTelefone.Text = item.SubItems[2].Text;            
                txtEmail.Text = item.SubItems[3].Text;
                txtEndereco.Text = item.SubItems[4].Text;
                txtNumero.Text = item.SubItems[5].Text;
                txtBairro.Text = item.SubItems[6].Text;
                mtbDataCadastro.Text = item.SubItems[7].Text;

            }
            //MessageBox.Show("Id selecionado " + id_cliente_selecionado);
            btnExcluir.Visible = true;
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.CommandText =
                    "INSERT INTO cliente " +
                    "(nome, telefone, email, endereco, numero, bairro, data_cadastro) " +
                    "VALUES " +
                    "(@nome, @telefone, @email, @endereco, @numero, @bairro, @data_cadastro)";

                cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                cmd.Parameters.AddWithValue("@telefone", mtbTelefone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@data_cadastro", mtbDataCadastro.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente inserido com sucesso!",
                                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message,
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


            private void excluir_cliente()
        {           
                try
                {
                    DialogResult conf = MessageBox.Show("Deseja excluir o registro?",
                                                        "Certeza?",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Warning);

                    if (conf == DialogResult.Yes)
                    {
                        Conexao = new MySqlConnection(data_source);
                        Conexao.Open();

                        // Verifica se o cliente tem pedidos vinculados
                        MySqlCommand checkCmd = new MySqlCommand(
                            "SELECT COUNT(*) FROM Pedido WHERE clienteid = @id", Conexao);
                        checkCmd.Parameters.AddWithValue("@id", id_cliente_selecionado);

                        int pedidosVinculados = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (pedidosVinculados > 0)
                        {
                            MessageBox.Show("Este cliente possui pedidos vinculados e não pode ser excluído.",
                                            "Atenção",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            return;
                        }

                        // Caso não tenha vínculo, faz a exclusão
                        MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM cliente WHERE idCliente = @id", Conexao);
                        cmd.Parameters.AddWithValue("@id", id_cliente_selecionado);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente excluído com sucesso!",
                                        "Sucesso",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                        zerar_forms();
                    }
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


            private void button1_Click(object sender, EventArgs e)
        {
            excluir_cliente();
        }


        private void zerar_forms()
        {
            id_cliente_selecionado = null;
            txtNomeCompleto.Text = "";
            txtEmail.Text = "";
            mtbTelefone.Text = "";
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtNumero.Text = "";
            mtbDataCadastro.Text = "";

            txtNomeCompleto.Focus();

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            excluir_cliente();
        }

        private void lstListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            zerar_forms();
        }

        private void btnAtualizarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (id_cliente_selecionado == null)
                {
                    MessageBox.Show("Selecione um cliente para atualizar.",
                                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.CommandText =
                    "UPDATE cliente SET " +
                    "nome = @nome, " +
                    "telefone = @telefone, " +
                    "email = @email, " +
                    "endereco = @endereco, " +
                    "numero = @numero, " +
                    "bairro = @bairro, " +
                    "data_cadastro = @data_cadastro " +
                    "WHERE idCliente = @id";

                cmd.Parameters.AddWithValue("@nome", txtNomeCompleto.Text);
                cmd.Parameters.AddWithValue("@telefone", mtbTelefone.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
                cmd.Parameters.AddWithValue("@numero", txtNumero.Text);
                cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
                cmd.Parameters.AddWithValue("@data_cadastro", mtbDataCadastro.Text);
                cmd.Parameters.AddWithValue("@id", id_cliente_selecionado); // GARANTA que isso esteja correto

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

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}