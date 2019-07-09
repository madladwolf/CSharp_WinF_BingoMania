using System;
using System.Threading;
using System.Windows.Forms;

namespace CSharp_WinF_BingoMania
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vitorias vitorias = new Vitorias();
            vitorias.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Player player1 = new Player();
            Thread.Sleep(100);
            Player2 player2 = new Player2();
            Thread.Sleep(100);
            Gerador gerador = new Gerador();
            gerador.Show();
            player1.Show();
            player2.Show();
        }
    }
}
