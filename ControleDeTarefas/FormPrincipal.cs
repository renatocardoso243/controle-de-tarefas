using Google.Protobuf.WellKnownTypes;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Controle de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarefasAdicionar frm = new FormTarefasAdicionar();
            frm.ShowDialog();
        }

        private void adicionarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdicionarFuncionario frm = new FormAdicionarFuncionario();
            frm.ShowDialog();
        }
    }
}
