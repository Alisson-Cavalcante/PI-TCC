namespace WinFormsApp1
{
    partial class F_Gestao_Usuarios
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
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            n_nivel = new NumericUpDown();
            cb_status = new ComboBox();
            tb_senha = new TextBox();
            label3 = new Label();
            tb_username = new TextBox();
            label2 = new Label();
            tb_nome = new TextBox();
            label1 = new Label();
            tb_id = new TextBox();
            label9 = new Label();
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_excluir = new Button();
            btn_salvar = new Button();
            btn_novo = new Button();
            dgv_usuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)n_nivel).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(158, 204);
            label8.Name = "label8";
            label8.Size = new Size(81, 15);
            label8.TabIndex = 25;
            label8.Text = "D = Desligado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 204);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 24;
            label7.Text = "B = Bloqueado";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 204);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 23;
            label6.Text = "A = Ativo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(130, 149);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 22;
            label5.Text = "Nível";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 149);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 21;
            label4.Text = "Status";
            // 
            // n_nivel
            // 
            n_nivel.Location = new Point(130, 168);
            n_nivel.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            n_nivel.Name = "n_nivel";
            n_nivel.Size = new Size(100, 23);
            n_nivel.TabIndex = 20;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "A", "B", "D" });
            cb_status.Location = new Point(24, 167);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(100, 23);
            cb_status.TabIndex = 19;
            // 
            // tb_senha
            // 
            tb_senha.Location = new Point(130, 117);
            tb_senha.Name = "tb_senha";
            tb_senha.PasswordChar = '*';
            tb_senha.Size = new Size(100, 23);
            tb_senha.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 49);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 17;
            label3.Text = "Nome";
            // 
            // tb_username
            // 
            tb_username.Location = new Point(24, 117);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(100, 23);
            tb_username.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 99);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 15;
            label2.Text = "Senha";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(24, 67);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(206, 23);
            tb_nome.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 99);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(24, 23);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(100, 23);
            tb_id.TabIndex = 27;
            tb_id.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 5);
            label9.Name = "label9";
            label9.Size = new Size(18, 15);
            label9.TabIndex = 26;
            label9.Text = "ID";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_excluir);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(btn_novo);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 316);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 34);
            panel1.TabIndex = 28;
            // 
            // btn_fechar
            // 
            btn_fechar.Cursor = Cursors.Hand;
            btn_fechar.Location = new Point(429, 6);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(116, 23);
            btn_fechar.TabIndex = 3;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Cursor = Cursors.Hand;
            btn_excluir.Location = new Point(284, 6);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(116, 23);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir usuário";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Cursor = Cursors.Hand;
            btn_salvar.Location = new Point(143, 6);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(116, 23);
            btn_salvar.TabIndex = 1;
            btn_salvar.Text = "Salvar alterações";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_novo
            // 
            btn_novo.Cursor = Cursors.Hand;
            btn_novo.Location = new Point(12, 6);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(100, 23);
            btn_novo.TabIndex = 0;
            btn_novo.Text = "Novo usuário";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // dgv_usuarios
            // 
            dgv_usuarios.AllowUserToAddRows = false;
            dgv_usuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_usuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_usuarios.EnableHeadersVisualStyles = false;
            dgv_usuarios.Location = new Point(257, 3);
            dgv_usuarios.MultiSelect = false;
            dgv_usuarios.Name = "dgv_usuarios";
            dgv_usuarios.ReadOnly = true;
            dgv_usuarios.RowHeadersVisible = false;
            dgv_usuarios.RowTemplate.Height = 25;
            dgv_usuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_usuarios.Size = new Size(302, 311);
            dgv_usuarios.TabIndex = 29;
            dgv_usuarios.CellContentClick += dgv_usuarios_SelectionChanged;
            // 
            // F_Gestao_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 350);
            Controls.Add(dgv_usuarios);
            Controls.Add(panel1);
            Controls.Add(tb_id);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(n_nivel);
            Controls.Add(cb_status);
            Controls.Add(tb_senha);
            Controls.Add(label3);
            Controls.Add(tb_username);
            Controls.Add(label2);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Gestao_Usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestão Usuários";
            Load += F_Gestao_Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)n_nivel).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_usuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private NumericUpDown n_nivel;
        private ComboBox cb_status;
        private TextBox tb_senha;
        private Label label3;
        private TextBox tb_username;
        private Label label2;
        private TextBox tb_nome;
        private Label label1;
        private TextBox tb_id;
        private Label label9;
        private Panel panel1;
        private Button btn_novo;
        private DataGridView dgv_usuarios;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_salvar;
    }
}