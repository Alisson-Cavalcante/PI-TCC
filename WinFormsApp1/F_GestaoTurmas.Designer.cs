namespace WinFormsApp1
{
    partial class F_GestaoTurmas
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label3 = new Label();
            panel1 = new Panel();
            btn_imprimirTurma = new Button();
            btn_fechar = new Button();
            btn_excluirTurma = new Button();
            btn_salvarEdicoes = new Button();
            btn_novaTurma = new Button();
            dgv_turmas = new DataGridView();
            label1 = new Label();
            cb_professor = new ComboBox();
            cb_horario = new ComboBox();
            cb_status = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            n_maxAlunos = new NumericUpDown();
            label5 = new Label();
            tb_dscTurma = new TextBox();
            label6 = new Label();
            tb_vagas = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)n_maxAlunos).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(407, 93);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 20;
            label3.Text = "Professor";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btn_imprimirTurma);
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_excluirTurma);
            panel1.Controls.Add(btn_salvarEdicoes);
            panel1.Controls.Add(btn_novaTurma);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 458);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 34);
            panel1.TabIndex = 19;
            // 
            // btn_imprimirTurma
            // 
            btn_imprimirTurma.Location = new Point(385, 5);
            btn_imprimirTurma.Name = "btn_imprimirTurma";
            btn_imprimirTurma.Size = new Size(105, 23);
            btn_imprimirTurma.TabIndex = 9;
            btn_imprimirTurma.Text = "Imprimir turma";
            btn_imprimirTurma.UseVisualStyleBackColor = true;
            btn_imprimirTurma.Click += btn_imprimirTurma_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(496, 5);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(105, 23);
            btn_fechar.TabIndex = 10;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_excluirTurma
            // 
            btn_excluirTurma.Location = new Point(274, 4);
            btn_excluirTurma.Name = "btn_excluirTurma";
            btn_excluirTurma.Size = new Size(105, 23);
            btn_excluirTurma.TabIndex = 8;
            btn_excluirTurma.Text = "Excluir turma";
            btn_excluirTurma.UseVisualStyleBackColor = true;
            btn_excluirTurma.Click += btn_excluirTurma_Click;
            // 
            // btn_salvarEdicoes
            // 
            btn_salvarEdicoes.Location = new Point(156, 5);
            btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            btn_salvarEdicoes.Size = new Size(112, 23);
            btn_salvarEdicoes.TabIndex = 7;
            btn_salvarEdicoes.Text = "Salvar edições";
            btn_salvarEdicoes.UseVisualStyleBackColor = true;
            btn_salvarEdicoes.Click += btn_salvarEdicoes_Click;
            // 
            // btn_novaTurma
            // 
            btn_novaTurma.Location = new Point(50, 5);
            btn_novaTurma.Name = "btn_novaTurma";
            btn_novaTurma.Size = new Size(100, 23);
            btn_novaTurma.TabIndex = 6;
            btn_novaTurma.Text = "Nova turma";
            btn_novaTurma.UseVisualStyleBackColor = true;
            btn_novaTurma.Click += btn_novaTurma_Click;
            // 
            // dgv_turmas
            // 
            dgv_turmas.AllowUserToAddRows = false;
            dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_turmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_turmas.EnableHeadersVisualStyles = false;
            dgv_turmas.Location = new Point(8, 12);
            dgv_turmas.MultiSelect = false;
            dgv_turmas.Name = "dgv_turmas";
            dgv_turmas.ReadOnly = true;
            dgv_turmas.RowHeadersVisible = false;
            dgv_turmas.RowTemplate.Height = 25;
            dgv_turmas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_turmas.Size = new Size(392, 436);
            dgv_turmas.TabIndex = 18;
            dgv_turmas.SelectionChanged += dgv_turmas_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(407, 210);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 22;
            label1.Text = "Horário";
            // 
            // cb_professor
            // 
            cb_professor.FormattingEnabled = true;
            cb_professor.Location = new Point(408, 111);
            cb_professor.Name = "cb_professor";
            cb_professor.Size = new Size(232, 23);
            cb_professor.TabIndex = 2;
            cb_professor.SelectedIndexChanged += cb_professor_SelectedIndexChanged;
            // 
            // cb_horario
            // 
            cb_horario.FormattingEnabled = true;
            cb_horario.Location = new Point(408, 228);
            cb_horario.Name = "cb_horario";
            cb_horario.Size = new Size(232, 23);
            cb_horario.TabIndex = 5;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(536, 173);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(104, 23);
            cb_status.TabIndex = 4;
            cb_status.SelectedIndexChanged += cm_status_SelectedIndexChanged;
            cb_status.TextChanged += cm_status_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(535, 155);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 27;
            label2.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 155);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 28;
            label4.Text = "Máximo Alunos";
            // 
            // n_maxAlunos
            // 
            n_maxAlunos.Location = new Point(408, 173);
            n_maxAlunos.Name = "n_maxAlunos";
            n_maxAlunos.Size = new Size(104, 23);
            n_maxAlunos.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 12);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 29;
            label5.Text = "Nome turma";
            // 
            // tb_dscTurma
            // 
            tb_dscTurma.Location = new Point(408, 30);
            tb_dscTurma.Name = "tb_dscTurma";
            tb_dscTurma.Size = new Size(232, 23);
            tb_dscTurma.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(410, 263);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 30;
            label6.Text = "Vagas";
            // 
            // tb_vagas
            // 
            tb_vagas.Cursor = Cursors.No;
            tb_vagas.Location = new Point(408, 281);
            tb_vagas.Name = "tb_vagas";
            tb_vagas.ReadOnly = true;
            tb_vagas.Size = new Size(89, 23);
            tb_vagas.TabIndex = 31;
            tb_vagas.TabStop = false;
            // 
            // F_GestaoTurmas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 492);
            Controls.Add(tb_vagas);
            Controls.Add(label6);
            Controls.Add(tb_dscTurma);
            Controls.Add(label5);
            Controls.Add(n_maxAlunos);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(cb_status);
            Controls.Add(cb_horario);
            Controls.Add(cb_professor);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dgv_turmas);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_GestaoTurmas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão de Turmas";
            Load += F_GestaoTurmas_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).EndInit();
            ((System.ComponentModel.ISupportInitialize)n_maxAlunos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_excluirTurma;
        private Button btn_salvarEdicoes;
        private Button btn_novaTurma;
        private DataGridView dgv_turmas;
        private Label label1;
        private ComboBox cb_professor;
        private Button btn_imprimirTurma;
        private ComboBox cb_horario;
        private ComboBox cb_status;
        private Label label2;
        private Label label4;
        private NumericUpDown n_maxAlunos;
        private Label label5;
        private TextBox tb_dscTurma;
        private Label label6;
        private TextBox tb_vagas;
    }
}