namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void abreForm(int nivel, Form f)
        {
            if (Globais.logado)
            {

                if (Globais.nivel >= nivel)
                {
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_login f_Login = new F_login(this);
            f_Login.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.led_vermelho;
            Globais.nivel = 0;
            Globais.logado = false;
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

                if (Globais.nivel > 1)
                {

                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {

                if (Globais.nivel >= 1)
                {
                    F_gestao_Usuario3 f_Gestao_Usuarios = new F_gestao_Usuario3();
                    f_Gestao_Usuarios.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido!");
                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado!");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            abreForm(1, f_NovoAluno);
        }

        private void horáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Horarios f_Horarios = new F_Horarios();
            abreForm(2, f_Horarios);
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoProfessores f_GestaoProfessores = new F_GestaoProfessores();
            abreForm(2, f_GestaoProfessores);
        }

        private void turmasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GestaoTurmas f_GestaoTurmas = new F_GestaoTurmas();
            abreForm(2, f_GestaoTurmas);
        }

        private void gestãoDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_gestaoAluno2 f_GestãoAlunos = new F_gestaoAluno2();
            abreForm(0, f_GestãoAlunos);
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}