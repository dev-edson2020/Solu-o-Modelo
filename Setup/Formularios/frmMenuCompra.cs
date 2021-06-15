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
    public partial class frmMenuCompra : Form
    {
        public frmMenuCompra()
        {
            InitializeComponent();
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            frmCadCompra frm = new frmCadCompra();
            frm.ShowDialog();
        }

        private void BtPessoa_Click(object sender, EventArgs e)
        {
            frmMenuPessoa frm = new frmMenuPessoa();
            frm.ShowDialog();
        }

        private void BtProduto_Click(object sender, EventArgs e)
        {
            frmMenuProduto frm = new frmMenuProduto();
            frm.ShowDialog();
        }

        private void frmMenuCompra_Load(object sender, EventArgs e)
        {
            RemoverGuias();
            tabControl1.TabPages.Add(tabBuscas);
            Rodape();
            CarregarInfoBusca();
        }

        private void CarregarInfoBusca()
        {
            string sql = "SELECT a.PESSOA_ID, a.NOME FROM PESSOA a ORDER BY a.NOME";
            cbFornecedor.DataSource = BD.Buscar(sql);
            cbFornecedor.SelectedIndex = -1;

            sql = "SELECT a.PRODUTO_ID, a.NOME FROM PRODUTO a ORDER BY a.NOME";
            cbProduto.DataSource = BD.Buscar(sql);
            cbProduto.SelectedIndex = -1;
        }

        private void RemoverGuias()
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabControl1.TabPages.Remove(tab);
            }
        }

        private void BuscarCompra()
        {
            string sql = "SELECT DISTINCT c.COMPRA_ID, p.NOME as FORNECEDOR, f.NOME as FINALIDADE, s.NOME as SITUACAO, ";
            sql += " c.NUM_NOTA, c.DATA, c.TOTAL, c.CADATRO";
            sql += " FROM COMPRA c";
            sql += " INNER JOIN PESSOA p ON c.PESSOA_ID = p.PESSOA_ID";
            sql += " INNER JOIN FINALIDADE f ON f.FINALIDADE_ID = c.FINALIDADE_ID";
            sql += " INNER JOIN SITUACAO s ON s.SITUACAO_ID = c.SITUACAO_ID";
            sql += " INNER JOIN COMPRA_ITENS ci ON ci.COMPRA_ID = c.COMPRA_ID";
            sql += " INNER JOIN PRODUTO pr ON pr.PRODUTO_ID = ci.PRODUTO_ID";
            sql += " WHERE c.FINALIDADE_ID = 1 ";

            if (txtNumNota.Text != "")
                sql += "AND c.NUM_NOTA = '" + txtNumNota.Text + "' ";

            if (cbFornecedor.Text != "")
                sql += "AND p.NOME containing '" + cbFornecedor.Text + "' ";

            if (cbProduto.Text != "")
                sql += "AND pr.NOME CONTAINING '" + cbProduto.Text + "'";

            try
            {
                DateTime DataI = Convert.ToDateTime(txtDataInicial.Text);
                DateTime DataF = Convert.ToDateTime(txtDataFinal.Text);

                sql += "AND c.DATA BETWEEN '" + BD.CvData(DataI.ToShortDateString()) +
                        "' AND '" + BD.CvData(DataF.ToShortDateString()) + "'";
            }
            catch
            { }

            if (ckCancelado.Checked)
                sql += "AND s.NOME = 'CANCELADA'";
            //else
            //sql += "AND s.NOME <> 'CANCELADA'";

            dgListaCompra.DataSource = BD.Buscar(sql);

            if (dgListaCompra.RowCount == 0)
                pnInfo.Visible = true;
            else
                pnInfo.Visible = false;

            ConfigurarLista();
            Rodape();
        }

        private void ConfigurarLista()
        {
            double soma = 0;

            foreach (DataGridViewRow Lin in dgListaCompra.Rows)
            {

                if (Lin.Cells["SITUACAO"].Value.ToString() == "CANCELADA")
                {
                    Lin.DefaultCellStyle.ForeColor = Color.Red;
                    Lin.Cells["TOTAL"].Value = 0;
                }
                else
                    soma +=  Convert.ToDouble(Lin.Cells["TOTAL"].Value);
            }

            lblSomaGeral.Text = soma.ToString("c");
        }

        private void Rodape()
        {
            string sql = "SELECT COUNT(*) AS GERAL, ";
            sql += "SUM(CASE WHEN c.SITUACAO_ID = 1 THEN 1 ELSE 0 END) AS NORMAL, ";
            sql += "SUM(CASE WHEN c.SITUACAO_ID = 2 THEN 1 ELSE 0 END) AS CANCELADA ";
            sql += "FROM COMPRA c";

            DataTable dt = BD.Buscar(sql);

            lblNComprasGeral.Text = dt.Rows[0][0].ToString() + " Todas";
            lblNCompraNormal.Text = dt.Rows[0][1].ToString() + " Normais";
            lblNCompraCancelada.Text = dt.Rows[0][2].ToString() + " Canceladas";
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if(dgListaCompra.Rows.Count==0)
            {
                Geral.Erro("Não há Compra Selecionada para Alterar!");
                return;
            }

            frmCadCompra frm = new frmCadCompra();
            frm.txtIdCompra.Text = dgListaCompra.CurrentRow.Cells["COMPRA_ID"].Value.ToString();
            frm.ShowDialog();

            BuscarCompra();
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            RemoverGuias();
            tabControl1.TabPages.Add(tabBuscas);
            btAlterar.Enabled = true;
            BtRelatorio.Enabled = true;
            BtDashBoard.Enabled = true;
            BtBuscar.Enabled = false;
        }

        private void BtDashBoard_Click(object sender, EventArgs e)
        {
            RemoverGuias();



            tabControl1.TabPages.Add(tabDashBoard);



            btAlterar.Enabled = false;
            BtRelatorio.Enabled = false;
            BtDashBoard.Enabled = false;
            BtBuscar.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumNota_TextChanged(object sender, EventArgs e)
        {
            BuscarCompra();
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFornecedor_TextChanged(object sender, EventArgs e)
        {
            BuscarCompra();
        }

        private void cbProduto_TextChanged(object sender, EventArgs e)
        {
            BuscarCompra();
        }

        private void txtDataInicial_TextChanged(object sender, EventArgs e)
        {
            //BuscarCompra();
        }

        private void txtDataFinal_TextChanged(object sender, EventArgs e)
        {
            //BuscarCompra();
        }

        private void txtDataInicial_Leave(object sender, EventArgs e)
        {
            BuscarCompra();
        }

        private void txtDataFinal_Leave(object sender, EventArgs e)
        {
            BuscarCompra();
        }

        private void frmMenuCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void ckCancelado_CheckedChanged(object sender, EventArgs e)
        {
            BuscarCompra();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtRelatorio_Click(object sender, EventArgs e)
        {
            frmRelatorioCompra frm = new frmRelatorioCompra();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
