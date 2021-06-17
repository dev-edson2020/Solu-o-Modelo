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
       
        private void btnPessoa_Click(object sender, EventArgs e)
        {
            
            AbrirFormEmPanel(new frmMenuPessoa());
            
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new frmMenuProduto());
        }
        public void AbrirFormEmPanel(object form)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(frm);
            this.panel1.Tag = frm;
            frm.Show();
        }


        private void btProduto_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, btProduto.Location.Y);
        }       

        private void BtCompra_Click(object sender, EventArgs e)
        {
            AbrirFormEmPanel(new frmMenuCompra());
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtCompra_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, BtCompra.Location.Y);
        }

        private void btVendas_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, btVendas.Location.Y);
        }

        private void btFinanceiro_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, btFinanceiro.Location.Y);
        }
    }   
}


