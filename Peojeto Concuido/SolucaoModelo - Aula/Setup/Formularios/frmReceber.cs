using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Setup.Formularios
{
    public partial class frmReceber : Form
    {
        DS.TabComprovanteDataTable dtComprovante;

        public frmReceber()
        {
            InitializeComponent();
        }

        private void ckNaoCobrarAcrescimo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNaoCobrarAcrescimo.Checked)
                txtDesconto.Text = txtAcrescimo.Text;
            else
                txtDesconto.Text = "";

            CarregarFinanceiro();
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double vValor = Convert.ToDouble(lblTotal.Text.Replace("R$", "").Trim());
                double vAcres = Convert.ToDouble(txtAcrescimo.Text.Replace("R$", "").Trim());

                double vDesconto = 0;
                if (txtDesconto.Text != "")
                    vDesconto = Convert.ToDouble(txtDesconto.Text.Replace("R", "").Replace("$", "").Trim());

                lblValorPago.Text = (vValor + vAcres - vDesconto).ToString("c");
            }
            catch
            {
                lblValorPago.Text = "";
            }
        }

        private void BtReceberDinheiro_Click(object sender, EventArgs e)
        {
            if (txtDinheiro.Text.Trim() == "")
            {
                Geral.Erro("Digite o valor recebido em dinheiro");
                return;
            }

            double vDinheiro = Geral.CvDbl(txtDinheiro.Text);
            double vTroco = Geral.CvDbl(lblTroco.Text);

            ReceberCrediario((vDinheiro - vTroco).ToString(), "DINHEIRO");

            txtDinheiro.Text = "";
        }

        private void ReceberCrediario(string vValor, string vTipo)
        {
            double vParcela = Geral.CvDbl(lblTotal.Text);
            double vPagar = Geral.CvDbl(lblValorPago.Text);
            double vPago = Geral.CvDbl(vValor);

            double vFalta = Geral.CvDbl(lblFaltaPagar.Text);

            string sql = "";

            if(vPago > vFalta)
            {
                Geral.Erro("Não Será Possível Prosseguir!\r\n\r\nValor Superior ao Total que Falta Receber dessa Venda!");
                return;
            }

            double vSobra = 0;

            if (ckAbater.Checked)
                vSobra = vPago - vPagar;

            if (vPago < vPagar)
            {
                Geral.Pergunta("Valor Recebido é Menor que o Valor à Receber, Confirmar?");

                if (!Geral.Resposta)
                    return;
            }
            else if (vSobra > 0)
            {
                Geral.Pergunta("Valor Maior que o Valor à Receber, Deseja Abater a Diferença nas Próximas Parcelas?");

                if (!Geral.Resposta)
                    return;
            }
            else
            {
                Geral.Pergunta("Deseja Realmente lançar esse Recebimento?");

                if (!Geral.Resposta)
                    return;
            }

            if (!ckNaoCobrarAcrescimo.Checked && vPago >= vFalta)
                ReceberComJuros(vValor, vTipo);
            else
            {
                if (vPago < vPagar)
                    ReceberMenos(vValor, vTipo);
                else
                    ReceberNormal(vValor, vTipo);
            }

            if (vPago < vPagar && vPago != vParcela)
            {
                sql = "INSERT INTO FINANCEIRO VALUES(NULL, 'C', 'VENDA - PARCELA N " + txtParcela.Text.Replace("PARCELA ","") + "', '" + txtIdVenda.Text + "', '" + txtParcela.Text.Replace("PARCELA ", "") + "', " + BD.cvNum(((vPago - vParcela) * -1).ToString()) + ", '" + BD.CvData(txtVencimento.Text) + "', '" + BD.cvNum(((vPago - vParcela)*-1).ToString()) + "', NULL, NULL, NULL, NULL, '')";
                BD.ExecutarSQL(sql);
            }

            if (vSobra > 0)
            {
                //Pegar as Parcelas Não Pagas
                sql = "SELECT f.FINANCEIRO_ID, f.VALOR_PAGO, f.NUM_PARCELA, f.VENCIMENTO " +
                    "FROM FINANCEIRO f " +
                    "WHERE f.REFERENCIA_ID = " + txtIdVenda.Text + " AND f.DATA_PAGOU IS NULL " +
                    " ORDER BY f.FINANCEIRO_ID, f.NUM_PARCELA";

                DataTable dt = BD.Buscar(sql);
                double vProxParcela = 0;

                foreach (DataRow lin in dt.Rows)
                {
                    if (vSobra == 0)
                        break;

                    vProxParcela = Convert.ToDouble(lin["VALOR_PAGO"]);

                    if (vSobra < vProxParcela)
                    {
                        sql = "UPDATE FINANCEIRO f SET f.VALOR_PAGO = " + BD.cvNum((vProxParcela - vSobra).ToString()) +
                            "WHERE f.FINANCEIRO_ID = " + lin["FINANCEIRO_ID"].ToString();

                        BD.ExecutarSQL(sql);

                        break;
                    }
                    else
                    {                       

                        sql = "UPDATE FINANCEIRO f SET f.VALOR_PAGO = 0 " +
                                ", f.DATA_PAGOU = CURRENT_DATE, " +
                                "f.DESCONTO = 0, f.JURO = 0, f.MULTA = 0, f.TIPO_PGT = '" + vTipo + "' " +
                                "WHERE f.FINANCEIRO_ID = " + lin["FINANCEIRO_ID"].ToString();

                        BD.ExecutarSQL(sql);

                        DataRow linC = dtComprovante.NewRow();

                        linC["Parcela"] = "PARCELA " + lin["NUM_PARCELA"].ToString();
                        linC["Vencimento"] = lin["VENCIMENTO"].ToString().Replace(" 00:00:00", "");
                        linC["Valor"] = "R$ 0,00";

                        dtComprovante.Rows.Add(linC);
                    }

                    vSobra -= vProxParcela;
                }

            }

            ImprimirComprovante(vValor, vTipo);

        }

        private void ImprimirComprovante(string vValor, string vTipo)
        {
            ReportParameterCollection p = new ReportParameterCollection();

            p.Add(new ReportParameter("IdVenda", txtIdVenda.Text));
            p.Add(new ReportParameter("Cliente", txtCliente.Text));
            p.Add(new ReportParameter("Data", DateTime.Now.ToShortDateString()));
            p.Add(new ReportParameter("Total", Geral.CvDbl(vValor).ToString("c")));
            p.Add(new ReportParameter("Tipo", vTipo));

            reportViewer1.LocalReport.SetParameters(p);

            ReportDataSource rds = new ReportDataSource("DataSet1", dtComprovante as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.Refresh();

            Geral.ImprimirPDF(reportViewer1, "Comprovante");
        }

        private void ReceberNormal(string vValor, string vTipo)
        {
            string sql = "UPDATE FINANCEIRO f SET f.VALOR_PAGO = " + BD.cvNum(vValor) +
                        ", f.DATA_PAGOU = CURRENT_DATE, " +
                        "f.DESCONTO = " + BD.cvNum(txtDesconto.Text) +
                        ", f.JURO = " + BD.cvNum(txtJuros.Text) +
                        ", f.MULTA = " + BD.cvNum(txtMulta.Text) + ", f.TIPO_PGT = '" + vTipo + "' " +
                        "WHERE f.FINANCEIRO_ID = " + txtIdFinanceiro.Text;

            BD.ExecutarSQL(sql);            

            DataRow lin = dtComprovante.NewRow();

            lin["Parcela"] = txtParcela.Text;
            lin["Vencimento"] = txtVencimento.Text;
            lin["Valor"] = Geral.CvDbl(vValor).ToString("c");

            dtComprovante.Rows.Add(lin);
        }

        private void ReceberMenos(string vValor, string vTipo)
        {
            string sql = "UPDATE FINANCEIRO f SET f.VALOR_PAGO = " + BD.cvNum(vValor) +
                        ", f.DATA_PAGOU = CURRENT_DATE, " +
                        "f.DESCONTO = 0, f.JURO = 0, f.MULTA = 0, f.TIPO_PGT = '" + vTipo + "' " +
                        "WHERE f.FINANCEIRO_ID = " + txtIdFinanceiro.Text;

            BD.ExecutarSQL(sql);

            DataRow lin = dtComprovante.NewRow();

            lin["Parcela"] = txtParcela.Text;
            lin["Vencimento"] = txtVencimento.Text;
            lin["Valor"] = Geral.CvDbl(vValor).ToString("c");

            dtComprovante.Rows.Add(lin);
        }

        private void ReceberComJuros(string vValor, string vTipo)
        {
            double vJuro = 0;
            double vMulta = 0;

            foreach (DataGridViewRow lin in dgFinanceiro.Rows)
            {
                if(lin.Cells["Pagou"].Value.ToString()=="")
                {
                    vJuro += Convert.ToDouble(lin.Cells["Juros"].Value);
                    vMulta += Convert.ToDouble(lin.Cells["Multa"].Value);
                }
            }


            string sql = "UPDATE FINANCEIRO f SET f.VALOR_PAGO = " + BD.cvNum(vValor) +
                        ", f.DATA_PAGOU = CURRENT_DATE, " +
                        "f.DESCONTO = " + BD.cvNum(txtDesconto.Text) +
                        ", f.JURO = " + BD.cvNum(vJuro.ToString()) +
                        ", f.MULTA = " + BD.cvNum(vMulta.ToString()) + ", f.TIPO_PGT = '" + vTipo + "' " +
                        "WHERE f.FINANCEIRO_ID = " + txtIdFinanceiro.Text;

            BD.ExecutarSQL(sql);

            DataRow linC = dtComprovante.NewRow();

            linC["Parcela"] = txtParcela.Text;
            linC["Vencimento"] = txtVencimento.Text;
            linC["Valor"] = Convert.ToDouble(vValor).ToString("c");

            dtComprovante.Rows.Add(linC);
        }

        private void BtCartaoCredito_Click(object sender, EventArgs e)
        {
            if (txtCredito.Text.Trim() == "")
            {
                Geral.Erro("Informe o valor pago!");
                return;
            }

            if (txtDividirCredito.Text.Trim() == "")
            {
                Geral.Erro("Informe a quantidade parcelas!");
                return;
            }

            ReceberCrediario(txtCredito.Text, "CRÉDITO");
        }

        private void BtDebito_Click(object sender, EventArgs e)
        {
            if (txtDebito.Text.Trim() == "")
            {
                Geral.Erro("Informe o valor a receber!");
                return;
            }

            ReceberCrediario(txtDebito.Text, "DÉBITO");
        }

        private void BtCheque_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(tabPage8, errorProvider1))
                return;

            ReceberCrediario(txtValorCheque.Text, "CHEQUE");

            SalvarCheque();
        }

        private void SalvarCheque()
        {
            string[] c = new string[5];
            string[] v = new string[5];

            c[0] = "TITULAR";
            v[0] = cbTitular.Text;

            c[1] = "NUMERO";
            v[1] = txtNumeroCheque.Text;

            c[2] = "DATA";
            v[2] = BD.CvData(txtDataCheque.Text);

            c[3] = "VALOR";
            v[3] = BD.cvNum(txtValorCheque.Text);

            c[4] = "VENDA_ID";
            v[4] = txtIdVenda.Text;

            BD.Salvar("CHEQUE", c, v);
        }

        private void frmReceber_Load(object sender, EventArgs e)
        {
            CarregarTitularCheque();
            CarregarFinanceiro();
            dtComprovante = new DS.TabComprovanteDataTable();
            dtComprovante.Rows.Clear();
        }

        private void CarregarTitularCheque()
        {
            string sql = "SELECT DISTINCT TITULAR FROM CHEQUE ORDER BY TITULAR";
            cbTitular.DataSource = BD.Buscar(sql);
            cbTitular.SelectedIndex = -1;
        }

        private void CarregarFinanceiro()
        {
            string sql = "SELECT f.FINANCEIRO_ID, f.VENCIMENTO, f.NUM_PARCELA, " +
                "f.VALOR, COALESCE(f.DESCONTO, 0) AS DESCONTO, COALESCE(f.JURO, 0) AS JURO, " +
                "COALESCE(f.MULTA, 0) AS MULTA, f.VALOR_PAGO AS TOTAL, f.DATA_PAGOU, f.TIPO_PGT, " +
                "CASE WHEN f.VENCIMENTO < CURRENT_DATE THEN CURRENT_DATE - f.VENCIMENTO ELSE 0 END AS DIAS_VENCIDOS " +
                "FROM FINANCEIRO f " +
                " WHERE f.REFERENCIA_ID = " + txtIdVenda.Text +  " ORDER BY f.NUM_PARCELA";

            DataTable dt = BD.Buscar(sql);

            double vTotal = 0;
            double vMulta = 0;
            double vJuros = 0;
            int Dias = 0;
            double vFalta = 0;

            foreach (DataRow lin in dt.Rows)
            {
                if (ckNaoCobrarAcrescimo.Checked && lin["DATA_PAGOU"].ToString() == "")
                {
                    vFalta += Geral.CvDbl(lin["TOTAL"].ToString());
                }
                else
                {
                    if (lin["DIAS_VENCIDOS"].ToString() != "0" && lin["DATA_PAGOU"].ToString() == "")
                    {
                        vTotal = Convert.ToDouble(lin["Total"]);

                        vMulta = vTotal * 0.02;
                        lin["MULTA"] = vMulta;

                        Dias = Convert.ToInt32(lin["DIAS_VENCIDOS"]);
                        vJuros = (vTotal * 0.002) * Dias;
                        lin["JURO"] = vJuros;

                        lin["TOTAL"] = vTotal + vMulta + vJuros;

                        vFalta += vTotal + vMulta + vJuros;
                    }
                    else if (lin["DATA_PAGOU"].ToString() == "")
                        vFalta += Geral.CvDbl(lin["TOTAL"].ToString());
                }
            }

            dgFinanceiro.DataSource = dt;

            foreach (DataGridViewRow lin in dgFinanceiro.Rows)
            {
                if (lin.Cells["DIASVENCIDOS"].Value.ToString() != "0" && lin.Cells["PAGOU"].Value.ToString() == "")
                    lin.DefaultCellStyle.ForeColor = Color.Red;
            }

            lblFaltaPagar.Text = vFalta.ToString("c");
        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            double vValor = Geral.CvDbl(lblValorPago.Text);
            double vDinheiro = Geral.CvDbl(txtDinheiro.Text);

            if (vDinheiro > vValor)
            {
                lblTroco.Text = (vDinheiro - vValor).ToString("c");
                ckAbater.Visible = true;
            }
            else
            {
                lblTroco.Text = "R$ 0,00";
                ckAbater.Visible = false;
            }

            lblTrocoAux.Text = lblTroco.Text;
        }

        private void ckAbater_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAbater.Checked)
            {
                double vDinheiro = Geral.CvDbl(txtDinheiro.Text);
                double vFalta = Geral.CvDbl(lblFaltaPagar.Text);

                if (vDinheiro > vFalta)
                    lblTroco.Text = (vDinheiro - vFalta).ToString("c");
                else
                    lblTroco.Text = "R$ 0,00";
            }
            else
                lblTroco.Text = lblTrocoAux.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Geral.LarguraColunas(dgFinanceiro);
        }

        private void dgFinanceiro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 || e.ColumnIndex == 5 || e.ColumnIndex == 6)
            {
                if (e.Value.ToString() == "0")
                    e.Value = "";
            }
        }
    }
}
