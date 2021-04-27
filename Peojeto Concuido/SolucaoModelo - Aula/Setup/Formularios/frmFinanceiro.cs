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
    public partial class frmFinanceiro : Form
    {
        public frmFinanceiro()
        {
            InitializeComponent();
        }


        private void frmFinanceiro_Load(object sender, EventArgs e)
        {
            CarregarTipoPgt();
            CarregarClienteProduto();
        }

        private void CarregarClienteProduto()
        {
            string sql = "SELECT p.NOME FROM PESSOA p ORDER BY p.NOME";
            cbCliente.DataSource = BD.Buscar(sql);
            cbCliente.SelectedIndex = -1;

            sql = "SELECT p.NOME FROM PRODUTO p ORDER BY p.NOME";
            cbProduto.DataSource = BD.Buscar(sql);
            cbProduto.SelectedIndex = -1;
        }


        private void CarregarTipoPgt()
        {
            cbTipoPagamento.DataSource = BD.Buscar("SELECT DISTINCT f.TIPO_PGT FROM FINANCEIRO f WHERE f.TIPO_PGT IS NOT NULL");
            cbTipoPagamento.SelectedIndex = -1;
        }


        private void BuscaFinanceiro(string Criterio)
        {
            string sql = "SELECT DISTINCT f.REFERENCIA_ID, REPLACE(REPLACE(f.REFERENCIA, 'VENDA - ', ''), ' N ', ' ') AS REFERENCIA, f.FINANCEIRO_ID, f.VENCIMENTO, f.NUM_PARCELA, p.NOME, " +
                "f.VALOR, COALESCE(f.DESCONTO, 0) AS DESCONTO, COALESCE(f.JURO, 0) AS JURO, " +
                "COALESCE(f.MULTA, 0) AS MULTA, f.VALOR_PAGO AS TOTAL, f.DATA_PAGOU, f.TIPO_PGT, " +
                "CASE WHEN f.VENCIMENTO < CURRENT_DATE THEN CURRENT_DATE - f.VENCIMENTO ELSE 0 END AS DIAS_VENCIDOS " +
                "FROM FINANCEIRO f " +
                "INNER JOIN VENDA v ON v.VENDA_ID = f.REFERENCIA_ID " +
                "INNER JOIN PESSOA p ON p.PESSOA_ID = v.PESSOA_ID " +
                "INNER JOIN VENDA_ITENS vi ON vi.VENDA_ID = v.VENDA_ID " +
                "INNER JOIN PRODUTO pr ON pr.PRODUTO_ID = vi.PRODUTO_ID " + Criterio + " ORDER BY f.REFERENCIA_ID, f.NUM_PARCELA";

            DataTable dt = BD.Buscar(sql);

            double vTotal = 0;
            double vMulta = 0;
            double vJuros = 0;
            int Dias = 0;

            foreach (DataRow lin in dt.Rows)
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
                }
            }

            dgFinanceiro.DataSource = dt;

            ConfigurarGridFinanceiro();

        }

        private void ConfigurarGridFinanceiro()
        {
            double Geral = 0;
            double Recebido = 0;
            double Credito = 0;
            double Debito = 0;
            double Cheque = 0;
            double Dinheiro = 0;
            double vVencido = 0;

            foreach (DataGridViewRow lin in dgFinanceiro.Rows)
            {
                lin.DefaultCellStyle.ForeColor = Color.Blue;

                if (lin.Cells["DiasVencidos"].Value.ToString() != "0" && lin.Cells["PAGOU"].Value.ToString() == "")
                {
                    lin.DefaultCellStyle.ForeColor = Color.Red;
                    vVencido += Convert.ToDouble(lin.Cells["Total"].Value);
                }

                Geral += Convert.ToDouble(lin.Cells["Total"].Value);

                if (lin.Cells["PAGOU"].Value.ToString() != "")
                {
                    Recebido += Convert.ToDouble(lin.Cells["Total"].Value);
                    lin.DefaultCellStyle.ForeColor = Color.Black;
                }

                if(lin.Cells["TipoPgt"].Value.ToString() == "CRÉDITO")
                    Credito += Convert.ToDouble(lin.Cells["Total"].Value);

                if (lin.Cells["TipoPgt"].Value.ToString() == "DÉBITO")
                    Debito += Convert.ToDouble(lin.Cells["Total"].Value);

                if (lin.Cells["TipoPgt"].Value.ToString() == "CHEQUE")
                    Cheque += Convert.ToDouble(lin.Cells["Total"].Value);

                if (lin.Cells["TipoPgt"].Value.ToString() == "DINHEIRO")
                    Dinheiro += Convert.ToDouble(lin.Cells["Total"].Value);

            }

            lblTotalGeral.Text = Geral.ToString("c");
            lblTotalRecebido.Text = Recebido.ToString("c");
            lblFaltaReceber.Text = (Geral - Recebido).ToString("c");

            lblTotalCredito.Text = Credito.ToString("c");
            lblTotalDebito.Text = Debito.ToString("c");

            lblTotalCheque.Text = Cheque.ToString("c");
            lblTotalDinheiro.Text = Dinheiro.ToString("c");

            lblVencidos.Text = vVencido.ToString("c");
        }

        

        private void cbTipoPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void cbTipoPagamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Escape || e.KeyCode == Keys.Back)
            {
                cbTipoPagamento.Text = "";
                cbTipoPagamento.SelectedIndex = -1;
            }
        }

        private void cbTipoPagamento_Leave(object sender, EventArgs e)
        {
            txtIdVenda.Text = "";
            txIdBoleto.Text = "";
        }

        private void txtIdVenda_Leave(object sender, EventArgs e)
        {
            
        }

        private void BuscaGeral()
        {
            string c = "";

            if (ckTodos.Checked == false)
            {
                if (txtIdVenda.Text != "")
                    c = " WHERE f.REFERENCIA_ID = " + txtIdVenda.Text;

                if (txIdBoleto.Text != "")
                    c = " WHERE f.FINANCEIRO_ID = " + txIdBoleto.Text;

                if (cbCliente.Text != "")
                    c = " WHERE p.NOME CONTAINING '" + cbCliente.Text + "' ";

                if (txtData.CustomFormat != " ")
                    c += " AND f.DATA_PAGOU IS NULL AND f.VENCIMENTO <= '" + BD.CvData(txtData.Text) + "'";

                if (ckVencidos.Checked)
                    c += " AND f.DATA_PAGOU IS NULL AND f.VENCIMENTO < CURRENT_DATE";

                if (ckPago.Checked)
                    c += " AND f.DATA_PAGOU IS NOT NULL";

                if (ckNaoPago.Checked)
                    c += " AND f.DATA_PAGOU IS NULL";

                if (cbTipoPagamento.Text != "")
                    c += " AND f.TIPO_PGT = '" + cbTipoPagamento.Text + "'";

                if (cbProduto.Text != "")
                    c += " AND pr.NOME CONTAINING '" + cbProduto.Text + "'";
            }

            if (c == "" && ckTodos.Checked == false)
            {
                Geral.Erro("Por Favor Informe a Opção de Busca!");
                return;
            }

            BuscaFinanceiro(c);
        }

        private void cbProduto_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            
        }

        private void dgFinanceiro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex >= 7 && e.ColumnIndex <= 9)
            {
                if (e.Value.ToString() == "0")
                    e.Value = "";
            }
        }

        private void dgFinanceiro_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    frmReceber frm = new frmReceber();

                    frm.txtIdFinanceiro.Text = dgFinanceiro.CurrentRow.Cells["IdBoleto"].Value.ToString();
                    frm.txtCliente.Text = dgFinanceiro.CurrentRow.Cells["Cliente"].Value.ToString();
                    frm.txtParcela.Text = dgFinanceiro.CurrentRow.Cells["Referencia"].Value.ToString();

                    frm.txtVencimento.Text = 
                        dgFinanceiro.CurrentRow.Cells["Vencimento"].Value.ToString().Replace("00:00:00", "").Trim();

                    double vValor = Convert.ToDouble(dgFinanceiro.CurrentRow.Cells["Valor"].Value);
                    frm.lblTotal.Text = vValor.ToString("c");

                    double vMulta = Convert.ToDouble(dgFinanceiro.CurrentRow.Cells["Multas"].Value);
                    frm.txtMulta.Text = vMulta.ToString("c");

                    double vJuros = Convert.ToDouble(dgFinanceiro.CurrentRow.Cells["Juros"].Value);
                    frm.txtJuros.Text = vJuros.ToString("c");

                    frm.txtAcrescimo.Text = (vMulta + vJuros).ToString("c");

                    frm.lblValorPago.Text = Convert.ToDouble(dgFinanceiro.CurrentRow.Cells["Total"].Value).ToString("c");

                    frm.lblDias.Text = dgFinanceiro.CurrentRow.Cells["DiasVencidos"].Value.ToString() +
                        " Dias Vencidos";

                    frm.txtIdVenda.Text = dgFinanceiro.CurrentRow.Cells["IdVenda"].Value.ToString();


                    if(dgFinanceiro.CurrentRow.Cells["Pagou"].Value.ToString() != "")
                    {
                        frm.grCliente.Enabled = false;
                        frm.grPagamento.Enabled = false;
                        frm.tabControl2.Enabled = false;
                        frm.lblAviso.Visible = true;
                    }

                    frm.ShowDialog();
                }
            }
        }

        private void txtIdVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            txIdBoleto.Text = "";

            cbCliente.Text = "";
            cbCliente.SelectedIndex = -1;

            cbProduto.Text = "";
            cbProduto.SelectedIndex = -1;

            cbTipoPagamento.Text = "";
            cbTipoPagamento.SelectedIndex = -1;

            txtData.Format = DateTimePickerFormat.Custom;
            txtData.CustomFormat = " ";

            ckTodos.Checked = false;
        }

        private void txIdBoleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtIdVenda.Text = "";

            cbCliente.Text = "";
            cbCliente.SelectedIndex = -1;

            cbProduto.Text = "";
            cbProduto.SelectedIndex = -1;

            cbTipoPagamento.Text = "";
            cbTipoPagamento.SelectedIndex = -1;

            txtData.Format = DateTimePickerFormat.Custom;
            txtData.CustomFormat = " ";

            ckVencidos.Checked = false;
            ckPago.Checked = false;
            ckNaoPago.Checked = false;
            ckTodos.Checked = false;
        }

        private void txIdBoleto_Leave(object sender, EventArgs e)
        {

        }

        private void cbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            ckTodos.Checked = false;
            txtIdVenda.Text = "";
            txIdBoleto.Text = "";
        }

        private void cbCliente_Leave(object sender, EventArgs e)
        {

        }

        private void cbProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            ckTodos.Checked = false;
            txtIdVenda.Text = "";
            txIdBoleto.Text = "";
        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {
            txtData.Format = DateTimePickerFormat.Short;
            txtData.CustomFormat = "dd/MM/yyyy";
            ckTodos.Checked = false;
            txtIdVenda.Text = "";
            txIdBoleto.Text = "";
        }

        private void ckVencidos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckVencidos.Checked)
            {
                txIdBoleto.Text = "";

                txtData.Format = DateTimePickerFormat.Custom;
                txtData.CustomFormat = " ";

                ckPago.Checked = false;
                ckNaoPago.Checked = false;
                ckTodos.Checked = false;

                cbTipoPagamento.Text = "";
                cbTipoPagamento.SelectedIndex = -1;
            }
        }

        private void ckPago_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPago.Checked)
            {
                txIdBoleto.Text = "";

                txtData.Format = DateTimePickerFormat.Custom;
                txtData.CustomFormat = " ";

                ckVencidos.Checked = false;
                ckNaoPago.Checked = false;
                ckTodos.Checked = false;
            }
        }

        private void ckNaoPago_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNaoPago.Checked)
            {
                txIdBoleto.Text = "";

                ckVencidos.Checked = false;
                ckPago.Checked = false;
                ckTodos.Checked = false;

                cbTipoPagamento.Text = "";
                cbTipoPagamento.SelectedIndex = -1;
            }
        }

        private void ckTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTodos.Checked)
            {
                txtIdVenda.Text = "";
                txIdBoleto.Text = "";

                cbCliente.Text = "";
                cbCliente.SelectedIndex = -1;

                cbProduto.Text = "";
                cbProduto.SelectedIndex = -1;

                cbTipoPagamento.Text = "";
                cbTipoPagamento.SelectedIndex = -1;

                txtData.Format = DateTimePickerFormat.Custom;
                txtData.CustomFormat = " ";

                ckVencidos.Checked = false;
                ckPago.Checked = false;
                ckNaoPago.Checked = false;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            BuscaGeral();
        }

        private void dgFinanceiro_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ConfigurarGridFinanceiro();
        }
    }
}
