using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_WinF_BingoMania
{
    public partial class Gerador : Form
    {
        public Gerador()
        {
            InitializeComponent();
        }
        public static List<int> rnd = new List<int>();
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int num = random.Next(1, 99);
            try
            {
                if (rnd.Contains(num) || !rnd.Contains(num))
                {
                    do
                    {
                        num = random.Next(1, 99);
                    } while (rnd.Contains(num));
                    lbl_gerar.Text = num.ToString();
                    rnd.Add(num);
                }
                else if(rnd.Count == 99)
                {
                    MessageBox.Show("Ninguem ganhou");
                    this.Close();
                    Player.ActiveForm.Close();
                    Menu mainMenu = new Menu();
                    mainMenu.Show();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Erro");
                this.Close();
                Player.ActiveForm.Close();
            }
            
        } //Verifica se o num existe na lista, false = mostra num. & add a list, true = gera outro num.

        
    }
}
