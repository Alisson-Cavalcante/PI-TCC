namespace WinFormsApp1
{
    partial class F_NovoAluno
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
            label1 = new Label();
            tb_nome = new TextBox();
            label2 = new Label();
            mtb_telefone = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            cb_status = new ComboBox();
            panel1 = new Panel();
            btn_addFoto = new Button();
            btn_fechar = new Button();
            btn_cancelar = new Button();
            btn_gravar = new Button();
            btn_novo = new Button();
            tb_turma = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            pb_foto = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_foto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "nome";
            // 
            // tb_nome
            // 
            tb_nome.Enabled = false;
            tb_nome.Location = new Point(12, 30);
            tb_nome.Name = "tb_nome";
            tb_nome.Size = new Size(289, 23);
            tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 12);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // mtb_telefone
            // 
            mtb_telefone.Enabled = false;
            mtb_telefone.Location = new Point(307, 30);
            mtb_telefone.Mask = "(00)00000-0000";
            mtb_telefone.Name = "mtb_telefone";
            mtb_telefone.Size = new Size(154, 23);
            mtb_telefone.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 58);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 58);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 5;
            label4.Text = "Turma";
            // 
            // cb_status
            // 
            cb_status.Enabled = false;
            cb_status.FormattingEnabled = true;
            cb_status.Location = new Point(12, 76);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(212, 23);
            cb_status.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(btn_addFoto);
            panel1.Controls.Add(btn_fechar);
            panel1.Controls.Add(btn_cancelar);
            panel1.Controls.Add(btn_gravar);
            panel1.Controls.Add(btn_novo);
            panel1.Cursor = Cursors.Hand;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(605, 34);
            panel1.TabIndex = 20;
            // 
            // btn_addFoto
            // 
            btn_addFoto.Location = new Point(374, 5);
            btn_addFoto.Name = "btn_addFoto";
            btn_addFoto.Size = new Size(75, 23);
            btn_addFoto.TabIndex = 27;
            btn_addFoto.Text = "Add Foto";
            btn_addFoto.UseVisualStyleBackColor = true;
            btn_addFoto.Click += btn_addFoto_Click;
            // 
            // btn_fechar
            // 
            btn_fechar.Location = new Point(455, 4);
            btn_fechar.Name = "btn_fechar";
            btn_fechar.Size = new Size(105, 23);
            btn_fechar.TabIndex = 10;
            btn_fechar.Text = "Fechar";
            btn_fechar.UseVisualStyleBackColor = true;
            btn_fechar.Click += btn_fechar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Enabled = false;
            btn_cancelar.Location = new Point(263, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(105, 23);
            btn_cancelar.TabIndex = 8;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_gravar
            // 
            btn_gravar.Enabled = false;
            btn_gravar.Location = new Point(145, 5);
            btn_gravar.Name = "btn_gravar";
            btn_gravar.Size = new Size(112, 23);
            btn_gravar.TabIndex = 7;
            btn_gravar.Text = "Gravar";
            btn_gravar.UseVisualStyleBackColor = true;
            btn_gravar.Click += btn_gravar_Click;
            // 
            // btn_novo
            // 
            btn_novo.Location = new Point(39, 5);
            btn_novo.Name = "btn_novo";
            btn_novo.Size = new Size(100, 23);
            btn_novo.TabIndex = 6;
            btn_novo.Text = "Novo";
            btn_novo.UseVisualStyleBackColor = true;
            btn_novo.Click += btn_novo_Click;
            // 
            // tb_turma
            // 
            tb_turma.Location = new Point(230, 76);
            tb_turma.Name = "tb_turma";
            tb_turma.ReadOnly = true;
            tb_turma.Size = new Size(206, 23);
            tb_turma.TabIndex = 21;
            tb_turma.Tag = "1";
            // 
            // button1
            // 
            button1.Location = new Point(435, 76);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 22;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(217, 140);
            button2.Name = "button2";
            button2.Size = new Size(28, 23);
            button2.TabIndex = 25;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 140);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 122);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 23;
            label5.Text = "Plano";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // pb_foto
            // 
            pb_foto.BorderStyle = BorderStyle.FixedSingle;
            pb_foto.Location = new Point(497, 39);
            pb_foto.Name = "pb_foto";
            pb_foto.Size = new Size(85, 113);
            pb_foto.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_foto.TabIndex = 26;
            pb_foto.TabStop = false;
            // 
            // F_NovoAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 225);
            Controls.Add(pb_foto);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(tb_turma);
            Controls.Add(panel1);
            Controls.Add(cb_status);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mtb_telefone);
            Controls.Add(label2);
            Controls.Add(tb_nome);
            Controls.Add(label1);
            Name = "F_NovoAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Aluno";
            Load += F_NovoAluno_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_foto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_nome;
        private Label label2;
        private MaskedTextBox mtb_telefone;
        private Label label3;
        private Label label4;
        private ComboBox cb_status;
        private Panel panel1;
        private Button btn_fechar;
        private Button btn_cancelar;
        private Button btn_gravar;
        private Button btn_novo;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label5;
        public TextBox tb_turma;
        private Button btn_addFoto;
        private OpenFileDialog openFileDialog1;
        private PictureBox pb_foto;
    }
}