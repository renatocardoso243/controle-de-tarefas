using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ControleDeTarefas
{
    public partial class FormAdicionarFuncionario : Form
    {
        public FormAdicionarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //obter dados TextBox
            string nome = textNome.Text;
            string cargo = textCargo.Text;

            //string de conexão
            string connectionString = "server=localhost;database=pcomercial;user=root;password=1234";

            //inserir dados bd
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
               try
                {
                    conn.Open();

                    string query = "INSERT INTO funcionarios ( nome, cargo) VALUES (@Nome, @Cargo)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", nome);
                        cmd.Parameters.AddWithValue("@Cargo", cargo);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Funcionário cadastrado com Sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message); 
                }

            }
        }
    }
}
