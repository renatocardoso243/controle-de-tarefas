namespace ControleDeTarefas
{
    partial class FormFuncionariosCadastrar
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
            lblNovoFuncionario = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblCargo = new Label();
            txtCargo = new TextBox();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblNovoFuncionario
            // 
            lblNovoFuncionario.AutoSize = true;
            lblNovoFuncionario.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold);
            lblNovoFuncionario.Location = new Point(231, 48);
            lblNovoFuncionario.Name = "lblNovoFuncionario";
            lblNovoFuncionario.Size = new Size(315, 52);
            lblNovoFuncionario.TabIndex = 0;
            lblNovoFuncionario.Text = "Novo Funcionário";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(137, 146);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(53, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(196, 146);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(429, 23);
            txtNome.TabIndex = 2;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 12F);
            lblCargo.Location = new Point(140, 190);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(52, 21);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(198, 190);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(427, 23);
            txtCargo.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(296, 238);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(90, 32);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(392, 238);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 32);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormFuncionariosCadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnCadastrar);
            Controls.Add(txtCargo);
            Controls.Add(lblCargo);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(lblNovoFuncionario);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFuncionariosCadastrar";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manutenção :: Cadastro Funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNovoFuncionario;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblCargo;
        private TextBox txtCargo;
        private Button btnCadastrar;
        private Button btnCancelar;
    }
}