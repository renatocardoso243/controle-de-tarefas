namespace ControleDeTarefas
{
    partial class FormAdicionarFuncionario
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
            lblCadastrarFuncionario = new Label();
            lblNome = new Label();
            textNome = new TextBox();
            lblCargo = new Label();
            textCargo = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // lblCadastrarFuncionario
            // 
            lblCadastrarFuncionario.AutoSize = true;
            lblCadastrarFuncionario.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold);
            lblCadastrarFuncionario.Location = new Point(12, 9);
            lblCadastrarFuncionario.Name = "lblCadastrarFuncionario";
            lblCadastrarFuncionario.Size = new Size(394, 52);
            lblCadastrarFuncionario.TabIndex = 0;
            lblCadastrarFuncionario.Text = "Cadastrar Funcionário";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 18F);
            lblNome.Location = new Point(154, 162);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(80, 32);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // textNome
            // 
            textNome.Font = new Font("Segoe UI", 18F);
            textNome.Location = new Point(240, 159);
            textNome.Name = "textNome";
            textNome.Size = new Size(352, 39);
            textNome.TabIndex = 2;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Font = new Font("Segoe UI", 18F);
            lblCargo.Location = new Point(154, 219);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(77, 32);
            lblCargo.TabIndex = 3;
            lblCargo.Text = "Cargo";
            // 
            // textCargo
            // 
            textCargo.Font = new Font("Segoe UI", 18F);
            textCargo.Location = new Point(240, 216);
            textCargo.Name = "textCargo";
            textCargo.Size = new Size(352, 39);
            textCargo.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(319, 317);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(165, 45);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FormAdicionarFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCadastrar);
            Controls.Add(textCargo);
            Controls.Add(lblCargo);
            Controls.Add(textNome);
            Controls.Add(lblNome);
            Controls.Add(lblCadastrarFuncionario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAdicionarFuncionario";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar :: Funcionário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCadastrarFuncionario;
        private Label lblNome;
        private TextBox textNome;
        private Label lblCargo;
        private TextBox textCargo;
        private Button btnCadastrar;
    }
}