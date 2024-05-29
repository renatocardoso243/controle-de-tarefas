namespace ControleDeTarefas
{
    partial class FormTarefasAdicionar
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
            lblAdicionarTarefas = new Label();
            lblFuncionario = new Label();
            comboFuncionario = new ComboBox();
            lblDescricaoTarefa = new Label();
            txtDescricaoTarefa = new TextBox();
            lblData = new Label();
            txtData = new TextBox();
            lblHora = new Label();
            txtHora = new TextBox();
            btnCancelar = new Button();
            btnAdicionar = new Button();
            SuspendLayout();
            // 
            // lblAdicionarTarefas
            // 
            lblAdicionarTarefas.AutoSize = true;
            lblAdicionarTarefas.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdicionarTarefas.Location = new Point(12, 9);
            lblAdicionarTarefas.Name = "lblAdicionarTarefas";
            lblAdicionarTarefas.Size = new Size(316, 52);
            lblAdicionarTarefas.TabIndex = 0;
            lblAdicionarTarefas.Text = "Adicionar Tarefas";
            // 
            // lblFuncionario
            // 
            lblFuncionario.AutoSize = true;
            lblFuncionario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionario.Location = new Point(12, 72);
            lblFuncionario.Name = "lblFuncionario";
            lblFuncionario.Size = new Size(92, 21);
            lblFuncionario.TabIndex = 1;
            lblFuncionario.Text = "Funcionário";
            // 
            // comboFuncionario
            // 
            comboFuncionario.FormattingEnabled = true;
            comboFuncionario.Location = new Point(12, 96);
            comboFuncionario.Name = "comboFuncionario";
            comboFuncionario.Size = new Size(358, 23);
            comboFuncionario.TabIndex = 2;
            // 
            // lblDescricaoTarefa
            // 
            lblDescricaoTarefa.AutoSize = true;
            lblDescricaoTarefa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricaoTarefa.Location = new Point(12, 142);
            lblDescricaoTarefa.Name = "lblDescricaoTarefa";
            lblDescricaoTarefa.Size = new Size(143, 21);
            lblDescricaoTarefa.TabIndex = 3;
            lblDescricaoTarefa.Text = "Descrição da Tarefa";
            // 
            // txtDescricaoTarefa
            // 
            txtDescricaoTarefa.Location = new Point(12, 166);
            txtDescricaoTarefa.Multiline = true;
            txtDescricaoTarefa.Name = "txtDescricaoTarefa";
            txtDescricaoTarefa.Size = new Size(776, 195);
            txtDescricaoTarefa.TabIndex = 4;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblData.Location = new Point(424, 72);
            lblData.Name = "lblData";
            lblData.Size = new Size(42, 21);
            lblData.TabIndex = 5;
            lblData.Text = "Data";
            // 
            // txtData
            // 
            txtData.Location = new Point(424, 96);
            txtData.Name = "txtData";
            txtData.Size = new Size(142, 23);
            txtData.TabIndex = 6;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHora.Location = new Point(625, 72);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(44, 21);
            lblHora.TabIndex = 7;
            lblHora.Text = "Hora";
            // 
            // txtHora
            // 
            txtHora.Location = new Point(625, 96);
            txtHora.Name = "txtHora";
            txtHora.Size = new Size(133, 23);
            txtHora.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(675, 392);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(534, 392);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(113, 34);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // FormTarefasAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdicionar);
            Controls.Add(btnCancelar);
            Controls.Add(txtHora);
            Controls.Add(lblHora);
            Controls.Add(txtData);
            Controls.Add(lblData);
            Controls.Add(txtDescricaoTarefa);
            Controls.Add(lblDescricaoTarefa);
            Controls.Add(comboFuncionario);
            Controls.Add(lblFuncionario);
            Controls.Add(lblAdicionarTarefas);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTarefasAdicionar";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tarefas :: Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAdicionarTarefas;
        private Label lblFuncionario;
        private ComboBox comboFuncionario;
        private Label lblDescricaoTarefa;
        private TextBox txtDescricaoTarefa;
        private Label lblData;
        private TextBox txtData;
        private Label lblHora;
        private TextBox txtHora;
        private Button btnCancelar;
        private Button btnAdicionar;
    }
}