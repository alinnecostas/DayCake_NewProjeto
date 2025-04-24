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
    public partial class CadastroCliente: Form
    {
        public CadastroCliente()
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
