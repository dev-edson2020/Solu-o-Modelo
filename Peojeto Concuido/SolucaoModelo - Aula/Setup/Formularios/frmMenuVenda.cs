using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmMenuVenda : Form
    {
        public frmMenuVenda()
        {
            InitializeComponent();
        }

        private void frmMenuVenda_Load(object sender, EventArgs e)
        {
            RemoveGuias();
            tabControl1.TabPages.Add(tabBusca);
            CentralizarCabecalho();
            CarregarInfoBusca();
        }


        private void CarregarInfoBusca()
        {
            string sql = "SELECT a.PESSOA_ID, a.NOME FROM PESSOA a ORDER BY a.NOME";
            cbCliente.DataSource = BD.Buscar(sql);
            cbCliente.SelectedIndex = -1;

            sql = "SELECT a.PRODUTO_ID, a.NOME FROM PRODUTO a ORDER BY a.NOME";
            cbProduto.DataSource = BD.Buscar(sql);
            cbProduto.SelectedIndex = -1;
        }


        private void BuscarVenda()
        {
            string sql = "SELECT DISTINCT v.VENDA_ID, p.NOME AS CLIENTE, f.NOME AS FINALIDADE, ";
            sql += " s.NOME AS SITUACAO, v.NUM_NOTA, v.DATA, v.TOTAL, v.CADASTRO ";
            sql += " FROM VENDA v ";
            sql += " INNER JOIN PESSOA p ON p.PESSOA_ID = v.PESSOA_ID ";
            sql += " INNER JOIN FINALIDADE f ON f.FINALIDADE_ID = v.FINALIDADE_ID ";
            sql += " INNER JOIN SITUACAO s ON s.SITUACAO_ID = v.SITUACAO_ID ";
            sql += " INNER JOIN VENDA_ITENS vi ON vi.VENDA_ID = v.VENDA_ID ";
            sql += " INNER JOIN PRODUTO pr ON pr.PRODUTO_ID = vi.PRODUTO_ID ";
            sql += " WHERE v.FINALIDADE_ID = 2 ";


            string criterio = "";

            if (txtNumero.Text.Trim() != "")
                criterio += "AND v.NUM_NOTA = " + txtNumero.Text;

            if (cbCliente.Text.Trim() != "")
                criterio += "AND p.NOME CONTAINING '" + cbCliente.Text + "'";

            if (cbProduto.Text.Trim() != "")
                criterio += "AND pr.NOME CONTAINING '" + cbProduto.Text + "'";

            try
            {
                DateTime DataI = Convert.ToDateTime(txtDataI.Text);
                DateTime DataF = Convert.ToDateTime(txtDataF.Text);

                criterio += "AND v.DATA BETWEEN '" + BD.CvData(DataI.ToShortDateString()) + 
                    "' AND '" + BD.CvData(DataF.ToShortDateString()) + "'";

            }
            catch 
            { }

            if (ckAtivo.Checked)
                criterio += "AND s.NOME = 'CANCELADA'";

            sql += criterio;
            dgLista.DataSource = BD.Buscar(sql);

            ConfigurarLista();
            Rodape(criterio);

            if (dgLista.RowCount == 0)
            {
                pnInfo.Visible = true;
                btAlterar.Enabled = false;
            }
            else
            {
                pnInfo.Visible = false;
                btAlterar.Enabled = true;
            }
            
        }

        private void Rodape(string criterio)
        {
            string sql = "SELECT COUNT(*) AS GERAL, SUM(CASE WHEN v.SITUACAO_ID = 2 THEN 1 ELSE 0 END) AS CANCELADA FROM VENDA v ";
            sql += " INNER JOIN PESSOA p ON p.PESSOA_ID = v.PESSOA_ID ";
            sql += " INNER JOIN FINALIDADE f ON f.FINALIDADE_ID = v.FINALIDADE_ID ";
            sql += " INNER JOIN SITUACAO s ON s.SITUACAO_ID = v.SITUACAO_ID ";
            sql += " INNER JOIN VENDA_ITENS vi ON vi.VENDA_ID = v.VENDA_ID ";
            sql += " INNER JOIN PRODUTO pr ON pr.PRODUTO_ID = vi.PRODUTO_ID ";
            sql += "WHERE v.FINALIDADE_ID = 2 ";
            sql += criterio;
            DataTable dt = BD.Buscar(sql);

            if (dt.Rows[0]["GERAL"].ToString() == "1")
                lblTotalVendas.Text = "Total de 1 Venda";
            else
                lblTotalVendas.Text = "Total de " + dt.Rows[0]["GERAL"].ToString() + " Vendas";


            if (dt.Rows[0]["CANCELADA"].ToString() == "1")
                lblTotalCanceladas.Text = "1 Cancelada";
            else
                lblTotalCanceladas.Text = dt.Rows[0]["CANCELADA"].ToString() + " Canceladas";
        }

        private void ConfigurarLista()
        {
            double soma = 0;

            foreach (DataGridViewRow lin in dgLista.Rows)
            {
                if(lin.Cells["Situacao"].Value.ToString()=="CANCELADA")
                {
                    lin.DefaultCellStyle.ForeColor = Color.Red;
                    lin.Cells["Total"].Value = 0;
                }
                soma += Convert.ToDouble(lin.Cells["TOTAL"].Value);
            }

            lblSomaVenda.Text = soma.ToString("c");
        }

        private void CentralizarCabecalho()
        {
    
            for (int i = 0; i < dgLista.Columns.Count; i++)
            {
                if (i != 1)
                {
                    dgLista.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgLista.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            
        }


        private void RemoveGuias()
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(tab);
            }

        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            RemoveGuias();
            tabControl1.TabPages.Add(tabDashBoard);
            btDashBoard.Enabled = false;
            btPesquisa.Enabled = true;
            btAlterar.Enabled = false;
            btImprimir.Enabled = false;
        }

        private void btPesquisa_Click(object sender, EventArgs e)
        {
            RemoveGuias();
            tabControl1.TabPages.Add(tabBusca);
            btDashBoard.Enabled = true;
            btPesquisa.Enabled = false;
            btAlterar.Enabled = true;
            btImprimir.Enabled = true;
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            frmMenuPessoa frm = new frmMenuPessoa();
            frm.ShowDialog();
        }

        private void btProduto_Click(object sender, EventArgs e)
        {
            frmMenuProduto frm = new frmMenuProduto();
            frm.ShowDialog();
        }

        private void frmMenuVenda_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCadVenda frm = new frmCadVenda();
            frm.ShowDialog();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            frmCadVenda frm = new frmCadVenda();
            frm.txtIdVenda.Text = dgLista.CurrentRow.Cells["ID"].Value.ToString();
            frm.ShowDialog();

            BuscarVenda();

            foreach (DataGridViewRow linha in dgLista.Rows)
            {
                if (linha.Cells["ID"].Value.ToString() == "13")
                {
                    dgLista.CurrentCell = linha.Cells["ID"];
                    break;
                }
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BuscarVenda();
                e.SuppressKeyPress = true;
            }
        }

        private void cbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarVenda();
                e.SuppressKeyPress = true;
            }
        }

        private void cbProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarVenda();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDataI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarVenda();
                e.SuppressKeyPress = true;
            }
        }

        private void txtDataF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarVenda();
                e.SuppressKeyPress = true;
            }
        }

        private void dgLista_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "UPDATE VENDA SET NUM_NOTA = " + dgLista.CurrentCell.Value.ToString() + " WHERE VENDA_ID = " + 
                dgLista.CurrentRow.Cells["ID"].Value.ToString();

            BD.ExecutarSQL(sql);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
