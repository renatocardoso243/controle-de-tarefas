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
        private Database database;

        public FormTarefasAdicionar()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=1234;database=pcomercial;";
            database = new Database(connectionString);
            LoadFuncionarios();
        }

        private void LoadFuncionarios()
        {
            database.ExecuteQuery(command =>
            {
                command.CommandText = "SELECT codigo, nome FROM funcionarios";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboFuncionarios.Items.Add(new { Text = reader["nome"].ToString(), Value = reader["codigo"] });
                    }
                }
            });

            comboFuncionarios.DisplayMember = "Text";
            comboFuncionarios.ValueMember = "Value";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja adicionar a tarefa?","Controle de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                int funcionarioCod = ((dynamic)comboFuncionarios.SelectedItem).Value;
                string dataTarefa = txtData.Value.ToString("yyy-MM-dd");
                string hora = txtHora.Value.ToString("HH:mm");
                string descricao = txtDescricaoTarefa.Text;
                bool concluido = false;

                database.ExecuteQuery(command =>
                {
                    command.CommandText = "INSERT INTO tarefas (funcionario, data_tarefa, hora, descricao, concluido) VALUES (@funcionario, @data_tarefa, @hora, @descricao, @concluido)";
                    command.Parameters.AddWithValue("@funcionario", funcionarioCod);
                    command.Parameters.AddWithValue("@data_tarefa", dataTarefa);
                    command.Parameters.AddWithValue("@hora", hora);
                    command.Parameters.AddWithValue("@descricao", descricao);
                    command.Parameters.AddWithValue("@concluido", concluido);
                    command.ExecuteNonQuery();
                });

                MessageBox.Show("Tarefa adicionada com sucesso!");
                res = MessageBox.Show("Deseja adicionar uma nova tarefa?","Controle de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    comboFuncionarios.SelectedIndex = 0;
                    txtDescricaoTarefa.Clear();
                   
                }
                else
                {
                    this.Close();
                }
            }
        }

 
    }
}
