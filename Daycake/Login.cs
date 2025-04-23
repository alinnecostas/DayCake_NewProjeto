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
    public partial class FormLogin: Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Login realizado com sucesso!");

                FormMenu menu = new FormMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário não autenticado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
