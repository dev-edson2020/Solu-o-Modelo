using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Setup.Formularios
{
    public partial class frmRelatorioCompra : Form
    {
        public frmRelatorioCompra()
        {
            InitializeComponent();
        }

        private void btGerarPeriodo_Click(object sender, EventArgs e)
        {
            if(txtDataI1.Text == "" || txtDataF1.Text == "")
            {
                Geral.Erro("Preencha corretamente o período desejado!");
                return;
            }

            DateTime DataI = Convert.ToDateTime(txtDataI1.Text);
            DateTime DataF = Convert.ToDateTime(txtDataF1.Text);

            if(DataI.Date > DataF.Date)
            {
                Geral.Erro("Data Inicial deve ser menor ou igual a Data Final!");
                return;
            }

            string sql = "SELECT DISTINCT c.COMPRA_ID, p.NOME as FORNECEDOR, f.NOME as FINALIDADE, s.NOME as SITUACAO, ";
            sql += " c.NUM_NOTA, c.DATA, c.TOTAL, c.CADATRO AS CADASTRO";
            sql += " FROM COMPRA c";
            sql += " INNER JOIN PESSOA p ON c.PESSOA_ID = p.PESSOA_ID";
            sql += " INNER JOIN FINALIDADE f ON f.FINALIDADE_ID = c.FINALIDADE_ID";
            sql += " INNER JOIN SITUACAO s ON s.SITUACAO_ID = c.SITUACAO_ID";
            sql += " INNER JOIN COMPRA_ITENS ci ON ci.COMPRA_ID = c.COMPRA_ID";
            sql += " INNER JOIN PRODUTO pr ON pr.PRODUTO_ID = ci.PRODUTO_ID";

            sql += " WHERE c.DATA BETWEEN '" + BD.CvData(DataI.ToShortDateString()) +
                     "' AND '" + BD.CvData(DataF.ToShortDateString()) + "'";

            DataTable dt = BD.Buscar(sql);

            sql = "SELECT COALESCE(SUM(TOTAL), 0) FROM COMPRA c";
            sql += " INNER JOIN SITUACAO s ON s.SITUACAO_ID = c.SITUACAO_ID";
            sql += " WHERE s.NOME = 'NORMAL' and c.DATA BETWEEN '" + BD.CvData(DataI.ToShortDateString()) +
                    "' AND '" + BD.CvData(DataF.ToShortDateString()) + "'";

            double soma = Convert.ToDouble(BD.Buscar(sql).Rows[0][0].ToString());

            //foreach (DataRow item in dt.Rows)
            //{
            //    if (item["SITUACAO"].ToString().Trim() != "CANCELADA")
            //        soma += Convert.ToDouble(item["TOTAL"]);
            //}

            ReportParameterCollection p = new ReportParameterCollection();

            p.Add(new ReportParameter("periodo", txtDataI1.Text + " até " + txtDataF1.Text));
            p.Add(new ReportParameter("soma", soma.ToString("c")));

            ImprimirRelatorioCompra(opPDF1, "CompraPeriodo", p, dt, "Periodo");

        }


        private void ImprimirRelatorioCompra(RadioButton ck, string rdlc, ReportParameterCollection p, DataTable dt, string nome)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "Setup.Relatorios." + rdlc + ".rdlc";

            reportViewer1.LocalReport.SetParameters(p);

            ReportDataSource dados = new ReportDataSource("DataSet1", dt as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(dados);

            if (ck.Checked)
                Geral.ImprimirPDF(reportViewer1, "RelatorioCompra" + nome);
            else
                Geral.ImprimirExcel(reportViewer1, "RelatorioCompra" + nome);
        }


        private void frmRelatorioCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmRelatorioCompra_Load(object sender, EventArgs e)
        {
            CarregarFornecedor();
            CarregarProduto();
        }

        private void CarregarProduto()
        {
            string sql = "SELECT PRODUTO_ID, NOME FROM PRODUTO ORDER BY NOME";
            cbProduto.DataSource = BD.Buscar(sql);
            cbProduto.SelectedIndex = -1;
        }

        private void CarregarFornecedor()
        {
            string sql = "SELECT PESSOA_ID, NOME FROM PESSOA ORDER BY NOME";
            cbFornecedor.DataSource = BD.Buscar(sql);
            cbFornecedor.SelectedIndex = -1;
        } 

        private void btGerarFornecedor_Click(object sender, EventArgs e)
        {

            if (txtDataI2.Text == "" || txtDataF2.Text == "")
            {
                Geral.Erro("Preencha corretamente o período desejado!");
                return;
            }

            if(cbFornecedor.SelectedIndex==-1)
            {
                Geral.Erro("Selecione o Fornecedor!");
                return;
            }

            DateTime DataI = Convert.ToDateTime(txtDataI2.Text);
            DateTime DataF = Convert.ToDateTime(txtDataF2.Text);

            if (DataI.Date > DataF.Date)
            {
                Geral.Erro("Data Inicial deve ser menor ou igual a Data Final!");
                return;
            }

            string sql = "SELECT DISTINCT c.COMPRA_ID, f.NOME as FINALIDADE, s.NOME as SITUACAO, ";
            sql += "c.NUM_NOTA, c.DATA, c.TOTAL, c.CADATRO AS CADASTRO ";
            sql += "FROM COMPRA c ";
            sql += "INNER JOIN FINALIDADE f ON f.FINALIDADE_ID = c.FINALIDADE_ID ";
            sql += "INNER JOIN SITUACAO s ON s.SITUACAO_ID = c.SITUACAO_ID ";
            sql += "INNER JOIN COMPRA_ITENS ci ON ci.COMPRA_ID = c.COMPRA_ID ";
            sql += "INNER JOIN PRODUTO pr ON pr.PRODUTO_ID = ci.PRODUTO_ID ";
            sql += "WHERE C.SITUACAO_ID = 1 AND c.DATA BETWEEN '" + BD.CvData(txtDataI2.Text) + "' AND '" + BD.CvData(txtDataF2.Text) + "' AND c.PESSOA_ID = " + cbFornecedor.SelectedValue.ToString();

            DataTable dt = BD.Buscar(sql);

            sql = "SELECT COALESCE(SUM(TOTAL), 0) FROM COMPRA c";
            sql += " INNER JOIN SITUACAO s ON s.SITUACAO_ID = c.SITUACAO_ID";
            sql += " WHERE s.NOME = 'NORMAL' and c.DATA BETWEEN '" + BD.CvData(DataI.ToShortDateString()) +
                    "' AND '" + BD.CvData(DataF.ToShortDateString()) + "' AND c.PESSOA_ID = " + cbFornecedor.SelectedValue.ToString();

            double soma = Convert.ToDouble(BD.Buscar(sql).Rows[0][0].ToString());

            ReportParameterCollection p = new ReportParameterCollection();

            p.Add(new ReportParameter("periodo", txtDataI2.Text + " até " + txtDataF2.Text));
            p.Add(new ReportParameter("soma", soma.ToString("c")));
            p.Add(new ReportParameter("fornecedor", cbFornecedor.Text));

            ImprimirRelatorioCompra(opPDF2, "CompraFornecedor", p, dt, "Fornecedor");

        }

        private void btGerarProduto_Click(object sender, EventArgs e)
        {
            if(txtDataI3.Text == "" || txtDataF3.Text == "")
            {
                Geral.Erro("Informe as Datas do Período!");
                return;
            }

            if(cbProduto.SelectedIndex==-1)
            {
                Geral.Erro("Selecione o produto!");
                return;
            }

            string sql = "SELECT c.NUM_NOTA, c.DATA, p.NOME as FORNECEDOR, a.QTD, a.VL_UNIT, ";
            sql += "(a.QTD * a.VL_UNIT) as TOTAL, ";
            sql += "a.DESC_RS + ((a.QTD * a.VL_UNIT) * (a.DESC_PERC / 100)) AS TOTAL_DESCONTO, ";
            sql += "(a.QTD * a.VL_UNIT) -(a.DESC_RS + ((a.QTD * a.VL_UNIT) * (a.DESC_PERC / 100))) AS TOTAL_LIQUIDO ";
            sql += "FROM COMPRA_ITENS a ";
            sql += "INNER JOIN COMPRA c ON c.COMPRA_ID = a.COMPRA_ID ";
            sql += "inner join PESSOA p on p.PESSOA_ID = c.PESSOA_ID ";
            sql += "WHERE a.PRODUTO_ID = " + cbProduto.SelectedValue.ToString() + " AND c.DATA BETWEEN '" + BD.CvData(txtDataI3.Text) + "' AND '" + BD.CvData(txtDataF3.Text) + "' ";
            sql += "ORDER BY C.DATA";

            DataTable Relatorio = BD.Buscar(sql);

            ReportParameterCollection param = new ReportParameterCollection();

            param.Add(new ReportParameter("prod", cbProduto.Text));
            param.Add(new ReportParameter("periodo", txtDataI3.Text + " até " + txtDataF3.Text));

            ImprimirRelatorioCompra(opPDF3, "CompraProduto", param, Relatorio, "Produto");

        }
    }
}
