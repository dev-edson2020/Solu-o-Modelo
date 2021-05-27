using System;
using System.Windows.Forms;

namespace Setup
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                BD.TestarConexao();
            }
            catch
            {
                Formularios.frmConfigDados config = new Formularios.frmConfigDados();
                config.ShowDialog();
                Application.Exit();
            }
            /*
                //Abre o formulário de boas vindas
                Application.Run(new Formularios.frmSplash());
            */
            //Abre o formulário de login

            Formularios.frmLogin login = new Formularios.frmLogin();


            login.ShowDialog();



            //Se o usuario não conseguiu logar, então encerrar o sistema

            if (BD.UsuarioLogado == "" || BD.UsuarioLogado == null)
            {
                Application.Exit();
            }
            else
            {
                //Abre o formulário principal
                Formularios.frmPrincipal menu = new Formularios.frmPrincipal();//esse
                menu.lblUsuarioLogado.Text = BD.UsuarioLogado;
                menu.ShowDialog();
            }

        }
    }
}
