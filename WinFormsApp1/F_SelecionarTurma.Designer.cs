namespace WinFormsApp1
{
    partial class F_SelecionarTurma
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgv_turmas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).BeginInit();
            SuspendLayout();
            // 
            // dgv_turmas
            // 
            dgv_turmas.AllowUserToAddRows = false;
            dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_turmas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_turmas.Cursor = Cursors.Hand;
            dgv_turmas.Location = new Point(15, 14);
            dgv_turmas.Name = "dgv_turmas";
            dgv_turmas.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_turmas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_turmas.RowHeadersVisible = false;
            dgv_turmas.RowTemplate.Height = 25;
            dgv_turmas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_turmas.Size = new Size(569, 394);
            dgv_turmas.TabIndex = 0;
            dgv_turmas.DoubleClick += dgv_turmas_DoubleClick;
            // 
            // F_SelecionarTurma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(601, 424);
            Controls.Add(dgv_turmas);
            Name = "F_SelecionarTurma";
            Text = "F_SelecionarTurma";
            Load += F_SelecionarTurma_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_turmas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_turmas;
    }
}