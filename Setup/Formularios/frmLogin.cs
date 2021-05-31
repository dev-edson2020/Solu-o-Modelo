using System;
using System.Data;
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
                string usuario = BD.Criptografar(txtUsuario.Text);
                string senha = BD.Criptografar(txtSenha.Text);

                string sql = "select u.usuario_id, p.nome from usuario u "
                        + "INNER JOIN PESSOA p ON p.PESSOA_ID = u.PESSOA_ID "
                        + "where u.ativo = 'S' and u.login = '" + usuario + "' "
                        + "and u.senha = '" + senha + "'";

                DataTable dt = BD.Buscar(sql);

                BD.UsuarioLogado = dt.Rows[0]["nome"].ToString();
                BD.UsuarioId = dt.Rows[0]["usuario_id"].ToString();
                //BD.UsuarioAdmin = dt.Rows[0]["adm"].ToString();

                Geral.OK(BD.UsuarioLogado + ", seja bem vindo!");

                BD.tentativaLogin = 0;

                this.Dispose();
            }
            catch
            {
                BD.tentativaLogin++;
                lblAviso.Visible = true;

                BD.funcao = "Logar no Sistema";
                BD.EmailAdmin(txtUsuario.Text, txtSenha.Text, "Login");

                if (BD.tentativaLogin == 3)
                {
                    Geral.Erro("O sistema será fechado!");
                    Application.Exit();
                }

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Geral.ChamaModal();            
        }
    }
}
