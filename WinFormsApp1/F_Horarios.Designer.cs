namespace WinFormsApp1
{
    partial class F_Horarios
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
            label1 = new Label();
            tb_idHorario = new TextBox();
            mtb_dscHorario = new MaskedTextBox();
            label2 = new Label();
            dgv_horarios = new DataGridView();
            panel1 = new Panel();
            btn_fechar = new Button();
            btn_excluir = new Button();
            btn_salvar = new Button();
            btn_novo = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // tb_idHorario
            // 
            tb_idHorario.Location = new Point(12, 27);
            tb_idHorario.Name = "tb_idHorario";
            tb_idHorario.ReadOnly = true;
            tb_idHorario.Size = new Size(100, 23);
            tb_idHorario.TabIndex = 1;
            tb_idHorario.TabStop = false;
            // 
            // mtb_dscHorario
            // 
            mtb_dscHorario.Location = new Point(118, 27);
            mtb_dscHorario.Mask = "99:99 \\até 99:99";
            mtb_dscHorario.Name = "mtb_dscHorario";
            mtb_dscHorario.Size = new Size(100, 23);
            mtb_dscHorario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 9);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Horário";
            // 
            // dgv_horarios
            // 
            dgv_horarios.AllowUserToAddRows = false;
            dgv_horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_horarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_horarios.EnableHeadersVisualStyles = false;
            dgv_horarios.Location = new Point(15, 56);
            dgv_horarios.MultiSelect = false;
            dgv_horarios.Name = "dgv_horarios";
            dgv_horarios.ReadOnly = true;
            dgv_horarios.RowHeadersVisible = false;
            dgv_horarios.RowTemplate.Height = 25;
            dgv_horarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_horarios.Size = new Size(447, 357);
            dgv_horarios.TabIndex = 4;
            dgv_horarios.SelectionChanged += dgv_horarios_SelectionChanged;
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
            panel1.Location = new Point(0, 425);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 34);
            panel1.TabIndex = 5;
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
            btn_excluir.Text = "Excluir horário";
            btn_excluir.UseVisualStyleBackColor = true;
            btn_excluir.Click += btn_excluir_Click;
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(118, 4);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(112, 23);
            btn_salvar.TabIndex = 1;
            btn_salvar.Text = "Salvar horário";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += btn_salvar_Click;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(12, 4);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(100, 23);
            btn_novo.TabIndex = 0;
            btn_novo.Text = "Novo horário";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // F_Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 459);
            Controls.Add(panel1);
            Controls.Add(dgv_horarios);
            Controls.Add(label2);
            Controls.Add(mtb_dscHorario);
            Controls.Add(tb_idHorario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "F_Horarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Horários";
            Load += F_Horarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_horarios).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_idHorario;
        private MaskedTextBox mtb_dscHorario;
        private Label label2;
        private DataGridView dgv_horarios;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_excluir;
        private Button btn_salvar;
        private Button btn_novo;
    }
}