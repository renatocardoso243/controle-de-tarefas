namespace ControleDeTarefas
{
    partial class FormFuncionariosManutencao
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
            lblManutencaoFuncionarios = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblFuncionarios = new Label();
            comboFuncionarios = new ComboBox();
            lblCargo = new Label();
            txtCargo = new TextBox();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            btnCancelar = new Button();
            btnFechar = new Button();
            SuspendLayout();
            // 
            // lblManutencaoFuncionarios
            // 
            lblManutencaoFuncionarios.AutoSize = true;
            lblManutencaoFuncionarios.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold);
            lblManutencaoFuncionarios.Location = new Point(12, 9);
            lblManutencaoFuncionarios.Name = "lblManutencaoFuncionarios";
            lblManutencaoFuncionarios.Size = new Size(502, 52);
            lblManutencaoFuncionarios.TabIndex = 0;
            lblManutencaoFuncionarios.Text = "Manutenção de Funcionários";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F);
            lblCodigo.Location = new Point(12, 69);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(60, 21);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(12, 93);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(12, 141);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 165);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(547, 23);
            txtNome.TabIndex = 4;
            // 
            // lblFuncionarios
            // 
            lblFuncionarios.AutoSize = true;
            lblFuncionarios.Font = new Font("Segoe UI", 12F);
            lblFuncionarios.Location = new Point(571, 69);
            lblFuncionarios.Name = "lblFuncionarios";
            lblFuncionarios.Size = new Size(99, 21);
            lblFuncionarios.TabIndex = 5;
            lblFuncionarios.Text = "Funcionários";
            // 
            // comboFuncionarios
            // 
            comboFuncionarios.FormattingEnabled = true;
            comboFuncionarios.Location = new Point(571, 93);
            comboFuncionarios.Name = "comboFuncionarios";
            comboFuncionarios.Size = new Size(206, 23);
            comboFuncionarios.TabIndex = 6;
            comboFuncionarios.SelectedIndexChanged += comboFuncionarios_SelectedIndexChanged;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 12F);
            lblCargo.Location = new Point(12, 212);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(52, 21);
            lblCargo.TabIndex = 7;
            lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(12, 236);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(547, 23);
            txtCargo.TabIndex = 8;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(303, 284);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(90, 32);
            btnNovo.TabIndex = 9;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(399, 284);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 32);
            btnEditar.TabIndex = 10;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(495, 284);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(90, 32);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(591, 284);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 32);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(687, 284);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(90, 32);
            btnFechar.TabIndex = 13;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // FormFuncionariosManutencao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(comboFuncionarios);
            Controls.Add(lblFuncionarios);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblManutencaoFuncionarios);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFuncionariosManutencao";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Funcionários :: Manutenção";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblManutencaoFuncionarios;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblFuncionarios;
        private ComboBox comboFuncionarios;
        private Label lblCargo;
        private TextBox txtCargo;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private Button btnCancelar;
        private Button btnFechar;
    }
}