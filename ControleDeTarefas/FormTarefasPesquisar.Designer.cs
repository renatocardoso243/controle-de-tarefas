namespace ControleDeTarefas
{
    partial class FormTarefasPesquisar
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
            lblPesquisarTarefas = new Label();
            lblDescricao = new Label();
            txtDescricaoTarefa = new TextBox();
            btnPesquisar = new Button();
            btnCancelar = new Button();
            dataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // lblPesquisarTarefas
            // 
            lblPesquisarTarefas.AutoSize = true;
            lblPesquisarTarefas.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lblPesquisarTarefas.Location = new Point(12, 9);
            lblPesquisarTarefas.Name = "lblPesquisarTarefas";
            lblPesquisarTarefas.Size = new Size(163, 25);
            lblPesquisarTarefas.TabIndex = 0;
            lblPesquisarTarefas.Text = "Pesquisar Tarefas";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 46);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescricaoTarefa
            // 
            txtDescricaoTarefa.Location = new Point(12, 64);
            txtDescricaoTarefa.Name = "txtDescricaoTarefa";
            txtDescricaoTarefa.Size = new Size(614, 23);
            txtDescricaoTarefa.TabIndex = 2;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(632, 64);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(75, 23);
            btnPesquisar.TabIndex = 3;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(713, 63);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Location = new Point(12, 93);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(776, 345);
            dataGrid.TabIndex = 5;
            // 
            // FormTarefasPesquisar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGrid);
            Controls.Add(btnCancelar);
            Controls.Add(btnPesquisar);
            Controls.Add(txtDescricaoTarefa);
            Controls.Add(lblDescricao);
            Controls.Add(lblPesquisarTarefas);
            Name = "FormTarefasPesquisar";
            Text = "FormTarefasPesquisar";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPesquisarTarefas;
        private Label lblDescricao;
        private TextBox txtDescricaoTarefa;
        private Button btnPesquisar;
        private Button btnCancelar;
        private DataGridView dataGrid;
    }
}