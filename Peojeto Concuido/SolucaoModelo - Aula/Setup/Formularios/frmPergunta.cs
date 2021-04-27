using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmPergunta : Form
    {
        public frmPergunta()
        {
            InitializeComponent();
        }

        private void btnNao_Click(object sender, System.EventArgs e)
        {
            this.Dispose();
        }

        private void btnSim_Click(object sender, System.EventArgs e)
        {
            Geral.Resposta = true;
            this.Dispose();
        }
    }
}
