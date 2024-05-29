using ControleDeTarefas.Classes;
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

namespace ControleDeTarefas
{
    public partial class FormTarefasAdicionar : Form
    {
        public FormTarefasAdicionar()
        {
            InitializeComponent();
            ListarFuncionarios();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            //dados text box
            string funcionario = comboFuncionario.Text;
            string data = txtData.Text;
            string hora = txtHora.Text;
            string descricao = txtDescricaoTarefa.Text;


            //Usando a classe banco para realizar conexão com bd.
            using (MySqlConnection conn = Banco.GetConnection())
            {
                try
                {
                    Banco.OpenConnection(conn);

                    string query = "INSERT INTO tarefas (funcionario, data_tarefa, hora, descricao) VALUES (@Funcionario, @Data, @Hora, @Descricao)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Funcionario", funcionario);
                        cmd.Parameters.AddWithValue("@Data", data);
                        cmd.Parameters.AddWithValue("@Hora", hora);
                        cmd.Parameters.AddWithValue("@Descricao", descricao);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Tarefa gravada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro:" + ex.Message);
                }
                finally
                {
                    Banco.CloseConnection(conn);
                }
            }

        }
        private void ListarFuncionarios()
        {
            using (MySqlConnection conn = Banco.GetConnection())
            {
                try
                {
                    Banco.OpenConnection (conn);

                    string query = "SELECT nome FROM funcionarios";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                comboFuncionario.Items.Add(reader.GetString("nome"));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
                finally
                {
                    Banco.CloseConnection (conn);
                }
            }
        }

    }


}
