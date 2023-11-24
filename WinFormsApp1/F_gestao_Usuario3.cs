using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class F_gestao_Usuario3 : Form
    {
        public F_gestao_Usuario3()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void F_gestao_Usuario3_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[0].Width = 190;
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contlinhas = dgv.SelectedRows.Count;

            if (contlinhas > 0)
            {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();

                dt = Banco.ObterDadosUsuario(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_IDUSUARIO").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NOMEUSUARIO").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_SENHAUSUARIO").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUSUSUARIO").ToString();
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_NIVELUSUARIO");



            }


        }

        private void btn_novo_Click(object sender, EventArgs e)
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

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int linha = dgv_usuarios.SelectedRows[0].Index;
            Usuario u = new Usuario();
            u.id = Convert.ToInt32(tb_id.Text);
            u.nome = tb_nome.Text;
            u.username = tb_username.Text;
            u.senha = tb_senha.Text;
            u.status = cb_status.Text;
            u.nivel = Convert.ToInt32(Math.Round(n_nivel.Value, 0));
            Banco.AtualizarUsuario(u);
            //dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            //dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];
            //dgv_usuarios[0, linha].Value = tb_id.Text;
            dgv_usuarios[1, linha].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirma exclusão?", "Excluir?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                Banco.Deletarusuario(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }
    }
}
