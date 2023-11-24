namespace WinFormsApp1
{
    partial class F_GestaoProfessores
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
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_excluir = new Button();
            btn_salvar = new Button();
            btn_novo = new Button();
            dgv_professores = new DataGridView();
            label2 = new Label();
            mtb_telefone = new MaskedTextBox();
            tb_id = new TextBox();
            label1 = new Label();
            label3 = new Label();
            tb_nome = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_professores).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_excluir);
            panel1.Controls.Add(btn_salvar);
            panel1.Controls.Add(btn_novo);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 416);
            panel1.Name = "panel1";
            panel1.Size = new Size(498, 34);
            panel1.TabIndex = 11;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(347, 3);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(105, 23);
            btn_fechar.TabIndex = 3;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_excluir
            // 
            btn_excluir.Location = new Point(236, 3);
            btn_excluir.Name = "btn_excluir";
            btn_excluir.Size = new Size(105, 23);
            btn_excluir.TabIndex = 2;
            btn_excluir.Text = "Excluir";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(118, 4);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(112, 23);
            btn_salvar.TabIndex = 1;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(12, 4);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(100, 23);
            btn_novo.TabIndex = 0;
            btn_novo.Text = "Novo Professor";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // dgv_professores
            // 
            dgv_professores.AllowUserToAddRows = false;
            dgv_professores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_professores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_professores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_professores.EnableHeadersVisualStyles = false;
            dgv_professores.Location = new Point(15, 52);
            dgv_professores.MultiSelect = false;
            dgv_professores.Name = "dgv_professores";
            dgv_professores.ReadOnly = true;
            dgv_professores.RowHeadersVisible = false;
            dgv_professores.RowTemplate.Height = 25;
            dgv_professores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_professores.Size = new Size(447, 357);
            dgv_professores.TabIndex = 10;
            dgv_professores.SelectionChanged += dgv_professores_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 5);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            mtb_telefone.Location = new Point(362, 23);
            mtb_telefone.Mask = "(00) 00000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(100, 23);
            mtb_telefone.TabIndex = 8;
            // 
            // tb_id
            // 
            tb_id.Location = new Point(12, 23);
            tb_id.Name = "tb_id";
            tb_id.ReadOnly = true;
            tb_id.Size = new Size(100, 23);
            tb_id.TabIndex = 7;
            tb_id.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 5);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(124, 5);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 12;
            label3.Text = "Professor";
            // 
            // tb_nome
            // 
            tb_nome.Location = new Point(120, 23);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(236, 23);
            tb_nome.TabIndex = 13;
            // 
            // F_GestaoProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 450);
            Controls.Add(tb_nome);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(dgv_professores);
            Controls.Add(label2);
            Controls.Add(mtb_telefone);
            Controls.Add(tb_id);
            Controls.Add(label1);
            Name = "F_GestaoProfessores";
            Text = "Gestão de professores";
            Load += F_GestaoProfessores_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_professores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_salvar;
        private Button btn_novo;
        private DataGridView dgv_professores;
        private Label label2;
        private MaskedTextBox mtb_telefone;
        private TextBox tb_id;
        private Label label1;
        private Label label3;
        private TextBox tb_nome;
    }
}