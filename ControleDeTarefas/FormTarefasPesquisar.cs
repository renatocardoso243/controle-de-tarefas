using ControleDeTarefas.Classes;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ControleDeTarefas
{
    public partial class FormTarefasPesquisar : Form
    {
        private Database database;
        public FormTarefasPesquisar()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=1234;database=pcomercial;";
            database = new Database(connectionString);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string descricaoTarefa = txtDescricaoTarefa.Text.Trim();

            DataTable dataTable = PesquisarTarefas(descricaoTarefa);
            dataGrid.DataSource = dataTable;

        }

        private DataTable PesquisarTarefas(string descricao)
        {
            string query = "SELECT Tarefas.codigo, Funcionarios.nome, Tarefas.data_tarefa, " +
                           "Tarefas.hora, Tarefas.descricao, Tarefas.concluido " +
                           "FROM Funcionarios " +
                           "INNER JOIN Tarefas ON Funcionarios.codigo = Tarefas.funcionario " +
                           "WHERE Tarefas.descricao LIKE @descricao";


            return database.ExecuteQueryToDataTable(query, command =>
            {
                command.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
            });
        }

    }
}
