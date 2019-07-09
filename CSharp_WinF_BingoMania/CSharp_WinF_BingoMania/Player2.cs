using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CSharp_WinF_BingoMania
{
    public partial class Player2 : Form
    {
        public Player2()
        {
            InitializeComponent();
            gerarButRandom();
            btn_bingo.Enabled = false;
            txt_nome.Text = "Insira o seu nome";
        }
        public static List<int> numEsc = new List<int>();


        private void Btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
            Gerador.ActiveForm.Close();
            Menu mainMenu = new Menu();
            mainMenu.Show();
        } // Voltar para o menu



        private void btn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Name == "b1")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b2")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b3")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b4")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b5")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b6")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b7")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b8")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            else if ((sender as Button).Name == "b9")
            {
                numEsc.Add(int.Parse((sender as Button).Text));
            }
            (sender as Button).BackColor = Color.Gray;
            (sender as Button).Enabled = false;
            botoesPrem();

        } // Ver qual botao foi premido e add a lista numEsc || Verificar se 9 botoes foram primidos antes de clicar em bingo


        private void gerarButRandom()
        {
            Random random = new Random();
            int numero = random.Next(1, 99);
            b1.Text = numero.ToString();
            do
            {
                b2.Text = random.Next(1, 99).ToString();
            } while (b2.Text == b1.Text);
            do
            {
                b3.Text = random.Next(1, 99).ToString();
            } while (b3.Text == b1.Text && b3.Text == b2.Text);
            do
            {
                b4.Text = random.Next(1, 99).ToString();
            } while (b4.Text == b1.Text && b4.Text == b2.Text && b4.Text == b3.Text);
            do
            {
                b5.Text = random.Next(1, 99).ToString();
            } while (b5.Text == b1.Text && b5.Text == b2.Text && b5.Text == b3.Text && b5.Text == b4.Text);
            do
            {
                b6.Text = random.Next(1, 99).ToString();
            } while (b6.Text == b1.Text && b6.Text == b2.Text && b6.Text == b3.Text && b6.Text == b4.Text && b6.Text == b5.Text);
            do
            {
                b7.Text = random.Next(1, 99).ToString();
            } while (b7.Text == b1.Text && b7.Text == b2.Text && b7.Text == b3.Text && b7.Text == b4.Text && b7.Text == b5.Text && b7.Text == b6.Text);
            do
            {
                b8.Text = random.Next(1, 99).ToString();
            } while (b8.Text == b1.Text && b8.Text == b2.Text && b8.Text == b3.Text && b8.Text == b4.Text && b8.Text == b5.Text && b8.Text == b6.Text && b8.Text == b7.Text);
            do
            {
                b9.Text = random.Next(1, 99).ToString();
            } while (b9.Text == b1.Text && b9.Text == b2.Text && b9.Text == b3.Text && b9.Text == b4.Text && b9.Text == b5.Text && b9.Text == b6.Text && b9.Text == b7.Text && b9.Text == b8.Text);

        } //Gerar Butoes com Num. Randoms

        private void botoesPrem()
        {
            if (numEsc.Count == 9 && !string.IsNullOrEmpty(txt_nome.Text))
            {
                btn_bingo.Enabled = true;
            }
            else
            {
                btn_bingo.Enabled = false;
            }
        } //verificaao de butPremid

        private void Btn_bingo_Click(object sender, EventArgs e)
        {
            checkResultados();
        }

        public void checkResultados()
        {
            int aux = 0;
            foreach (var item in Gerador.rnd)
            {
                if (numEsc.Contains(item))
                {
                    aux++;
                }
            }
            if (aux == 9)
            {
                MessageBox.Show($"Ganhou o {txt_nome.Text}");
                inserirResultados();
            }
            else
            {
                MessageBox.Show($"Errou em numeros {txt_nome.Text}");
            }
        } // verifica os resultados

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {
            botoesPrem();
        } //Apenas deixa clicar bingo depois da txtBox estar preenchida      

        private void Btn_sair_Click_1(object sender, EventArgs e)
        {
            if (Gerador.ActiveForm.IsAccessible)
            {
                this.Close();
                Player.ActiveForm.Close();
                Gerador.ActiveForm.Close();
                Menu mainMenu = new Menu();
                mainMenu.Show();
            }
            else
            {
                this.Close();
                Player.ActiveForm.Close();
                Menu mainMenu = new Menu();
                mainMenu.Show();
            }
            
        }

        private void inserirResultados()
        {
            string connStr = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=BingoMania;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand();
            string sql = $"INSERT INTO BingoResults (nome, dia_e_Hora) VALUES ('{txt_nome.Text}','{DateTime.Now}');";

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        } //inserir resultados na BD
    }
}
