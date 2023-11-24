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
    public partial class F_gestaoUsuarios2 : Form
    {
        public F_gestaoUsuarios2()
        {
            InitializeComponent();
        }

        private void F_gestaoUsuarios2_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios.Columns[0].Width = 85;
            dgv_usuarios.Columns[1].Width = 190;

            if (dgv_usuarios.Rows.Count > 0)
            {
                tb_id.Text = dgv_usuarios.Rows[0].Cells["N_IDUSUARIO"].Value.ToString();
                tb_nome.Text = dgv_usuarios.Rows[0].Cells["T_NOMEUSUARIO"].Value.ToString();
                tb_username.Text = dgv_usuarios.Rows[0].Cells["T_NOMEUSUARIO"].Value.ToString();
                tb_senha.Text = dgv_usuarios.Rows[0].Cells["T_SENHAUSUARIO"].Value.ToString();
                cb_status.Text = dgv_usuarios.Rows[0].Cells["T_STATUSUSUARIO"].Value.ToString();
                n_nivel.Value = Convert.ToDecimal(dgv_usuarios.Rows[0].Cells["N_NIVELUSUARIO"].Value);
            }
        }


        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
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
            dgv_usuarios.DataSource = Banco.ObterUsuariosIdNome();
            dgv_usuarios.CurrentCell = dgv_usuarios[0, linha];
            dgv_usuarios[0, linha].Value = tb_id.Text;
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

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
