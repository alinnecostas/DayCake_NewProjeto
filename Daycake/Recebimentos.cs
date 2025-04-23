using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daycake
{
    public partial class Recebimentos : Form
    {
        MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=1007;database=daycake";

        public Recebimentos()
        {
            InitializeComponent();

            lstRecebimentos.View = View.Details;
            lstRecebimentos.LabelEdit = true;
            lstRecebimentos.AllowColumnReorder = true;
            lstRecebimentos.FullRowSelect = true;
            lstRecebimentos.GridLines = true;

            lstRecebimentos.Columns.Add("idPedido", 30, HorizontalAlignment.Left);
            lstRecebimentos.Columns.Add("idCliente", 150, HorizontalAlignment.Left);
            lstRecebimentos.Columns.Add("data_pedido", 150, HorizontalAlignment.Left);
            lstRecebimentos.Columns.Add("status", 150, HorizontalAlignment.Left);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }
    }
}
