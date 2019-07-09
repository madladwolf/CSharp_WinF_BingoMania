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

namespace CSharp_WinF_BingoMania
{
    public partial class Vitorias : Form
    {
        public Vitorias()
        {
            InitializeComponent();
            Resultados_Load();
        }

        private void Btn_voltar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Menu mainMenu = new Menu();
                mainMenu.Show();
            }
            catch (Exception)
            {

                this.Close();
                Menu mainMenu = new Menu();
                mainMenu.Show();
            }
            
        }


        private void Resultados_Load()
        {
            try
            {
                string connStr = "Data Source=(localdb)\\ProjectsV13;Initial Catalog=BingoMania;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand cmd = new SqlCommand();

                string sql = "SELECT * FROM BingoResults";
                SqlDataAdapter daResultados = new SqlDataAdapter(sql, conn);
                DataSet dsResultados = new DataSet();

                conn.Open();
                daResultados.Fill(dsResultados, "BingoResults");
                conn.Close();

                dataGridView1.DataSource = dsResultados;
                dataGridView1.DataMember = "BingoResults";
            }
            catch (Exception)
            {
                this.Close();
                throw;
            }
            
        } // load dos resultados
    }
}
