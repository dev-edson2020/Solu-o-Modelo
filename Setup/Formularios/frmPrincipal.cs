using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Setup.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString();
        }

        private void btnModelo_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, btnPessoa.Location.Y);
        }

        private void panelMenu_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, btProduto.Location.Y);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
        }

        private void lblTitulo_DoubleClick(object sender, EventArgs e)
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = new Point(0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(panel1, errorProvider1) == true)
                return;

            string[] c = new string[4];
            string[] v = new string[4];

            c[0] = "nome";
            v[0] = txtNome.Text;

            c[1] = "valor";
            v[1] = BD.cvNum(txtValor.Text);

            c[2] = "data";
            v[2] = BD.CvData(txtData.Text);

            c[3] = "ativo";
            v[3] = "S";

            BD.Salvar("teste", c, v);

            Geral.OK("Salvo com sucesso!");
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            frmModal modal = new frmModal();
            modal.Show();

            frmMenuPessoa frm = new frmMenuPessoa();
            frm.ShowDialog();

            modal.Dispose();

        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            frmModal modal = new frmModal();
            modal.Show();

            frmMenuProduto frm = new frmMenuProduto();
            frm.ShowDialog();

            modal.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btProduto_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, btProduto.Location.Y);
        }
    }   
}


