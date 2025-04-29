using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Daycake
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            btnAcessar.Click += new EventHandler(btnAcessar_Click); // Conectar evento ao botão  
            btnAcessar.Paint += new PaintEventHandler(btnAcessar_Paint); // Conectar evento Paint ao botão  
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {

            FormMenu menu = new FormMenu();
            menu.Show(this);
        }

        private void btnAcessar_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Cores personalizadas  
                Color fillColor = Color.FromArgb(141, 98, 98); // Cor de preenchimento  
                Color borderColor = Color.FromArgb(255, 235, 223); // Cor da borda  
                Color textColor = Color.FromArgb(255, 235, 223); // Cor do texto  

                Brush fillBrush = new SolidBrush(fillColor);
                Pen borderPen = new Pen(borderColor, 1); // Borda mais fina (1px)  
                int cornerRadius = 15; // Raio menor para bordas mais delicadas  

                // Desenhar o fundo arredondado  
                GraphicsPath path = new GraphicsPath();
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(btn.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(btn.Width - cornerRadius, btn.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, btn.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
                path.CloseAllFigures();

                g.FillPath(fillBrush, path);
                g.DrawPath(borderPen, path);

                // Desenhar o texto centralizado  
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                Font font = btn.Font; // Usa a fonte padrão do botão ou defina uma nova  
                g.DrawString("Acessar", font, new SolidBrush(textColor),
                            new RectangleF(0, 0, btn.Width, btn.Height), sf);
            }
        }

        private void btnAcessar_Click_1(object sender, EventArgs e)
        {
            //depois de abrir o menu, sem usar o hide:

            FormMenu menu = new FormMenu();


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }

}


/*
namespace Daycake
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }




        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "admin" && txtSenha.Text == "admin")
            {
                MessageBox.Show("Login realizado com sucesso!");

                Menu menu = new Menu();
                menu.Show();
               
            }

            else
            {
                MessageBox.Show("Usuario Não Autenticado!",
                      "Erro!", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                return;
            }

        }
    }
}
*/

