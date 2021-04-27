using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Setup.Formularios
{
    public partial class frmCadVenda : Form
    {
        int Alteracao;

        public frmCadVenda()
        {
            Alteracao = 0;
            InitializeComponent();
        }

        private void frmCadVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void frmCadVenda_Load(object sender, EventArgs e)
        {
            CarregarFinalidade();
            CarregarSituacao();
            CarregarClientes();
            CarregarProdutos();
            CarregarTitularCheque();

            if (txtIdVenda.Text != "")
                PegarVenda();
            else
            {
                GerarNumNota();
                txtDataEmissao.Text = DateTime.Now.ToShortDateString();
                cbCliente.Focus();
            }

        }

        private void RemoveGuias()
        {
            foreach (TabPage tab in tabEntrada.TabPages)
            {
                tabEntrada.TabPages.Remove(tab);
            }
        }

        private void CarregarTitularCheque()
        {
            string sql = "SELECT DISTINCT TITULAR FROM CHEQUE ORDER BY TITULAR";
            cbTitular.DataSource = BD.Buscar(sql);
            cbTitular.SelectedIndex = -1;
        }

        private void GerarNumNota()
        {
            string sql = "SELECT COALESCE(MAX(NUM_NOTA), 0) + 1 AS ID FROM VENDA";
            txtNumero.Text = BD.Buscar(sql).Rows[0]["ID"].ToString();
        }

        private void VendaFinalizada()
        {
            if (cbSituacao.SelectedIndex == 2)
            {
                txtValorEntrada.Enabled = false;
                txtQtdParcela.Enabled = false;
                txtPriVencimento.Enabled = false;
                BtFinalizarCreidiario.Enabled = false;
                BuscarCrediarioVendaFinalizada();
                cbProduto.Enabled = false;
                txtQtd.Enabled = false;
                ValorProduto.Enabled = false;
                txtDescRS.Enabled = false;
                txtDescPerc.Enabled = false;
                lblReceberTotal.Text = lblTotalLiquido.Text;

                ListarPagamentos();
            }
            else
            {
                txtValorEntrada.Enabled = true;
                txtQtdParcela.Enabled = true;
                txtPriVencimento.Enabled = true;
                BtFinalizarCreidiario.Enabled = true;
                cbProduto.Enabled = true;
                txtQtd.Enabled = true;
                ValorProduto.Enabled = true;
                txtDescRS.Enabled = true;
                txtDescPerc.Enabled = true;
            }
        }

        private void BuscarCrediarioVendaFinalizada()
        {
            string sql = "SELECT a.VALOR_ENTRADA, a.PARCELAS, a.PRI_VECIMENTO ";
            sql += "FROM VENDA a ";
            sql += "WHERE a.TIPO_PAGAMENTO = 'Crediário' AND a.VENDA_ID = " + txtIdVenda.Text;

            DataTable dt = BD.Buscar(sql);

            if (dt.Rows.Count > 0)
            {
                txtValorEntrada.Text = Convert.ToDouble(dt.Rows[0]["VALOR_ENTRADA"]).ToString("c");
                txtQtdParcela.Text = dt.Rows[0]["PARCELAS"].ToString();
                txtPriVencimento.Text = dt.Rows[0]["PRI_VECIMENTO"].ToString().Replace("00:00:00", "").Trim();
                CalcularParcelamento();
            }
        }

        private void CalcularParcelamento()
        {
            try
            {
                lblTotalVenda.Text = lblTotalLiquido.Text;

                double TotalVenda = Convert.ToDouble(lblTotalVenda.Text.Replace("R", "").Replace("$", "").Trim());
                double Entrada = 0;
                double QtdParcela = 1;
                double ValorParcelar;

                if (txtValorEntrada.Text.Trim() != "")
                    Entrada = Convert.ToDouble(txtValorEntrada.Text.Replace("R", "").Replace("$", "").Trim());

                if (txtQtdParcela.Text.Trim() != "")
                    QtdParcela = Convert.ToDouble(txtQtdParcela.Text.Trim());

                lblTotalParcelar.Text = (TotalVenda - Entrada).ToString("c");

                ValorParcelar = Convert.ToDouble(lblTotalParcelar.Text.Replace("R$", "").Trim());

                txtValorParcela.Text = (ValorParcelar / QtdParcela).ToString("c");

                lblInfoParcelamento.Text = "Fechar a Venda no Crediário ";

                if (Entrada > 0)
                    lblInfoParcelamento.Text += ", com uma Entrada de " + txtValorEntrada.Text;

                lblInfoParcelamento.Text += ", dividido em " + txtQtdParcela.Text + " vezes de " + txtValorParcela.Text;

            }
            catch
            {
                lblTotalParcelar.Text = "";
            }

        }

        private void PegarVenda()
        {
            cbFinalidade.SelectedIndex = 1;

            string sql = "SELECT SITUACAO_ID, DATA, NUM_NOTA, PESSOA_ID FROM VENDA ";
            sql += " WHERE VENDA_ID = " + txtIdVenda.Text;

            DataTable dt = BD.Buscar(sql);

            txtNumero.Text = dt.Rows[0]["NUM_NOTA"].ToString();
            txtDataEmissao.Text = Convert.ToDateTime(dt.Rows[0]["DATA"]).ToShortDateString();
            cbSituacao.SelectedValue = dt.Rows[0]["SITUACAO_ID"].ToString();
            cbCliente.SelectedValue = dt.Rows[0]["PESSOA_ID"];
            SelecionarCliente();
            cbCliente.Enabled = false;

            CarregarItens();

            VendaFinalizada();

            BtImprimir.Enabled = true;

        }

        private void CarregarProdutos()
        {
            string sql = "SELECT PRODUTO_ID, NOME FROM PRODUTO ORDER BY NOME";
            cbProduto.DataSource = BD.Buscar(sql);
            cbProduto.SelectedIndex = -1;
        }

        private void CarregarFinalidade()
        {
            string sql = "SELECT * FROM FINALIDADE a ORDER BY a.FINALIDADE_ID";
            cbFinalidade.DataSource = BD.Buscar(sql);
            cbFinalidade.SelectedIndex = 1;
        }

        private void CarregarSituacao()
        {
            string sql = "SELECT * FROM SITUACAO ORDER BY SITUACAO_ID";
            cbSituacao.DataSource = BD.Buscar(sql);
            cbSituacao.SelectedIndex = 0;
        }

        private void CarregarClientes()
        {
            string sql = "SELECT a.PESSOA_ID, a.NOME FROM PESSOA a ORDER BY a.NOME";
            cbCliente.DataSource = BD.Buscar(sql);
            cbCliente.SelectedIndex = -1;
        }

        private void SelecionarCliente()
        {
            cbCliente.SelectedIndex = cbCliente.FindStringExact(cbCliente.Text);

            string sql;
            DataTable dt;

            if (cbCliente.SelectedIndex == -1 && cbCliente.Text != "")
            {
                sql = "SELECT NOME FROM PESSOA WHERE CODIGO = '" + cbCliente.Text + "'";
                dt = BD.Buscar(sql);

                if (dt.Rows.Count > 0)
                {
                    cbCliente.Text = dt.Rows[0]["NOME"].ToString();
                    cbCliente.SelectedIndex = cbCliente.FindStringExact(cbCliente.Text);
                }
            }

            if (cbCliente.SelectedIndex == -1)
            {
                txtCod.Text = "";
                txtDocumento.Text = "";
                txtCidade.Text = "";
            }
            else
            {
                sql = "SELECT a.CODIGO, a.CPF, a.CNPJ, c.CIDADE ";
                sql += "FROM PESSOA a ";
                sql += "INNER JOIN ENDERECO e ON e.PESSOA_ID = a.PESSOA_ID ";
                sql += "INNER JOIN CIDADE c ON c.CIDADE_ID = e.CIDADE_ID ";
                sql += "WHERE a.PESSOA_ID = " + cbCliente.SelectedValue.ToString();

                dt = BD.Buscar(sql);

                txtCod.Text = dt.Rows[0]["CODIGO"].ToString();
                txtDocumento.Text = dt.Rows[0]["CPF"].ToString() + dt.Rows[0]["CNPJ"].ToString();
                txtCidade.Text = dt.Rows[0]["CIDADE"].ToString();

            }
        }

        private void cbCliente_Leave(object sender, EventArgs e)
        {
            SelecionarCliente();
        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProduto_Leave(object sender, EventArgs e)
        {
            Selecionarproduto();
        }

        private void Selecionarproduto()
        {
            if (cbProduto.Text == "")
                return;

            cbProduto.SelectedIndex = cbProduto.FindString(cbProduto.Text);
            string sql = "";
            DataTable dt;

            if (cbProduto.SelectedIndex == -1 && cbProduto.Text != "")
            {
                sql = "SELECT NOME FROM PRODUTO WHERE COD = '@' OR COD_BARRA = '@'";
                sql = sql.Replace("@", cbProduto.Text);
                dt = BD.Buscar(sql);

                if (dt.Rows.Count > 0)
                {
                    cbProduto.Text = dt.Rows[0]["NOME"].ToString();
                    cbProduto.SelectedIndex = cbProduto.FindStringExact(cbProduto.Text);
                }
                else
                    Geral.Erro("Código não Localizado");
            }

            if (cbProduto.SelectedIndex == -1)
            {
                CodProduto.Text = "";
                Estoque.Text = "";
                ValorProduto.Text = "";
                Estoque.BackColor = Color.LightGray;
            }
            else
            {
                sql = "SELECT a.COD, a.VENDA, a.ESTOQUE_ATUAL, ";
                sql += "CASE WHEN a.ESTOQUE_ATUAL <= a.ESTOQUE_MINIMO THEN 'S' ";
                sql += "ELSE 'N' END AS SITUACAO ";
                sql += "FROM PRODUTO a WHERE a.PRODUTO_ID = " + cbProduto.SelectedValue.ToString();

                dt = BD.Buscar(sql);

                CodProduto.Text = dt.Rows[0]["COD"].ToString();
                Estoque.Text = dt.Rows[0]["ESTOQUE_ATUAL"].ToString();
                ValorProduto.Text = dt.Rows[0]["VENDA"].ToString();

                if (dt.Rows[0]["SITUACAO"].ToString() == "S")
                    Estoque.BackColor = Color.LightPink;
                else
                    Estoque.BackColor = Color.LightGreen;
            }
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Selecionarproduto();
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void CalculoVenda()
        {
            double Qtd = 0;
            double Unit = 0;
            double DescRS = 0;
            double DescPerc = 0;

            try
            {
                if (txtQtd.Text.Trim() != "")
                    Qtd = Convert.ToDouble(txtQtd.Text);

                if (ValorProduto.Text.Trim() != "")
                    Unit = Convert.ToDouble(ValorProduto.Text.Replace("R$", "").Trim());

                txtValorBruto.Text = (Qtd * Unit).ToString("c");

                if (txtDescRS.Text.Trim() != "")
                    DescRS = Convert.ToDouble(txtDescRS.Text.Replace("R$", "").Trim());

                if (txtDescPerc.Text.Trim() != "")
                    DescPerc = Convert.ToDouble(txtDescPerc.Text.Replace("R$", "").Trim());

                if (DescRS > 0)
                {
                    txtTotalDesconto.Text = (DescRS).ToString("c");
                    txtTotalDescPerc.Text = "R$ 0,00";
                }
                else
                {
                    txtTotalDescPerc.Text = ((Qtd * Unit) * (DescPerc / 100)).ToString("c");
                    txtTotalDesconto.Text = ((Qtd * Unit) * (DescPerc / 100)).ToString("c");
                }

                txtTotalLiquido.Text = (Convert.ToDouble(txtValorBruto.Text.Replace("R$", "").Trim()) -
                    Convert.ToDouble(txtTotalDesconto.Text.Replace("R$", "").Trim())).ToString("c");

            }
            catch
            {
                txtValorBruto.Text = "R$ 0,00";
                txtTotalLiquido.Text = "R$ 0,00";
            }
        }

        private void ValorProduto_TextChanged(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void txtDescRS_TextChanged(object sender, EventArgs e)
        {
            if (txtDescRS.Text != "" && Convert.ToDouble(txtDescRS.Text.Replace("R", "").Replace("$", "").Trim()) > 0)
                txtDescPerc.Text = "";
        }

        private void txtDescPerc_TextChanged(object sender, EventArgs e)
        {
            if (txtDescPerc.Text != "" && Convert.ToDouble(txtDescPerc.Text.Replace("R", "").Replace("$", "").Trim()) > 0)
                txtDescRS.Text = "";
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (VerificarStatus())
                return;

            Alteracao = 1;

            if (ValidarInfoGerais())
                return;

            if (ValidarCliente())
                return;

            if (ValidarItens())
                return;

            if (VerificaDuplicidade())
                return;

            if (txtIdVenda.Text == "")
                SalvarVenda();

            if (txtIdVenda.Text != "")
            {
                if (SalvarItemVenda() == 0)
                {
                    LimparItens();
                    CarregarItens();
                }
            }
        }

        private void CalculoRodape()
        {
            double itens = 0;
            double TotalQtd = 0;
            double Bruto = 0;
            double Desc = 0;
            double Liquido = 0;

            foreach (DataGridViewRow lin in dgProdutos.Rows)
            {
                itens++;

                TotalQtd += Convert.ToDouble(lin.Cells["Qtd"].Value);

                Bruto += Convert.ToDouble(lin.Cells["Bruto"].Value);
                Desc += Convert.ToDouble(lin.Cells["TotalDesconto"].Value.ToString().Replace("R$", "").Trim());
                Liquido += Convert.ToDouble(lin.Cells["Liquido"].Value.ToString().Replace("R$", "").Trim());
            }

            lblTotalItens.Text = "1 Item";

            if (itens != 1)
                lblTotalItens.Text = itens + " Itens";

            lblValorBruto.Text = Bruto.ToString("c");
            lblSomaGeral.Text = TotalQtd.ToString();
            lblTotalDesconto.Text = Desc.ToString("c");
            lblTotalLiquido.Text = Liquido.ToString("c");
        }

        private void CalcularItensVenda()
        {
            double Bruto = 0;
            double DescR = 0;
            double DescP = 0;
            double Liquido = 0;

            foreach (DataGridViewRow linha in dgProdutos.Rows)
            {
                Bruto = Convert.ToDouble(linha.Cells["Bruto"].Value);
                DescR = Convert.ToDouble(linha.Cells["DescRS"].Value);
                DescP = Convert.ToDouble(linha.Cells["DescPerc"].Value);

                if (DescP > 0)
                {
                    linha.Cells["TotalDescPerc"].Value = (Bruto * (DescP / 100)).ToString("c");
                    linha.Cells["TotalDesconto"].Value = (Bruto * (DescP / 100)).ToString("c");
                }
                else
                {
                    linha.Cells["TotalDescPerc"].Value = "R$ 0,00";
                    linha.Cells["TotalDesconto"].Value = DescR.ToString("c");
                }

                Liquido = Bruto - (Bruto * (DescP / 100)) - DescR;

                linha.Cells["Liquido"].Value = Liquido.ToString("c");
            }
        }

        private bool VerificaDuplicidade()
        {
            if (txtIdItem.Text != "")
                return false;

            foreach (DataGridViewRow linha in dgProdutos.Rows)
            {
                if (linha.Cells["Nome"].Value.ToString() == cbProduto.Text)
                {
                    Geral.Pergunta("Este Produto já está na lista, deseja adiciona-lo novamente?");
                    if (Geral.Resposta == true)
                        return false;
                    else
                        return true;
                }
            }


            return false;
        }

        private void CarregarItens()
        {
            string id = "0";

            if (txtIdVenda.Text != "")
                id = txtIdVenda.Text;

            string sql = "SELECT vi.VENDA_ITENS_ID, p.COD, p.NOME, vi.QTD, ";
            sql += "vi.VL_UNIT, (vi.QTD * vi.VL_UNIT) as BRUTO, ";
            sql += "vi.DESC_RS, vi.DESC_PERC, ";
            sql += " (vi.QTD * vi.VL_UNIT) * (vi.DESC_PERC / 100) AS TOTAL_PERC, ";
            sql += " vi.DESC_RS + ((vi.QTD * vi.VL_UNIT) * (vi.DESC_PERC / 100)) AS TOTAL_DESC, ";
            sql += " (vi.QTD * vi.VL_UNIT) -(vi.DESC_RS + ((vi.QTD * vi.VL_UNIT) * (vi.DESC_PERC / 100))) AS TOTAL_LIQUIDO, vi.PRODUTO_ID ";
            sql += "FROM VENDA_ITENS vi ";
            sql += "INNER join PRODUTO p ON p.PRODUTO_ID = vi.PRODUTO_ID ";
            sql += "WHERE vi.VENDA_ID = " + id;

            dgProdutos.DataSource = BD.Buscar(sql);

            if (dgProdutos.RowCount > 0)
            {
                BtExcluir.Enabled = true;
                BtAlterar.Enabled = true;
            }

            //CalcularItensVenda();
            CalculoRodape();
            CalcularParcelamento();

        }


        private void LimparItens()
        {
            txtIdItem.Text = "";
            cbProduto.Text = "";
            cbProduto.SelectedIndex = -1;
            CodProduto.Text = "";
            Estoque.Text = "";

            txtQtd.Text = "";
            ValorProduto.Text = "";
            txtDescRS.Text = "";
            txtDescPerc.Text = "";
            txtTotalDescPerc.Text = "";
            txtTotalDesconto.Text = "";
            txtValorBruto.Text = "";
            txtTotalLiquido.Text = "";

            cbProduto.Enabled = true;
            dgProdutos.Enabled = true;

            cbProduto.Focus();
        }

        private bool ValidarItens()
        {
            if (cbProduto.Text == "")
            {
                Geral.Erro("Informe o Produto!");
                return true;
            }

            if (cbProduto.SelectedIndex == -1)
            {
                Geral.Erro("Produto não Está Cadastrado!");
                return true;
            }

            if (txtQtd.Text == "")
            {
                Geral.Erro("Informe a Quantidade!");
                return true;
            }

            if (ValorProduto.Text == "")
            {
                Geral.Erro("Informe o Valor Unitário!");
                return true;
            }

            double Liquido = 0;

            if (txtTotalLiquido.Text != "")
                Liquido = Convert.ToDouble(txtTotalLiquido.Text.Replace("R$", "").Trim());

            if (Liquido <= 0)
            {
                Geral.Erro("Informações Inválidas! Verifique os campos Qtd, Valor e Desconto!");
                return true;
            }

            return false;
        }


        private bool ValidarCliente()
        {

            if (cbCliente.Text == "")
            {
                Geral.Erro("Informe um Cliente por Favor!");
                return true;
            }

            if (cbCliente.SelectedIndex == -1)
            {
                Geral.Erro("O Cliente Informado não está cadastrado!");
                return true;
            }

            return false;
        }

        private bool ValidarInfoGerais()
        {
            if (Geral.ValidaCampos(groupBox1, errorProvider1))
                return true;

            if (cbFinalidade.SelectedIndex == -1)
            {
                Geral.Erro("A Finalidade Não está cadastrada!");
                return true;
            }

            if (cbSituacao.SelectedIndex == -1)
            {
                Geral.Erro("A Situação não está cadastrada!");
                return true;
            }

            return false;
        }


        private void SalvarVenda()
        {
            string[] v = new string[7];

            v[0] = txtIdVenda.Text;
            v[1] = cbCliente.SelectedValue.ToString();
            v[2] = cbFinalidade.SelectedValue.ToString();
            v[3] = cbSituacao.SelectedValue.ToString();
            v[4] = txtNumero.Text;
            v[5] = BD.CvData(txtDataEmissao.Text);
            v[6] = BD.cvNum(lblTotalLiquido.Text);

            try
            {
                txtIdVenda.Text = BD.ExecutarProcedure("VENDA_SALVAR", v);
                cbCliente.Enabled = false;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNQ_VENDA_NUMERO"))
                {
                    Geral.Pergunta("Este número já foi salvo, será gerado um novo número para salvar a venda, clique no botão sim para prosseguir!");

                    if (Geral.Resposta)
                    {
                        GerarNumNota();
                        v[4] = txtNumero.Text;
                        txtIdVenda.Text = BD.ExecutarProcedure("VENDA_SALVAR", v);
                        cbCliente.Enabled = false;
                    }
                }
            }
        }

        private int SalvarItemVenda()
        {
            string[] v = new string[7];

            v[0] = txtIdItem.Text;
            v[1] = txtIdVenda.Text;
            v[2] = cbProduto.SelectedValue.ToString();
            v[3] = BD.cvNum(txtQtd.Text);
            v[4] = BD.cvNum(ValorProduto.Text);
            v[5] = BD.cvNum(txtDescRS.Text);
            v[6] = BD.cvNum(txtDescPerc.Text);

            try
            {
                BD.ExecutarProcedure("VENDA_ITENS_SALVAR", v);
                return 0;
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("ESTOQUE_PRODUTO"))
                    Geral.Erro("Operação Não Permitida!\r\n\r\nO Estoque Ficará Negativo, Isso não é Permitido!");
                else
                    MessageBox.Show(ex.Message, "ERRO!", MessageBoxButtons.OK);

                return 1;
            }

        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            Alteracao = 1;
        }

        private void txtDataEmissao_KeyPress(object sender, KeyPressEventArgs e)
        {
            Alteracao = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (VerificarStatus())
                return;

            cbCliente.Enabled = true;
            Alteracao = 1;
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if (VerificarStatus())
                return;

            BtAlterar.Enabled = false;
            BtExcluir.Enabled = false;
            cbProduto.Enabled = false;
            dgProdutos.Enabled = false;

            DataGridViewRow lin = dgProdutos.CurrentRow;

            txtIdItem.Text = lin.Cells["IDItens"].Value.ToString();
            cbProduto.Text = lin.Cells["Nome"].Value.ToString();
            Selecionarproduto();

            txtQtd.Text = lin.Cells["Qtd"].Value.ToString();
            ValorProduto.Text = Convert.ToDouble(lin.Cells["Qtd"].Value).ToString("c");
            txtDescRS.Text = Convert.ToDouble(lin.Cells["DescRS"].Value).ToString("c");
            txtDescPerc.Text = lin.Cells["DescPerc"].Value.ToString();

            CalcularItensVenda();

            Alteracao = 1;
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (VerificarStatus())
                return;

            if (dgProdutos.RowCount == 1)
            {
                Geral.Erro("Não será possível Excluir esse item, pois a venda ficará vazia. Caso necessário faça o cancelamento da venda!");
                return;
            }

            Geral.Pergunta("Deseja Realmente Exclui o Produto, " + dgProdutos.CurrentRow.Cells["Nome"].Value.ToString() + "?");

            if (Geral.Resposta == false)
                return;

            string sql = "DELETE FROM VENDA_ITENS WHERE VENDA_ITENS_ID = " + dgProdutos.CurrentRow.Cells["IDItens"].Value.ToString();

            BD.ExecutarSQL(sql);

            CarregarItens();

            Alteracao = 1;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (VerificarStatus())
                return;

            try
            {
                SalvarVenda();
                Geral.OK("Venda Salva com Sucesso!");
                Alteracao = 0;
                cbCliente.Enabled = false;
            }
            catch (Exception ex)
            {
                Geral.Erro(ex.Message);
            }
        }

        private void frmCadVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Alteracao == 1 && txtIdVenda.Text == "")
            {
                Geral.Pergunta("Ao saír as informações já digitadas serão perdidas, desejam realmente sair?");

                if (!Geral.Resposta)
                    e.Cancel = true;
            }
            else if (Alteracao == 1 && txtIdVenda.Text != "")
            {
                Geral.Erro("Salve a Venda antes de Sair Por Favor");
                e.Cancel = true;
            }
        }

        private void txtDescRS_Leave(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void txtDescPerc_Leave(object sender, EventArgs e)
        {
            CalculoVenda();
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            if (VerificarStatus())
                return;

            LimparItens();
        }

        private void BtNovaCompra_Click(object sender, EventArgs e)
        {
            if (Alteracao == 1)
            {
                Geral.Erro("Salve a Venda Atual por Favor!");
                return;
            }

            txtIdVenda.Text = "";
            txtIdItem.Text = "";
            txtDataEmissao.Text = DateTime.Now.ToShortDateString();

            cbFinalidade.SelectedIndex = 0;
            cbSituacao.SelectedIndex = 0;

            cbCliente.SelectedIndex = -1;
            cbCliente.Enabled = true;

            txtDocumento.Text = "";
            txtCidade.Text = "";

            cbProduto.SelectedIndex = -1;
            txtCod.Text = "";
            Estoque.Text = "";

            txtQtd.Text = "";
            ValorProduto.Text = "";
            txtDescRS.Text = "";
            txtDescPerc.Text = "";

            CalculoVenda();

            BtAlterar.Enabled = false;
            BtExcluir.Enabled = false;
            BtImprimir.Enabled = false;

            dgProdutos.Enabled = true;

            txtValorEntrada.Text = "";
            txtQtdParcela.Text = "";
            txtPriVencimento.Text = "";
            txtValorParcela.Text = "";

            rbDinheiro.Checked = true;

            VendaFinalizada();

            CarregarItens();

            GerarNumNota();

            tabControl1.SelectedTab = tabPage1;

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (VerificarStatus())
                return;

            if (txtIdVenda.Text == "")
            {
                Geral.Erro("Venda ainda não foi salva!");
                return;
            }

            if (txtJustificativa.Text.Trim() == "")
            {
                Geral.Erro("Informe o motivo do cancelamento!");
                txtJustificativa.Focus();
                return;
            }

            Geral.Pergunta("Deseja Realmente Cancelar a Venda Atual?");

            if (!Geral.Resposta)
                return;

            if (BD.AcessoLiberado("Cancelar Venda ID:" + txtIdVenda.Text) == false)
                return;

            try
            {
                string sql = "UPDATE VENDA SET SITUACAO_ID = 2 WHERE VENDA_ID = " + txtIdVenda.Text;
                BD.ExecutarSQL(sql);

                sql = "INSERT INTO CANCELAMENTO (CANCELAMENTO_ID, TIPO, TIPO_ID, JUSTIFICATIVA) ";
                sql += " VALUES(NULL, 'V', " + txtIdVenda.Text + ", '" + txtJustificativa.Text + "')";

                BD.ExecutarSQL(sql);

                Geral.OK("Venda Cancelada Com Sucesso!");

                Alteracao = 0;

                cbSituacao.SelectedIndex = 1;

                foreach (DataGridViewRow item in dgProdutos.Rows)
                {
                    sql = "UPDATE PRODUTO SET ESTOQUE_ATUAL = ESTOQUE_ATUAL + "  + BD.cvNum(item.Cells["Qtd"].Value.ToString()) + " WHERE PRODUTO_ID = " + item.Cells["IdProd"].Value.ToString() ;
                    BD.ExecutarSQL(sql);
                }
            }
            catch (Exception ex)
            {
                Geral.Erro(ex.Message);
            }
        }

        private bool VerificarStatus()
        {
            if (cbSituacao.SelectedIndex == 1)
            {
                Geral.Erro("Venda Cancelada, nenhuma ação é permitida!");
                return true;
            }

            if (cbSituacao.SelectedIndex == 2)
            {
                Geral.Erro("Venda Finalizada, nenhuma ação é permitida!");
                return true;
            }

            return false;
        }

        private void BtImprimir_Click(object sender, EventArgs e)
        {
ReportParameterCollection p = new ReportParameterCollection();
p.Add(new ReportParameter("IdVenda", txtIdVenda.Text));
p.Add(new ReportParameter("emissao", txtDataEmissao.Text));
p.Add(new ReportParameter("NomeCliente", cbCliente.Text));

string sql = "SELECT e.LOGRADOURO, b.BAIRRO, c.CIDADE, e.ESTADO, ";
sql += "(SELECT a.VALOR FROM CONTATO a ";
sql += "WHERE a.PESSOA_ID = e.PESSOA_ID AND a.PRINCIPAL = 'S') AS CONTATO ";
sql += "FROM ENDERECO e ";
sql += "INNER JOIN BAIRRO b ON b.BAIRRO_ID = e.BAIRRO_ID ";
sql += "INNER JOIN CIDADE c ON c.CIDADE_ID = e.CIDADE_ID ";
sql += "WHERE e.PESSOA_ID = " + cbCliente.SelectedValue;

DataTable dt = BD.Buscar(sql);

string Endereco = "";

if (dt.Rows[0]["LOGRADOURO"].ToString() != "")
    Endereco = dt.Rows[0]["LOGRADOURO"].ToString();

if (dt.Rows[0]["BAIRRO"].ToString() != "")
    Endereco += ", " + dt.Rows[0]["BAIRRO"].ToString();

if (dt.Rows[0]["CIDADE"].ToString() != "")
    Endereco += ", " + dt.Rows[0]["CIDADE"].ToString();

if (dt.Rows[0]["ESTADO"].ToString() != "")
    Endereco += " - " + dt.Rows[0]["ESTADO"].ToString();

p.Add(new ReportParameter("Endereco", Endereco));

p.Add(new ReportParameter("Contato", dt.Rows[0]["CONTATO"].ToString()));

p.Add(new ReportParameter("Desconto", lblTotalDesconto.Text));
p.Add(new ReportParameter("ValorPagar", lblTotalLiquido.Text));

reportViewer1.LocalReport.SetParameters(p);

DS.RomaneioDataTable dtRom = new DS.RomaneioDataTable();

int Total = 0;

            foreach (DataGridViewRow Lin in dgProdutos.Rows)
            {
                DataRow linha = dtRom.NewRow();

                linha["Qtd"] = Lin.Cells["Qtd"].Value.ToString();
                linha["Produto"] = Lin.Cells["Nome"].Value.ToString();
                linha["Valor"] = Lin.Cells["Valor"].Value.ToString();
                linha["Total"] = Lin.Cells["Bruto"].Value.ToString();

                dtRom.Rows.Add(linha);

                if (Total == 7)
                    Total = 0;

                Total++;

            }

            for (int i = Total; i < 7; i++)
            {
                DataRow linha = dtRom.NewRow();

                linha["Qtd"] = "";
                linha["Produto"] = "";
                linha["Valor"] = "";
                linha["Total"] = "";

                dtRom.Rows.Add(linha);
            }

            ReportDataSource rds = new ReportDataSource("DataSet1", dtRom as DataTable);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.Refresh();

            Geral.ImprimirPDF(reportViewer1, "Venda");
        }

        private void txtValorEntrada_TextChanged(object sender, EventArgs e)
        {
            CalcularParcelamento();
        }

        private void txtQtdParcela_TextChanged(object sender, EventArgs e)
        {
            CalcularParcelamento();
        }

        private void BtFinalizarCreidiario_Click(object sender, EventArgs e)
        {
            if (txtIdVenda.Text != "" && Alteracao == 1)
            {
                Geral.Erro("Salve a Venda Por Favor!");
                return;
            }

            if (VerificarStatus())
                return;

            if (txtQtdParcela.Text.Trim() == "")
            {
                Geral.Erro("Informe a Quantidade de Parcelas");
                txtQtdParcela.Focus();
                return;
            }

            if (txtPriVencimento.Text.Trim() == "")
            {
                Geral.Erro("Informe o campo Primeiro Vencimento!");
                txtPriVencimento.Focus();
                return;
            }

            if (Convert.ToDateTime(txtPriVencimento.Text).Date < DateTime.Now.Date)
            {
                Geral.Pergunta("Data de vencimento já está vencida, deseja continuar mesmo assim?");

                if (!Geral.Resposta)
                    return;
            }

            Geral.Pergunta("Venda Será Finalizada e não poderá ser editada novamente, deseja continuar?");

            if (!Geral.Resposta)
                return;

            //Salvar Entrada Quando Tiver
            double Entrada = 0;
            if (txtValorEntrada.Text.Trim() != "")
                Entrada = Convert.ToDouble(txtValorEntrada.Text.Replace("R", "").Replace("$", "").Trim());

            string[] v = new string[9];            

            if (Entrada > 0)
            {
                string TipoEntrada = "";

                if (rbDinheiro.Checked)
                    TipoEntrada = "DINHEIRO";

                if (rbDebito.Checked)
                    TipoEntrada = "DÉBITO";

                if (rbCredito.Checked && txtCreditoVezes.Text == "")
                {
                    Geral.Erro("Informe Em Quantas Vezes Vai Pagar no Cre´dito!");
                    txtCreditoVezes.Focus();
                    return;
                }

                if (rbCredito.Checked)
                    TipoEntrada = "CRÉDITO";

                if (rbCheque.Checked)
                {
                    if(cbChequeEntrada.Text == "")
                    {
                        Geral.Erro("Informe o Titular do Cheque!");
                        return;
                    }

                    if(txtDataChequeEntrada.Text == "")
                    {
                        Geral.Erro("Informa a Data do Cheque de Entrada!");
                        return;
                    }

                    if(txtNumChequeEntrada.Text == "")
                    {
                        Geral.Erro("Informe o Numero do Cheque de Entrada!");
                        return;
                    }

                    TipoEntrada = "CHEQUE";
                }

                v[0] = "C";

                if (rbCredito.Checked)
                    v[1] = "VENDA - ENTRADA " + txtCreditoVezes.Text + "x";
                else
                    v[1] = "VENDA - ENTRADA";

                v[2] = txtIdVenda.Text;
                v[3] = "0";
                v[4] = BD.cvNum(txtValorEntrada.Text);
                v[5] = BD.CvData(DateTime.Now.ToShortDateString());
                v[6] = BD.cvNum(txtValorEntrada.Text);
                v[7] = BD.CvData(DateTime.Now.ToShortDateString());
                v[8] = TipoEntrada;

                LancarParcela(v);

                if (rbCheque.Checked)
                    SalvarChequeEntrada();
            }

            int t = Convert.ToInt32(txtQtdParcela.Text);
            double TotalParcelar = Convert.ToDouble(lblTotalParcelar.Text.Replace("R$", "").Trim());

            DateTime Vencimento = Convert.ToDateTime(txtPriVencimento.Text);

            for (int i = 1; i <= t; i++)
            {
                v[0] = "C";
                v[1] = "VENDA - PARCELA N " + i;
                v[2] = txtIdVenda.Text;
                v[3] = i.ToString();

                if (i == t)
                    v[4] = BD.cvNum(TotalParcelar.ToString());
                else
                    v[4] = BD.cvNum(txtValorParcela.Text);

                v[5] = BD.CvData(Vencimento.ToShortDateString());
                v[6] = BD.cvNum(txtValorParcela.Text);
                v[7] = "null";
                v[8] = "";

                TotalParcelar -= Convert.ToDouble(txtValorParcela.Text.Replace("R", "").Replace("$", "").Trim());

                LancarParcela(v);

                Vencimento = Vencimento.AddMonths(1);
            }

            FinalizarVenda();

        }

        private void FinalizarVenda()
        {
            double Entrada = 0;
            if (txtValorEntrada.Text.Trim() != "")
                Entrada = Convert.ToDouble(txtValorEntrada.Text.Replace("R", "").Replace("$", "").Trim());

            string sql = "UPDATE VENDA SET SITUACAO_ID = 3, TIPO_PAGAMENTO = 'Crediário', VALOR_ENTRADA = " + BD.cvNum(Entrada.ToString()) + ", PARCELAS = " + txtQtdParcela.Text + ", VALOR_PARCELA = " + BD.cvNum(txtValorParcela.Text) + ", PRI_VECIMENTO = '" + BD.CvData(txtPriVencimento.Text) + "' WHERE VENDA_ID = " + txtIdVenda.Text;
            int retorno = BD.ExecutarSQL(sql);

            if (retorno == 1)
            {
                cbSituacao.SelectedIndex = 2;
                VendaFinalizada();
                Geral.OK("Venda Finalizada com Sucesso!");
            }
        }

        private void LancarParcela(string[] v)
        {
            string[] c = new string[9];

            c[0] = "TIPO";
            c[1] = "REFERENCIA";
            c[2] = "REFERENCIA_ID";
            c[3] = "NUM_PARCELA";
            c[4] = "VALOR";
            c[5] = "VENCIMENTO";
            c[6] = "VALOR_PAGO";
            c[7] = "DATA_PAGOU";
            c[8] = "TIPO_PGT";

            BD.Salvar("FINANCEIRO", c, v);

            ListarPagamentos();
        }

        private void BtImprimirCarnes_Click(object sender, EventArgs e)
        {

        }

        private void BtImprimirCarne_Click(object sender, EventArgs e)
        {
            ImprimirCarne();
        }

        private void ImprimirCarne()
        {
            string sql = "SELECT f.NUM_PARCELA, f.VENCIMENTO, ";
            sql += "f.VALOR, f.FINANCEIRO_ID ";
            sql += "FROM FINANCEIRO f ";
            sql += "INNER JOIN VENDA v ON v.VENDA_ID = f.REFERENCIA_ID ";
            sql += "WHERE f.TIPO = 'C' AND f.REFERENCIA_ID = " + txtIdVenda.Text;

            DataTable dt = BD.Buscar(sql);

            reportViewer1.LocalReport.ReportEmbeddedResource = "Setup.Relatorios.Parcelamento.rdlc";

            ReportParameterCollection p = new ReportParameterCollection();
            p.Add(new ReportParameter("IdVenda", txtIdVenda.Text));
            p.Add(new ReportParameter("cliente", cbCliente.Text));
            p.Add(new ReportParameter("cpf", txtDocumento.Text));
            p.Add(new ReportParameter("QtdParcelas", txtQtdParcela.Text));

            reportViewer1.LocalReport.SetParameters(p);

            ReportDataSource rds = new ReportDataSource("DataSet1", dt as DataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);

            Geral.ImprimirPDF(reportViewer1, "Parcelamento");

        }

        private void txtDinheiro_TextChanged(object sender, EventArgs e)
        {
            double Falta = Convert.ToDouble(lblFaltaReceber.Text.Replace("R$", "").Trim());
            double dinheiro = 0;

            if (txtDinheiro.Text.Trim() != "")
                dinheiro = Convert.ToDouble(txtDinheiro.Text.Replace("R", "").Replace("$", "").Trim());

            if (dinheiro < Falta)
                lblTroco.Text = "R$ 0,00";
            else
                lblTroco.Text = (dinheiro - Falta).ToString("c");
        }

        private void BtReceberDinheiro_Click(object sender, EventArgs e)
        {
            if(Alteracao == 1 && txtIdVenda.Text != "")
            {
                Geral.Erro("Por Favor Salve a Venda!");
                return;
            }

            if (txtDinheiro.Text.Trim() == "")
            {
                Geral.Erro("Digite o valor recebido em dinheiro");
                return;
            }

            Geral.Pergunta("Deseja Realmente lançar esse Recebimento?");

            if (!Geral.Resposta)
                return;

            double Dinheiro = Convert.ToDouble(txtDinheiro.Text.Replace("R", "").Replace("$", "").Trim());
            double Troco = Convert.ToDouble(lblTroco.Text.Replace("R$", "").Trim());

            string[] v = new string[9];

            v[0] = "C";
            v[1] = "VENDA - DINHEIRO";
            v[2] = txtIdVenda.Text;
            v[3] = "0";
            v[4] = BD.cvNum((Dinheiro - Troco).ToString());
            v[5] = BD.CvData(DateTime.Now.ToShortDateString());
            v[6] = BD.cvNum((Dinheiro - Troco).ToString());
            v[7] = BD.CvData(DateTime.Now.ToShortDateString());
            v[8] = "DINHEIRO";

            LancarParcela(v);

            txtDinheiro.Text = "";

            FinalizaVendaAvulsa();
        }

        private void FinalizaVendaAvulsa()
        {
            if(cbSituacao.SelectedIndex == 0)
            {
                string sql = "UPDATE VENDA SET SITUACAO_ID = 3, TIPO_PAGAMENTO = 'Avulsa' " +
                    "WHERE VENDA_ID = " + txtIdVenda.Text;

                int Retorno = BD.ExecutarSQL(sql);

                if(Retorno==1)
                {
                    cbSituacao.SelectedIndex = 2;
                    VendaFinalizada();
                }
            }
        }

        private void ListarPagamentos()
        {
            string id = "0";

            if (txtIdVenda.Text != "")
                id = txtIdVenda.Text;

            lblReceberTotal.Text = lblTotalLiquido.Text;

            string sql = "SELECT f.FINANCEIRO_ID, REPLACE(f.REFERENCIA, 'VENDA - ', '') AS TIPO, ";
            sql += "f.DATA_PAGOU, f.VALOR_PAGO ";
            sql += "FROM FINANCEIRO f ";
            sql += "WHERE f.REFERENCIA_ID = " + id;

            dgPagamentos.DataSource = BD.Buscar(sql);

            double ValorPago = 0;

            foreach (DataGridViewRow Lin in dgPagamentos.Rows)
            {
                ValorPago += Convert.ToDouble(Lin.Cells["VALOR_PAGOU"].Value);
            }

            lblTotalRecebido.Text = ValorPago.ToString("c");

            double TotalVenda = Convert.ToDouble(lblReceberTotal.Text.Replace("R$", "").Trim());

            lblFaltaReceber.Text = (TotalVenda - ValorPago).ToString("c");

            if (lblFaltaReceber.Text == "R$ 0,00")
                tabControl2.Enabled = false;
            else
                tabControl2.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
                ListarPagamentos();
        }

        private void BtCartaoCredito_Click(object sender, EventArgs e)
        {
            if (Alteracao == 1 && txtIdVenda.Text != "")
            {
                Geral.Erro("Por Favor Salve a Venda!");
                return;
            }

            if (txtCredito.Text.Trim()=="")
            {
                Geral.Erro("Informe o valor pago!");
                return;
            }

            if(txtDividirCredito.Text.Trim()=="")
            {
                Geral.Erro("Informe a quantidade parcelas!");
                return;
            }

            double FaltaReceber = Convert.ToDouble(lblFaltaReceber.Text.Replace("R$", "").Trim());
            double Valor = Convert.ToDouble(txtCredito.Text.Replace("R", "").Replace("$", "").Trim());

            if(Valor > FaltaReceber)
            {
                Geral.Erro("Valor superior ao que falta pagar!");
                return;
            }

            Geral.Pergunta("Deseja Realmente lançar esse pagamento?");

            if (!Geral.Resposta)
                return;

            string[] v = new string[9];

            v[0] = "C";
            v[1] = "VENDA - " + txtDividirCredito.Text + "X CREDITO";
            v[2] = txtIdVenda.Text;
            v[3] = "0";
            v[4] = BD.cvNum(Valor.ToString());
            v[5] = BD.CvData(DateTime.Now.ToShortDateString());
            v[6] = BD.cvNum(Valor.ToString());
            v[7] = BD.CvData(DateTime.Now.ToShortDateString());
            v[8] = "CRÉDITO";

            LancarParcela(v);

            txtCredito.Text = "";
            txtDividirCredito.Text = "";

            FinalizaVendaAvulsa();
        }

        private void BtDebito_Click(object sender, EventArgs e)
        {
            if (Alteracao == 1 && txtIdVenda.Text != "")
            {
                Geral.Erro("Por Favor Salve a Venda!");
                return;
            }

            if (txtDebito.Text.Trim()=="")
            {
                Geral.Erro("Informe o valor a receber!");
                return;
            }

            double FaltaReceber = Convert.ToDouble(lblFaltaReceber.Text.Replace("R$", "").Trim());
            double Valor = Convert.ToDouble(txtDebito.Text.Replace("R", "").Replace("$", "").Trim());

            if(Valor > FaltaReceber)
            {
                Geral.Erro("Valor recebido é superior ao que falta receber!");
                return;
            }

            Geral.Pergunta("Deseja Realmente lançar esse pagamento?");

            if (Geral.Resposta == false)
                return;

            string[] v = new string[9];

            v[0] = "C";
            v[1] = "VENDA - DEBITO";
            v[2] = txtIdVenda.Text;
            v[3] = "0";
            v[4] = BD.cvNum(Valor.ToString());
            v[5] = BD.CvData(DateTime.Now.ToShortDateString());
            v[6] = BD.cvNum(Valor.ToString());
            v[7] = BD.CvData(DateTime.Now.ToShortDateString());
            v[8] = "DÉBITO";

            LancarParcela(v);

            txtDebito.Text = "";

            FinalizaVendaAvulsa();

        }

        private void BtCheque_Click(object sender, EventArgs e)
        {
            if (Alteracao == 1 && txtIdVenda.Text != "")
            {
                Geral.Erro("Por Favor Salve a Venda!");
                return;
            }

            if (Geral.ValidaCampos(tabPage8, errorProvider1))
                return;

            double FaltaReceber = Convert.ToDouble(lblFaltaReceber.Text.Replace("R$", "").Trim());
            double Valor = Convert.ToDouble(txtValorCheque.Text.Replace("R", "").Replace("$", "").Trim());

            if (Valor > FaltaReceber)
            {
                Geral.Erro("Valor recebido é superior ao que falta receber!");
                return;
            }

            Geral.Pergunta("Deseja Realmente lançar esse pagamento?");

            if (Geral.Resposta == false)
                return;

            string[] v = new string[9];

            v[0] = "C";
            v[1] = "VENDA - CHEQUE";
            v[2] = txtIdVenda.Text;
            v[3] = "0";
            v[4] = BD.cvNum(Valor.ToString());
            v[5] = BD.CvData(DateTime.Now.ToShortDateString());
            v[6] = BD.cvNum(Valor.ToString());
            v[7] = BD.CvData(DateTime.Now.ToShortDateString());
            v[8] = "CHEQUE";

            LancarParcela(v);

            SalvarCheque();

            cbTitular.Text = "";
            txtNumeroCheque.Text = "";
            txtDataCheque.Text = "";
            txtValorCheque.Text = "";

            FinalizaVendaAvulsa();
            CarregarTitularCheque();
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

        private void SalvarChequeEntrada()
        {
            string[] c = new string[5];
            string[] v = new string[5];

            c[0] = "TITULAR";
            v[0] = cbChequeEntrada.Text;

            c[1] = "NUMERO";
            v[1] = txtNumChequeEntrada.Text;

            c[2] = "DATA";
            v[2] = BD.CvData(txtDataChequeEntrada.Text);

            c[3] = "VALOR";
            v[3] = BD.cvNum(txtValorEntrada.Text);

            c[4] = "VENDA_ID";
            v[4] = txtIdVenda.Text;

            BD.Salvar("CHEQUE", c, v);
        }

        private void rbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDinheiro.Checked)
                tabEntrada.Visible = false;
        }

        private void rbDebito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDebito.Checked)
                tabEntrada.Visible = false;
        }

        private void rbCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCredito.Checked)
            {
                RemoveGuias();
                tabEntrada.TabPages.Add(pageCredito);
                tabEntrada.Visible = true;

            }
        }

        private void rbCheque_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCheque.Checked)
            {
                RemoveGuias();
                tabEntrada.TabPages.Add(pageCheque);
                tabEntrada.Visible = true;
            }
        }
    }
}
