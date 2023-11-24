namespace WinFormsApp1
{
    partial class F_gestaoAluno2
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_alunos = new DataGridView();
            pb_foto = new PictureBox();
            mts_telefone = new MaskedTextBox();
            label5 = new Label();
            btn_imprimirCarteirinha = new Button();
            cb_turmas = new ComboBox();
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_financeiro = new Button();
            btn_excluirAluno = new Button();
            btn_salvarEdicoes = new Button();
            cb_status = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tb_nome = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_alunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_foto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_alunos
            // 
            dgv_alunos.AllowUserToAddRows = false;
            dgv_alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_alunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_alunos.EnableHeadersVisualStyles = false;
            dgv_alunos.Location = new Point(12, 6);
            dgv_alunos.MultiSelect = false;
            dgv_alunos.Name = "dgv_alunos";
            dgv_alunos.ReadOnly = true;
            dgv_alunos.RowHeadersVisible = false;
            dgv_alunos.RowTemplate.Height = 25;
            dgv_alunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_alunos.Size = new Size(333, 407);
            dgv_alunos.TabIndex = 47;
            dgv_alunos.SelectionChanged += dgv_alunos_SelectionChanged;
            // 
            // pb_foto
            // 
            pb_foto.BorderStyle = BorderStyle.FixedSingle;
            pb_foto.Location = new Point(432, 213);
            pb_foto.Name = "pb_foto";
            pb_foto.Size = new Size(85, 113);
            pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_foto.TabIndex = 46;
            pb_foto.TabStop = false;
            // 
            // mts_telefone
            // 
            mts_telefone.Location = new Point(349, 72);
            mts_telefone.Mask = "(99)99999-9999";
            mts_telefone.Name = "mts_telefone";
            mts_telefone.Size = new Size(86, 23);
            mts_telefone.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 355);
            label5.Name = "label5";
            label5.Size = new Size(171, 15);
            label5.TabIndex = 44;
            label5.Text = "Clique duplo para alterar a foto";
            // 
            // btn_imprimirCarteirinha
            // 
            btn_imprimirCarteirinha.Location = new Point(351, 160);
            btn_imprimirCarteirinha.Name = "btn_imprimirCarteirinha";
            btn_imprimirCarteirinha.Size = new Size(260, 23);
            btn_imprimirCarteirinha.TabIndex = 35;
            btn_imprimirCarteirinha.Text = "Imprimir Carteirinha";
            btn_imprimirCarteirinha.UseVisualStyleBackColor = true;
            // 
            // cb_turmas
            // 
            cb_turmas.FormattingEnabled = true;
            cb_turmas.Location = new Point(351, 121);
            cb_turmas.Name = "cb_turmas";
            cb_turmas.Size = new Size(260, 23);
            cb_turmas.TabIndex = 43;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_financeiro);
            panel1.Controls.Add(btn_excluirAluno);
            panel1.Controls.Add(btn_salvarEdicoes);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(766, 34);
            panel1.TabIndex = 42;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(412, 6);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(105, 23);
            btn_fechar.TabIndex = 10;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_financeiro
            // 
            btn_financeiro.Location = new Point(301, 5);
            btn_financeiro.Name = "btn_financeiro";
            btn_financeiro.Size = new Size(105, 23);
            btn_financeiro.TabIndex = 8;
            btn_financeiro.Text = "Financeiro";
            btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_excluirAluno
            // 
            btn_excluirAluno.Location = new Point(183, 6);
            btn_excluirAluno.Name = "btn_excluirAluno";
            btn_excluirAluno.Size = new Size(112, 23);
            btn_excluirAluno.TabIndex = 7;
            btn_excluirAluno.Text = "Excluir Aluno";
            btn_excluirAluno.UseVisualStyleBackColor = true;
            btn_excluirAluno.Click += btn_excluirAluno_Click;
            // 
            // btn_salvarEdicoes
            // 
            btn_salvarEdicoes.Location = new Point(77, 6);
            btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            btn_salvarEdicoes.Size = new Size(100, 23);
            btn_salvarEdicoes.TabIndex = 6;
            btn_salvarEdicoes.Text = "Salvar Edições";
            btn_salvarEdicoes.UseVisualStyleBackColor = true;
            btn_salvarEdicoes.Click += btn_salvarEdicoes_Click;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(441, 72);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(170, 23);
            cb_status.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(351, 103);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 40;
            label4.Text = "Turmas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(444, 54);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 39;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(354, 54);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 38;
            label2.Text = "Telefone";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(351, 24);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(260, 23);
            tb_nome.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(354, 6);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 36;
            label1.Text = "Nome";
            // 
            // F_gestaoAluno2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(dgv_alunos);
            Controls.Add(pb_foto);
            Controls.Add(mts_telefone);
            Controls.Add(label5);
            Controls.Add(btn_imprimirCarteirinha);
            Controls.Add(cb_turmas);
            Controls.Add(panel1);
            Controls.Add(cb_status);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            Name = "F_gestaoAluno2";
            Text = "Gestão de Alunos";
            Load += F_gestaoAluno2_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_alunos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_foto).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_alunos;
        private PictureBox pb_foto;
        private MaskedTextBox mts_telefone;
        private Label label5;
        private Button btn_imprimirCarteirinha;
        private ComboBox cb_turmas;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_financeiro;
        private Button btn_excluirAluno;
        private Button btn_salvarEdicoes;
        private ComboBox cb_status;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tb_nome;
        private Label label1;
    }
}