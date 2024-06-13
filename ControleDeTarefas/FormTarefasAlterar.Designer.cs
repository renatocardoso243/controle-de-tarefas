using System.Windows.Forms;

namespace ControleDeTarefas
{
    partial class FormTarefasAlterar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblAlterarTarefas = new Label();
            lblSelecioneFuncionario = new Label();
            comboFuncionarios = new ComboBox();
            lblSelecioneTarefa = new Label();
            dataGrid = new DataGridView();
            bancoBindingSource1 = new BindingSource(components);
            bancoBindingSource = new BindingSource(components);
            lblDescricaoTarefa = new Label();
            lblData = new Label();
            txtData = new TextBox();
            lblHora = new Label();
            txtHora = new TextBox();
            lblConcluido = new Label();
            comboConcluido = new ComboBox();
            txtDescricaoTarefa = new TextBox();
            btnAlterar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblAlterarTarefas
            // 
            lblAlterarTarefas.AutoSize = true;
            lblAlterarTarefas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlterarTarefas.Location = new Point(12, 9);
            lblAlterarTarefas.Name = "lblAlterarTarefas";
            lblAlterarTarefas.Size = new Size(140, 25);
            lblAlterarTarefas.TabIndex = 0;
            lblAlterarTarefas.Text = "Alterar Tarefas";
            // 
            // lblSelecioneFuncionario
            // 
            lblSelecioneFuncionario.AutoSize = true;
            lblSelecioneFuncionario.Location = new Point(12, 48);
            lblSelecioneFuncionario.Name = "lblSelecioneFuncionario";
            lblSelecioneFuncionario.Size = new Size(131, 15);
            lblSelecioneFuncionario.TabIndex = 1;
            lblSelecioneFuncionario.Text = "Selecione o funcionário\r\n";
            // 
            // comboFuncionarios
            // 
            comboFuncionarios.FormattingEnabled = true;
            comboFuncionarios.Location = new Point(12, 66);
            comboFuncionarios.Name = "comboFuncionarios";
            comboFuncionarios.Size = new Size(236, 23);
            comboFuncionarios.TabIndex = 2;
            this.comboFuncionarios.SelectedIndexChanged += new System.EventHandler(this.comboFuncionarios_SelectedIndexChanged);
            // 
            // lblSelecioneTarefa
            // 
            lblSelecioneTarefa.AutoSize = true;
            lblSelecioneTarefa.Location = new Point(12, 92);
            lblSelecioneTarefa.Name = "lblSelecioneTarefa";
            lblSelecioneTarefa.Size = new Size(148, 15);
            lblSelecioneTarefa.TabIndex = 3;
            lblSelecioneTarefa.Text = "Selecione a tarefa desejada";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGrid.Columns[0].Width = 40;
            //dataGrid.Columns[1].Width = 90;
            //dataGrid.Columns[2].Width = 60;
            //dataGrid.Columns[3].Width = 250;
            //dataGrid.Columns[4].Width = 90;
            dataGrid.Location = new Point(12, 110);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(776, 150);
            dataGrid.TabIndex = 4;
            // 
            // lblDescricaoTarefa
            // 
            lblDescricaoTarefa.AutoSize = true;
            lblDescricaoTarefa.Location = new Point(12, 263);
            lblDescricaoTarefa.Name = "lblDescricaoTarefa";
            lblDescricaoTarefa.Size = new Size(107, 15);
            lblDescricaoTarefa.TabIndex = 5;
            lblDescricaoTarefa.Text = "Descrição da terefa";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(686, 263);
            lblData.Name = "lblData";
            lblData.Size = new Size(31, 15);
            lblData.TabIndex = 6;
            lblData.Text = "Data";
            // 
            // txtData
            // 
            txtData.Location = new Point(686, 281);
            txtData.Name = "txtData";
            txtData.Size = new Size(100, 23);
            txtData.TabIndex = 7;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(686, 307);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(33, 15);
            lblHora.TabIndex = 8;
            lblHora.Text = "Hora";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(686, 325);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(100, 23);
            txtHora.TabIndex = 9;
            // 
            // lblConcluido
            // 
            lblConcluido.AutoSize = true;
            lblConcluido.Location = new Point(686, 351);
            lblConcluido.Name = "lblConcluido";
            lblConcluido.Size = new Size(62, 15);
            lblConcluido.TabIndex = 10;
            lblConcluido.Text = "Concluído";
            // 
            // comboConcluido
            // 
            comboConcluido.FormattingEnabled = true;
            comboConcluido.Items.AddRange(new object[] { "Sim", "Não" });
            comboConcluido.Location = new Point(686, 369);
            comboConcluido.Name = "comboConcluido";
            comboConcluido.Size = new Size(102, 23);
            comboConcluido.TabIndex = 11;
            // 
            // txtDescricaoTarefa
            // 
            txtDescricaoTarefa.Location = new Point(12, 281);
            txtDescricaoTarefa.Multiline = true;
            txtDescricaoTarefa.Name = "txtDescricaoTarefa";
            txtDescricaoTarefa.Size = new Size(668, 111);
            txtDescricaoTarefa.TabIndex = 12;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(630, 415);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 13;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += new EventHandler(btnAlterar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(711, 415);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormTarefasAlterar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlterar);
            Controls.Add(txtDescricaoTarefa);
            Controls.Add(comboConcluido);
            Controls.Add(lblConcluido);
            Controls.Add(txtHora);
            Controls.Add(lblHora);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(lblDescricaoTarefa);
            Controls.Add(dataGrid);
            Controls.Add(lblSelecioneTarefa);
            Controls.Add(comboFuncionarios);
            Controls.Add(lblSelecioneFuncionario);
            Controls.Add(lblAlterarTarefas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTarefasAlterar";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarefas :: Alterar";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bancoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAlterarTarefas;
        private Label lblSelecioneFuncionario;
        private ComboBox comboFuncionarios;
        private Label lblSelecioneTarefa;
        private DataGridView dataGrid;
        private Label lblDescricaoTarefa;
        private Label lblData;
        private TextBox txtData;
        private Label lblHora;
        private TextBox txtHora;
        private Label lblConcluido;
        private ComboBox comboConcluido;
        private TextBox txtDescricaoTarefa;
        private Button btnAlterar;
        private Button btnCancelar;
        private BindingSource bancoBindingSource;
        private BindingSource bancoBindingSource1;
        private DataGridViewTextBoxColumn data_tarefa;
    }

}