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
    public partial class FormTarefasAlterar : Form
    {
        private Database database;

        public FormTarefasAlterar()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=1234;database=pcomercial;";
            database = new Database(connectionString);
            LoadFuncionarios();

            comboFuncionarios.SelectedIndexChanged += comboFuncionarios_SelectedIndexChanged;
            dataGrid.CellClick += dataGrid_CellClick;
        }

        private void LoadFuncionarios()
        {
            database.ExecuteQuery(command =>
            {
                command.CommandText = "SELECT DISTINCT f.nome, f.codigo FROM funcionarios f JOIN tarefas t ON f.codigo = t.funcionario";
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

        private void comboFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFuncionarios.SelectedItem != null)
            {
                int funcionarioId = (int)((dynamic)comboFuncionarios.SelectedItem).Value;
                LoadTarefas(funcionarioId);
                LoadTarefa(funcionarioId);
            }
        }

        private void LoadTarefas(int funcionarioId)
         {
             DataTable dataTable = database.ExecuteQueryToDataTable(
                 "SELECT codigo, data_tarefa, hora, descricao, concluido FROM tarefas WHERE funcionario = @funcionario",
                 command => command.Parameters.AddWithValue("@funcionario", funcionarioId)
             );

             dataGrid.DataSource = dataTable;

             if (dataGrid.Columns["codigo"] != null)
             {
                 dataGrid.Columns["codigo"].HeaderText = "Cód";
                 dataGrid.Columns["data_tarefa"].HeaderText = "Data";
                 dataGrid.Columns["hora"].HeaderText = "Hora";
                 dataGrid.Columns["descricao"].HeaderText = "Descrição";
                 dataGrid.Columns["concluido"].HeaderText = "Concluído";
             }

             dataGrid.ClearSelection();
             ClearFields();
         }

        private void LoadTarefa(int funcionarioId)
        {
            database.ExecuteQuery(command =>
            {
                command.CommandText = "SELECT descricao, data_tarefa, hora, concluido FROM tarefas WHERE funcionario = @funcionario";
                command.Parameters.AddWithValue("@funcionario", funcionarioId);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtDescricaoTarefa.Text = reader["descricao"].ToString();
                        txtData.Text = reader["data_tarefa"].ToString();
                        txtHora.Text = reader["hora"].ToString();
                        comboConcluido.SelectedItem = (bool)reader["concluido"] ? "Sim" : "Não";
                    }
                    else
                    {
                        ClearFields();
                        MessageBox.Show("Nenhuma tarefa encontrada para este funcionário.");
                    }
                }
            });
        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                // Obtém o índice da linha selecionada
                int rowIndex = dataGrid.SelectedRows[0].Index;

                // Verifica se a linha selecionada contém o código da tarefa
                if (dataGrid.Rows[rowIndex].Cells["codigo"].Value != DBNull.Value)
                {
                    int tarefaId = Convert.ToInt32(dataGrid.Rows[rowIndex].Cells["codigo"].Value);
                    string descricao = txtDescricaoTarefa.Text;
                    string dataTarefa = txtData.Text;
                    string hora = txtHora.Text;
                    bool concluido = comboConcluido.SelectedItem.ToString() == "Sim";

                    // Atualiza apenas a linha selecionada no banco de dados
                    database.ExecuteQuery(command =>
                    {
                        command.CommandText = "UPDATE tarefas SET descricao = @descricao, data_tarefa = @data_tarefa, hora = @hora, concluido = @concluido WHERE codigo = @codigo";
                        command.Parameters.AddWithValue("@descricao", descricao);
                        command.Parameters.AddWithValue("@data_tarefa", dataTarefa);
                        command.Parameters.AddWithValue("@hora", hora);
                        command.Parameters.AddWithValue("@concluido", concluido);
                        command.Parameters.AddWithValue("@codigo", tarefaId);
                        command.ExecuteNonQuery();
                    });

                    MessageBox.Show("Tarefa alterada com sucesso!");

                    // Recarrega as tarefas do funcionário após a alteração
                    if (comboFuncionarios.SelectedItem != null)
                    {
                        int funcionarioId = (int)((dynamic)comboFuncionarios.SelectedItem).Value;
                        LoadTarefas(funcionarioId);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma tarefa para alterar.", "Nenhuma tarefa selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[e.RowIndex];
              

                txtData.Text = row.Cells["data_tarefa"].Value.ToString();
                txtHora.Text = row.Cells["hora"].Value.ToString();
                txtDescricaoTarefa.Text = row.Cells["descricao"].Value.ToString();
                comboConcluido.Text = row.Cells["concluido"].Value.ToString();
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGrid.SelectedRows[0];
            
                txtData.Text = row.Cells["data_tarefa"].Value.ToString();
                txtHora.Text = row.Cells["hora"].Value.ToString();
                txtDescricaoTarefa.Text = row.Cells["descricao"].Value.ToString();
                comboConcluido.Text = row.Cells["concluido"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtDescricaoTarefa.Clear();
            comboConcluido.SelectedIndex = -1;
        }
    }

}
