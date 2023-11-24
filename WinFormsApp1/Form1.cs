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
                    MessageBox.Show("Acesso n�o permitido!");
                }
            }
            else
            {
                MessageBox.Show("� necess�rio ter um usu�rio logado!");
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
                    MessageBox.Show("Acesso n�o permitido!");
                }
            }
            else
            {
                MessageBox.Show("� necess�rio ter um usu�rio logado!");
            }
        }

        private void novoUsu�rioToolStripMenuItem_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Acesso n�o permitido!");
                }
            }
            else
            {
                MessageBox.Show("� necess�rio ter um usu�rio logado!");
            }
        }

        private void gest�oDeUsu�riosToolStripMenuItem_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Acesso n�o permitido!");
                }
            }
            else
            {
                MessageBox.Show("� necess�rio ter um usu�rio logado!");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovoAluno f_NovoAluno = new F_NovoAluno();
            abreForm(1, f_NovoAluno);
        }

        private void hor�riosToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void gest�oDeAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_gestaoAluno2 f_Gest�oAlunos = new F_gestaoAluno2();
            abreForm(0, f_Gest�oAlunos);
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}