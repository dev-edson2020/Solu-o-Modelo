using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmOK : Form
    {
        public frmOK()
        {
            InitializeComponent();          
        }

        private void btnSair_Click(object sender, System.EventArgs e) => this.Dispose();
    }
}
