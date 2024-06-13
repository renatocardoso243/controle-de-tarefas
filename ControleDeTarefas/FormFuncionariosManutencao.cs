using ControleDeTarefas.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class FormFuncionariosManutencao : Form
    {
        private Database database;

        public FormFuncionariosManutencao()
        {
            InitializeComponent();
            string connectionString = "server=localhost;user=root;password=1234;database=pcomercial;";
            database = new Database(connectionString);
            CarregarFuncionarios();
            HabilitarEdicao(false);

        }

        private void CarregarFuncionarios()
        {
            string query = "SELECT codigo, nome FROM funcionarios";
            DataTable dataTable = database.ExecuteQueryToDataTable(query);

            comboFuncionarios.DisplayMember = "nome";
            comboFuncionarios.ValueMember = "codigo";
            comboFuncionarios.DataSource = dataTable;
        }

        private void comboFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFuncionarios.SelectedIndex != -1)
            {
                int funcionarioId = Convert.ToInt32(comboFuncionarios.SelectedValue);
                CarregarDadosFuncionario(funcionarioId);
            }
        }

        private void CarregarDadosFuncionario(int funcionarioId)
        {
            string query = "SELECT codigo, nome, cargo FROM funcionarios WHERE codigo = @codigo";
            DataTable dataTable = database.ExecuteQueryToDataTable(query, command =>
            {
                command.Parameters.AddWithValue("@codigo", funcionarioId);
            });

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                txtCodigo.Text = row["codigo"].ToString();
                txtNome.Text = row["nome"].ToString();
                txtCargo.Text = row["cargo"].ToString();
            }
        }

        private void FormFuncionariosManutencao_Load(object sender, EventArgs e)
        {
            CarregarFuncionarios();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Botões funcionalidades
        private void btnNovo_Click(object sender, EventArgs e)
        {
           FormFuncionariosCadastrar frm = new FormFuncionariosCadastrar();
            frm.ShowDialog();
        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtNome.Text = "";
            txtCargo.Text = "";
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int funcionarioId = Convert.ToInt32(comboFuncionarios.SelectedValue);
                string novoNome = txtNome.Text.Trim();
                string novoCargo = txtCargo.Text.Trim();

                AtualizarFuncionario(funcionarioId, novoNome, novoCargo);

                MessageBox.Show("Funcionário atualizado com sucesso.");

                HabilitarEdicao(false);
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
            }
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtCargo.Text);
        }

        private void AtualizarFuncionario(int funcionarioId, string novoNome, string novoCargo)
        {
            string query = "UPDATE funcionarios SET nome = @nome, cargo = @cargo WHERE codigo = @codigo";
            database.ExecuteNonQuery(query, command =>
            {
                command.Parameters.AddWithValue("@nome", novoNome);
                command.Parameters.AddWithValue("@cargo", novoCargo);
                command.Parameters.AddWithValue("@codigo", funcionarioId);
            });
        }

        private int InserirFuncionario(string nome, string cargo)
        {
            string query = "INSERT INTO funcionarios (nome, cargo) VALUES (@nome, @cargo); SELECT LAST_INSERT_ID();";
            return database.ExecuteScalar<int>(query, command =>
            {
                command.Parameters.AddWithValue("@nome", nome);
                command.Parameters.AddWithValue("@cargo", cargo);
            });
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            HabilitarEdicao(false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (comboFuncionarios.SelectedIndex != -1)
            {
                int funcionarioId = Convert.ToInt32(comboFuncionarios.SelectedValue);
                HabilitarEdicao(true);
            }
        }

        private void HabilitarEdicao(bool habilitar)
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = habilitar;
            txtCargo.Enabled = habilitar;
            btnNovo.Enabled = !habilitar;
            btnSalvar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;
            btnFechar.Enabled = !habilitar;
        }
    }
}
