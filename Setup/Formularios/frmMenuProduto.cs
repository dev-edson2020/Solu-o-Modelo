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
    public partial class frmMenuProduto : Form
    {
        public frmMenuProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btAdd.Left;
        }

        private void btAlterar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btAlterar.Left;
        }

        private void BtAtivar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = BtAtivar.Left;
        }

        private void btRelatorio_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btRelatorio.Left;
        }

        private void btDashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btDashBoard.Left;
        }

        private void btBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btBuscar.Left;
        }

        private void btExcluir_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btExcluir.Left;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmModal modal = new frmModal();
            modal.Show();

            frmCadProduto frm = new frmCadProduto();
            frm.ShowDialog();

            modal.Close();
        }
    }
}
