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
            DialogResult res = MessageBox.Show("Tem certeza que deseja sair da aplica��o?", "Controle de Tarefas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarefasAlterar frm = new FormTarefasAlterar();
            frm.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTarefasPesquisar frm = new FormTarefasPesquisar();
            frm.ShowDialog();
        }

        private void manuten��oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionariosManutencao frm = new FormFuncionariosManutencao();
            frm.ShowDialog();
        }
    }
}
