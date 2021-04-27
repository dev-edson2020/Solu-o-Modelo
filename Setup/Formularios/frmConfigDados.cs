using System;
using System.Windows.Forms;
using System.Configuration;

namespace Setup.Formularios
{
    public partial class frmConfigDados : Form
    {
        public frmConfigDados()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {

            openFileDialog1.Title = "Configurações de Base de Dados";
            openFileDialog1.Filter = "Bases Firebird|*.fdb";
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                txtArquivo.Text = openFileDialog1.FileName.ToString();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(panelPrincipal, errorProvider1))
                return;

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["Banco"].Value = txtArquivo.Text;
            config.AppSettings.Settings["Servidor"].Value = txtServidor.Text;
            config.AppSettings.Settings["Porta"].Value = txtPorta.Text;

            config.Save(ConfigurationSaveMode.Modified);

            Geral.OK("Configurações salvas com sucesso!\r\n\r\nO Sistema será fechado!");

            Application.Exit();
        }
    }
}
