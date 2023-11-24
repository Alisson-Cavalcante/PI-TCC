namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lb_nomeUsuario = new Label();
            label2 = new Label();
            lb_acesso = new Label();
            label1 = new Label();
            pb_ledLogado = new PictureBox();
            menuStrip1 = new MenuStrip();
            alunosToolStripMenuItem = new ToolStripMenuItem();
            novoAlunoToolStripMenuItem = new ToolStripMenuItem();
            gestãoDeAlunosToolStripMenuItem = new ToolStripMenuItem();
            usuáriosToolStripMenuItem = new ToolStripMenuItem();
            novoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            gestãoDeUsuáriosToolStripMenuItem = new ToolStripMenuItem();
            manutençãoToolStripMenuItem = new ToolStripMenuItem();
            horáriosToolStripMenuItem = new ToolStripMenuItem();
            professoresToolStripMenuItem = new ToolStripMenuItem();
            turmasToolStripMenuItem = new ToolStripMenuItem();
            lOGINToolStripMenuItem = new ToolStripMenuItem();
            logonToolStripMenuItem = new ToolStripMenuItem();
            logoffToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(lb_nomeUsuario);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lb_acesso);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pb_ledLogado);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 346);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 33);
            panel1.TabIndex = 0;
            // 
            // lb_nomeUsuario
            // 
            lb_nomeUsuario.AutoSize = true;
            lb_nomeUsuario.Location = new Point(188, 9);
            lb_nomeUsuario.Name = "lb_nomeUsuario";
            lb_nomeUsuario.Size = new Size(22, 15);
            lb_nomeUsuario.TabIndex = 4;
            lb_nomeUsuario.Text = "---";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 9);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Usuário:";
            // 
            // lb_acesso
            // 
            lb_acesso.AutoSize = true;
            lb_acesso.Location = new Point(92, 9);
            lb_acesso.Name = "lb_acesso";
            lb_acesso.Size = new Size(13, 15);
            lb_acesso.TabIndex = 2;
            lb_acesso.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 9);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 1;
            label1.Text = "Acesso:";
            // 
            // pb_ledLogado
            // 
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            pb_ledLogado.Location = new Point(3, 3);
            pb_ledLogado.Name = "pb_ledLogado";
            pb_ledLogado.Size = new Size(30, 27);
            pb_ledLogado.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_ledLogado.TabIndex = 0;
            pb_ledLogado.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { alunosToolStripMenuItem, usuáriosToolStripMenuItem, manutençãoToolStripMenuItem, lOGINToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(595, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // alunosToolStripMenuItem
            // 
            alunosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoAlunoToolStripMenuItem, gestãoDeAlunosToolStripMenuItem });
            alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            alunosToolStripMenuItem.Size = new Size(56, 20);
            alunosToolStripMenuItem.Text = "Alunos";
            alunosToolStripMenuItem.Click += alunosToolStripMenuItem_Click;
            // 
            // novoAlunoToolStripMenuItem
            // 
            novoAlunoToolStripMenuItem.Name = "novoAlunoToolStripMenuItem";
            novoAlunoToolStripMenuItem.Size = new Size(180, 22);
            novoAlunoToolStripMenuItem.Text = "Novo Aluno";
            novoAlunoToolStripMenuItem.Click += novoAlunoToolStripMenuItem_Click;
            // 
            // gestãoDeAlunosToolStripMenuItem
            // 
            gestãoDeAlunosToolStripMenuItem.Name = "gestãoDeAlunosToolStripMenuItem";
            gestãoDeAlunosToolStripMenuItem.Size = new Size(180, 22);
            gestãoDeAlunosToolStripMenuItem.Text = "Gestão de Alunos";
            gestãoDeAlunosToolStripMenuItem.Click += gestãoDeAlunosToolStripMenuItem_Click;
            // 
            // usuáriosToolStripMenuItem
            // 
            usuáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoUsuárioToolStripMenuItem, gestãoDeUsuáriosToolStripMenuItem });
            usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            usuáriosToolStripMenuItem.Size = new Size(64, 20);
            usuáriosToolStripMenuItem.Text = "Usuários";
            // 
            // novoUsuárioToolStripMenuItem
            // 
            novoUsuárioToolStripMenuItem.Name = "novoUsuárioToolStripMenuItem";
            novoUsuárioToolStripMenuItem.Size = new Size(174, 22);
            novoUsuárioToolStripMenuItem.Text = "Novo Usuário";
            novoUsuárioToolStripMenuItem.Click += novoUsuárioToolStripMenuItem_Click;
            // 
            // gestãoDeUsuáriosToolStripMenuItem
            // 
            gestãoDeUsuáriosToolStripMenuItem.Name = "gestãoDeUsuáriosToolStripMenuItem";
            gestãoDeUsuáriosToolStripMenuItem.Size = new Size(174, 22);
            gestãoDeUsuáriosToolStripMenuItem.Text = "Gestão de Usuários";
            gestãoDeUsuáriosToolStripMenuItem.Click += gestãoDeUsuáriosToolStripMenuItem_Click;
            // 
            // manutençãoToolStripMenuItem
            // 
            manutençãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { horáriosToolStripMenuItem, professoresToolStripMenuItem, turmasToolStripMenuItem });
            manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            manutençãoToolStripMenuItem.Size = new Size(86, 20);
            manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // horáriosToolStripMenuItem
            // 
            horáriosToolStripMenuItem.Name = "horáriosToolStripMenuItem";
            horáriosToolStripMenuItem.Size = new Size(134, 22);
            horáriosToolStripMenuItem.Text = "Horários";
            horáriosToolStripMenuItem.Click += horáriosToolStripMenuItem_Click;
            // 
            // professoresToolStripMenuItem
            // 
            professoresToolStripMenuItem.Name = "professoresToolStripMenuItem";
            professoresToolStripMenuItem.Size = new Size(134, 22);
            professoresToolStripMenuItem.Text = "Professores";
            professoresToolStripMenuItem.Click += professoresToolStripMenuItem_Click;
            // 
            // turmasToolStripMenuItem
            // 
            turmasToolStripMenuItem.Name = "turmasToolStripMenuItem";
            turmasToolStripMenuItem.Size = new Size(134, 22);
            turmasToolStripMenuItem.Text = "Turmas";
            turmasToolStripMenuItem.Click += turmasToolStripMenuItem_Click;
            // 
            // lOGINToolStripMenuItem
            // 
            lOGINToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logonToolStripMenuItem, logoffToolStripMenuItem });
            lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            lOGINToolStripMenuItem.Size = new Size(54, 20);
            lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logonToolStripMenuItem
            // 
            logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            logonToolStripMenuItem.Size = new Size(109, 22);
            logonToolStripMenuItem.Text = "Logon";
            logonToolStripMenuItem.Click += logonToolStripMenuItem_Click;
            // 
            // logoffToolStripMenuItem
            // 
            logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            logoffToolStripMenuItem.Size = new Size(109, 22);
            logoffToolStripMenuItem.Text = "Logoff";
            logoffToolStripMenuItem.Click += logoffToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 379);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Academia - v1.0";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pb_ledLogado).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        public PictureBox pb_ledLogado;
        public Label lb_nomeUsuario;
        public Label lb_acesso;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem lOGINToolStripMenuItem;
        private ToolStripMenuItem logonToolStripMenuItem;
        private ToolStripMenuItem logoffToolStripMenuItem;
        private ToolStripMenuItem alunosToolStripMenuItem;
        private ToolStripMenuItem novoAlunoToolStripMenuItem;
        private ToolStripMenuItem usuáriosToolStripMenuItem;
        private ToolStripMenuItem novoUsuárioToolStripMenuItem;
        private ToolStripMenuItem gestãoDeUsuáriosToolStripMenuItem;
        private ToolStripMenuItem manutençãoToolStripMenuItem;
        private ToolStripMenuItem horáriosToolStripMenuItem;
        private ToolStripMenuItem professoresToolStripMenuItem;
        private ToolStripMenuItem turmasToolStripMenuItem;
        private ToolStripMenuItem gestãoDeAlunosToolStripMenuItem;
    }
}