using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmLiberaAcesso : Form
    {
        public frmLiberaAcesso()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Verificar se o usuario foi informado...
            if(txtUsuario.Text.Trim()=="")
            {
                Geral.Erro("Informe o usuário adminitrador!");
                txtUsuario.Focus();
                return;
            }

            if(txtSenha.Text.Trim()=="")
            {
                Geral.Erro("Informe sua senha admin");
                txtSenha.Focus();
                return;
            }

            string sql = "SELECT a.ADM FROM USUARIO a WHERE a.LOGIN = '" + 
                        BD.Criptografar(txtUsuario.Text) + "' AND SENHA = '" +
                        BD.Criptografar(txtSenha.Text) + "' AND a.ATIVO = 'S'";
            try
            {
                BD.UsuarioAdmin = BD.Buscar(sql).Rows[0]["ADM"].ToString();
            }
            catch 
            {
                BD.UsuarioAdmin = "N";
            }

            if (BD.UsuarioAdmin == "N")
            {
                BD.tentativaLogin++;
                BD.EmailAdmin(txtUsuario.Text, txtSenha.Text, "Permissão");
                Geral.Erro("Ação negada para esse usuário!");
            }

            this.Close();
        }
    }
}
