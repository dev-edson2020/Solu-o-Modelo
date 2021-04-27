using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            BD.tentativaLogin = 0;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(panel2, errorProvider1))
                return;

            try
            {
                //string usuario = BD.Criptografar(txtUsuario.Text);
                //string senha = BD.Criptografar(txtSenha.Text);

                string usuario = txtUsuario.Text;
                string senha = txtSenha.Text;

               

                string sql = "select u.usuario_id, p.nome from usuario u "
                    + "INNER JOIN PESSOA p ON p.PESSOA_ID = P.PESSOA_ID "
                    + "WHERE u.login = '" + usuario + "'"
                    + "AND u.senha = '" +senha + "'";
                
                  
                string Nome = BD.Buscar(sql).Rows[0]["nome"].ToString();

                BD.UsuarioLogado = Nome;
                Geral.OK(Nome + ", seja bem vindo!");
                this.Dispose();
            }
            catch 
            {
                BD.tentativaLogin++;

                if (BD.tentativaLogin == 3)
                {
                    Geral.Erro("O sistema será fechado!");
                    Application.Exit();
                }

                lblAviso.Visible = true;

                Geral.Erro("Tentativa Nº " + BD.tentativaLogin + ", o sistema será fechado na terceira tentativa inválida!");
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
