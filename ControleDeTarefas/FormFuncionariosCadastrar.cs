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
using System.Xml.Linq;

namespace ControleDeTarefas
{
    public partial class FormFuncionariosCadastrar : Form
    {
        private Database database;
        public FormFuncionariosCadastrar()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=1234;database=pcomercial;";
            database = new Database(connectionString);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja adicionar este novo funcionário?", "Controle de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                string nome = txtNome.Text;
                string cargo = txtCargo.Text;


                database.ExecuteQuery(command =>
                {
                    command.CommandText = "INSERT INTO funcionarios (nome, cargo) VALUES (@nome, @cargo)";
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@cargo", cargo);
                    command.ExecuteNonQuery();
                });

                MessageBox.Show("Tarefa adicionada com sucesso!");
                res = MessageBox.Show("Deseja adicionar um novo funcionário?", "Controle de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    txtNome.Clear();
                    txtCargo.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
