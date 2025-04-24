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
    public partial class Pedido : Form
    {
        // No construtor de Pedidos.cs  
        public Pedido()
        {
            InitializeComponent();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            this.Close();
        }
    }
}
