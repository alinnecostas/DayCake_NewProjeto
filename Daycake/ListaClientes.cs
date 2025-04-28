//using MySql.Data.MySqlClient;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Daycake
//{
//    public partial class FormListaClientes : Form
//    {
//        MySqlConnection Conexao;

//        private string data_source = "datasource=localhost;username=root;password=1007;database=Daycake";


//        public FormListaClientes()
//        {
//            InitializeComponent();

//            lstListaClientes.View = View.Details;
//            lstListaClientes.Columns.Clear();
//            lstListaClientes.Items.Clear();

//            lstListaClientes.Columns.Add("ID", 50);
//            lstListaClientes.Columns.Add("Nome", 50);
//            lstListaClientes.Columns.Add("Telefone", 100);
//            lstListaClientes.Columns.Add("Email", 100);
//            lstListaClientes.Columns.Add("Endereço", 100);
//            lstListaClientes.Columns.Add("Bairro", 30);
//            lstListaClientes.Columns.Add("Número", 80);
//            lstListaClientes.Columns.Add("Data Cadastro", 50);

//        }

//        private void FormListaClientes_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnBuscar_Click(object sender, EventArgs e)
//        {
//            Conexao = new MySqlConnection(data_source);
//            try
//            {
//                Conexao.Open();

//                string sql = "SELECT * FROM Cliente";

//                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
//                MySqlDataReader reader = cmd.ExecuteReader();

//                while (reader.Read())
//                {
//                    string[] row =
//                    {
//                        reader.GetInt32(0).ToString(), //id
//                        reader.GetString(1), // data de cadastro
//                        reader.GetString(2), // nome
//                        reader.GetString(3), // email
//                        reader.GetString(4), // endereço
//                        reader.GetString(5), // numero
//                        reader.GetString(6), // bairro
//                        reader.GetString(7), // telefone
//                       };
//                    var linha_list_view = new ListViewItem(row);
//                    lstListaClientes.Items.Add(linha_list_view);
//                }

//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show(ex.Message);
//            }
//            finally
//            {
//                Conexao.Close();
//            }

//        }
//    }
//}