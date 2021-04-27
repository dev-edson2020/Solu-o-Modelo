using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Data;

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
            if(e.KeyCode==Keys.Enter)
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
            frmModal modal = new frmModal();
            modal.Show();

            frmMenuPessoa frm = new frmMenuPessoa();
            frm.ShowDialog();

            DashBoard();

            modal.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Abrir o  modal
            frmModal modal = new frmModal();
            modal.Show();

            //Abrir o formulário
            frmCadPessoa frm = new frmCadPessoa();
            frm.ShowDialog();

            modal.Dispose();
        }

        private void BtProduto_Click(object sender, EventArgs e)
        {
            frmModal modal = new frmModal();
            modal.Show();

            frmMenuProduto frm = new frmMenuProduto();
            frm.ShowDialog();

            DashBoard();

            modal.Close();
        }

        private void BtProduto_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, BtProduto.Location.Y);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            DataInicial.Value = Convert.ToDateTime("01/" + DateTime.Now.ToString("MM/yyyy"));
            DataFinal.Value = DataInicial.Value.AddMonths(1).AddDays(-1);

            DashBoard();
        }

        private void DashBoard()
        {
            string sql = "SELECT COUNT(*) FROM PESSOA WHERE ATIVO = 'S'";
            lblTotalPessoa.Text = BD.Buscar(sql).Rows[0][0].ToString();

            sql = "SELECT COUNT(*) FROM PRODUTO WHERE ATIVO = 'S'";
            lblTotalProduto.Text = BD.Buscar(sql).Rows[0][0].ToString();

            sql = "SELECT COUNT(*) FROM VENDA v WHERE v.SITUACAO_ID = 3";
            lblTotalVenda.Text = BD.Buscar(sql).Rows[0][0].ToString();
            
            sql = "SELECT COALESCE(SUM(c.TOTAL), 0) FROM COMPRA c WHERE c.SITUACAO_ID = 1";
            sql += " AND c.DATA BETWEEN '" + BD.CvData(DataInicial.Text) + "' AND '" + BD.CvData(DataFinal.Text) + "'";
            double vCompra = Convert.ToDouble(BD.Buscar(sql).Rows[0][0]);

            lblSomaCompra.Text = vCompra.ToString("c");

            sql = "SELECT COALESCE(SUM(v.TOTAL), 0) FROM VENDA v WHERE v.SITUACAO_ID = 3";
            sql += " AND v.DATA BETWEEN '" + BD.CvData(DataInicial.Text) + "' AND '" + BD.CvData(DataFinal.Text) + "'";
            double vVenda = Convert.ToDouble(BD.Buscar(sql).Rows[0][0]);

            lblSomaVenda.Text = vVenda.ToString("c");

            lblSaldoGeral.Text = (vVenda - vCompra).ToString("c");

            if (vVenda < vCompra)
                lblSaldoGeral.ForeColor = Color.Red;
            else
                lblSaldoGeral.ForeColor = Color.Green;



            sql = "SELECT FIRST 3 p.NOME, SUM((vi.QTD * vi.VL_UNIT) -(vi.DESC_RS + ((vi.QTD * vi.VL_UNIT) * (vi.DESC_PERC / 100)))) AS VENDA ";
            sql += "FROM VENDA_ITENS vi ";
            sql += "INNER JOIN VENDA v ON v.VENDA_ID = vi.VENDA_ID ";
            sql += "INNER JOIN PRODUTO p ON p.PRODUTO_ID = vi.PRODUTO_ID ";
            sql += "WHERE v.SITUACAO_ID = 3 AND v.DATA BETWEEN '" + BD.CvData(DataInicial.Text) + "' AND '" + BD.CvData(DataFinal.Text) + "' ";
            sql += "GROUP BY p.NOME ORDER BY VENDA DESC";

            graficoProduto.DataSource = BD.Buscar(sql);
            graficoProduto.DataBind();

            sql = "SELECT FIRST 3 p.NOME, SUM((vi.QTD * vi.VL_UNIT) -(vi.DESC_RS + ((vi.QTD * vi.VL_UNIT) * (vi.DESC_PERC / 100)))) AS VENDA ";
            sql += "FROM VENDA_ITENS vi ";
            sql += "INNER JOIN VENDA v ON v.VENDA_ID = vi.VENDA_ID ";
            sql += "INNER JOIN PESSOA p ON p.PESSOA_ID = v.PESSOA_ID ";
            sql += "WHERE v.SITUACAO_ID = 3 AND v.DATA BETWEEN '" + BD.CvData(DataInicial.Text) + "' AND '" + BD.CvData(DataFinal.Text) + "' ";
            sql += "GROUP BY p.NOME ORDER BY VENDA DESC";

            GraficoCliente.DataSource = BD.Buscar(sql);
            GraficoCliente.DataBind();

            DateTime Data = Convert.ToDateTime("01/" + DateTime.Now.ToString("MM/yyyy")).AddMonths(-11);

            sql = "SELECT extract(month from v.data), extract(year from v.data), ";
            sql += "CASE EXTRACT(MONTH FROM v.DATA) WHEN 1 THEN 'Jan' WHEN 2 THEN 'Fev' ";
            sql += "WHEN 3 THEN 'Mar' WHEN 4 THEN 'Abr' WHEN 5 THEN 'Mai' ";
            sql += "WHEN 6 THEN 'Jun' WHEN 7 THEN 'Jul' WHEN 8 THEN 'Ago' ";
            sql += "WHEN 9 THEN 'Set' WHEN 10 THEN 'Out' WHEN 11 THEN 'Nov' ";
            sql += "WHEN 12 THEN 'Dez' END AS MES, ";
            sql += "SUM((vi.QTD * vi.VL_UNIT) - (vi.DESC_RS + ((vi.QTD * vi.VL_UNIT) * (vi.DESC_PERC / 100)))) AS VENDA ";
            sql += "FROM VENDA_ITENS vi ";
            sql += "INNER JOIN VENDA v ON v.VENDA_ID = vi.VENDA_ID ";
            sql += "WHERE v.SITUACAO_ID = 3 AND v.DATA BETWEEN '" + Data.ToString("dd.MM.yyyy") +  "' AND CURRENT_DATE ";
            sql += "GROUP BY EXTRACT(MONTH FROM v.DATA), extract(year from v.data) ";
            sql += "order by EXTRACT(year FROM v.DATA) ASC, extract(month from v.data) ASC";

            graficoEvolutivo.DataSource = BD.Buscar(sql);
            graficoEvolutivo.DataBind();
        }

        private void BtCompra_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarra.Visible = true;
            lblBarra.Location = new Point(12, BtCompra.Location.Y);
        }

        private void BtCompra_Click(object sender, EventArgs e)
        {
            frmMenuCompra frm = new frmMenuCompra();
            frm.ShowDialog();

            DashBoard();
        }

        private void btVendas_Click(object sender, EventArgs e)
        {
            frmMenuVenda frm = new frmMenuVenda();
            frm.ShowDialog();

            DashBoard();
        }

        private void btFinanceiro_Click(object sender, EventArgs e)
        {
            frmFinanceiro frm = new frmFinanceiro();
            frm.ShowDialog();

            DashBoard();
        }

        private void DataInicial_ValueChanged(object sender, EventArgs e)
        {
            DashBoard();
        }

        private void DataFinal_ValueChanged(object sender, EventArgs e)
        {
            DashBoard();
        }
    }
}
