using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;




namespace Setup.Formularios
{
    public partial class frmCadCompra : Form
    {
        int Fechar;
        int Alteracao;

        public frmCadCompra()
        {
            Fechar = 0;
            Alteracao = 0;
            InitializeComponent();
        }

        private bool EstaCancelada()
        {
            if (cbSituacao.SelectedIndex == 1)
            {
                Geral.Erro("Compra cancelada, não é permitido a sua edição!");
                return true;
            }
            return
                false;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (EstaCancelada())
                return;

            if (ValidarInformacoesGerais())
                return;

            if (ValidarFornecedor())
                return;

            if (ValidarItem())
                return;

            if (VerificaDuplicidade())
            {
                Geral.Pergunta("Este produto já foi adicionado, deseja adiciona-lo novamente?");

                if (Geral.Resposta == false)
                    return;
            }

            if (txtIdCompra.Text == "")
                SalvarCompra();           

            string[] vi = new string[7];
            vi[0] = txtIdItem.Text;
            vi[1] = txtIdCompra.Text;
            vi[2] = cbProduto.SelectedValue.ToString();
            vi[3] = BD.cvNum(txtQtd.Text);
            vi[4] = BD.cvNum(ValorProduto.Text);
            vi[5] = BD.cvNum(txtDescRS.Text);
            vi[6] = BD.cvNum(txtDescPerc.Text);

            BD.ExecutarProcedure("COMPRA_ITENS_SALVAR", vi);

            cbFornecedor.Enabled = false;

            LimparItens();
            CarregarItens();
            Alteracao = 1;
        }

        private void SalvarCompra()
        {
            string[] v = new string[7];

            v[0] = txtIdCompra.Text;
            v[1] = cbFornecedor.SelectedValue.ToString();
            v[2] = cbFinalidade.SelectedValue.ToString();
            v[3] = cbSituacao.SelectedValue.ToString();
            v[4] = txtNumero.Text;
            v[5] = BD.CvData(txtData.Text);
            v[6] = BD.cvNum(lblTotalLiquido.Text);

            txtIdCompra.Text = BD.ExecutarProcedure("COMPRA_SALVAR", v);
        }


        private bool VerificaDuplicidade()
        {
            if (txtIdItem.Text != "")
                return false;

            foreach (DataGridViewRow linha in dgProdutos.Rows)
            {
                if (linha.Cells["Nome"].Value.ToString() == cbProduto.Text)
                    return true;
            }

            return false;
        }

        private void CarregarItens()
        {
            string id = "0";

            if (txtIdCompra.Text != "")
                id = txtIdCompra.Text;

            string sql = "SELECT ci.COMPRA_ITENS_ID, p.COD, p.NOME, ci.QTD, ci.VL_UNIT, ";
            sql += " ci.QTD* ci.VL_UNIT AS BRUTO, ci.DESC_RS, ci.DESC_PERC ";
            sql += ", (ci.QTD * ci.VL_UNIT) * (ci.DESC_PERC / 100) AS TOTAL_PERC,";
            sql += " ci.DESC_RS + ((ci.QTD * ci.VL_UNIT) * (ci.DESC_PERC / 100)) AS TOTAL_DESC,";
            sql += " (ci.QTD * ci.VL_UNIT) -(ci.DESC_RS + ((ci.QTD * ci.VL_UNIT) * (ci.DESC_PERC / 100))) AS TOTAL_LIQUIDO, ci.PRODUTO_ID ";
            sql += " FROM COMPRA_ITENS ci";
            sql += " INNER JOIN PRODUTO p ON p.PRODUTO_ID = ci.PRODUTO_ID";
            sql += " WHERE ci.COMPRA_ID = " + id;

            dgProdutos.DataSource = BD.Buscar(sql);

            //CalcularDescontoItem();
            SomarRodape();
        }

        private void SomarRodape()
        {
            double itens = 0;
            double TotalQtd = 0;
            double Bruto = 0;
            double Desc = 0;
            double Liquido = 0;

            foreach (DataGridViewRow Lin in dgProdutos.Rows)
            {
                itens++;

                TotalQtd += Convert.ToDouble(Lin.Cells["Qtd"].Value);

                Bruto += Convert.ToDouble(Lin.Cells["Bruto"].Value.ToString().Replace("R$", "").Trim());
                Desc += Convert.ToDouble(Lin.Cells["TotalDesconto"].Value.ToString().Replace("R$", "").Trim());
                Liquido += Convert.ToDouble(Lin.Cells["Liquido"].Value.ToString().Replace("R$", "").Trim());
            }

            lblTotalItens.Text = "1 Item";

            if (itens != 1)
                lblTotalItens.Text = itens.ToString() + " Itens";

            lblSomaGeral.Text = TotalQtd.ToString();
            lblValorBruto.Text = Bruto.ToString("c");
            lblTotalDesconto.Text = Desc.ToString("c");
            lblTotalLiquido.Text = Liquido.ToString("c");
        }


        private void CalcularDescontoItem()
        {
            double Bruto = 0;
            double DescR = 0;
            double DescP = 0;
            double Liquido = 0;

            foreach (DataGridViewRow Lin in dgProdutos.Rows)
            {
                Bruto = Convert.ToDouble(Lin.Cells["BRUTO"].Value);
                DescR = Convert.ToDouble(Lin.Cells["DescRS"].Value);
                DescP = Convert.ToDouble(Lin.Cells["DescPerc"].Value);

                if (DescP > 0)
                {
                    Lin.Cells["TotalDescPerc"].Value = (Bruto * (DescP / 100)).ToString("c");
                    Lin.Cells["TotalDesconto"].Value = (Bruto * (DescP / 100)).ToString("c");
                }
                else
                {
                    Lin.Cells["TotalDesconto"].Value = DescR.ToString("c");
                    Lin.Cells["TotalDescPerc"].Value = "R$ 0,00";
                }

                Liquido = Bruto - (Bruto * (DescP / 100)) - DescR;

                Lin.Cells["Liquido"].Value = Liquido.ToString("c");
            }
        }

        private void LimparItens()
        {
            txtIdItem.Text = "";
            cbProduto.Text = "";
            cbProduto.SelectedIndex = -1;
            txtCod.Text = "";
            Estoque.Text = "";
            txtQtd.Text = "";
            ValorProduto.Text = "";
            txtValorBruto.Text = "";
            txtDescRS.Text = "";
            txtDescPerc.Text = "";
            txtTotalDescPerc.Text = "";
            txtTotalDesconto.Text = "";
            txtTotalLiquido.Text = "";

            BtAlterar.Enabled = true;
            BtExcluir.Enabled = true;
            dgProdutos.Enabled = true;
            cbProduto.Enabled = true;

            cbProduto.Focus();
        }

        private bool ValidarItem()
        {
            if (Geral.ValidaCampos(groupBox3, errorProvider1))
                return true;

            if (cbProduto.SelectedIndex == -1)
            {
                Geral.Erro("O Produto informado não está cadastrado!");
                return true;
            }

            if (BD.cvNum(txtQtd.Text).Replace(".00", "") == "0")
            {
                Geral.Erro("Quantidade do Item não pode ser zero!");
                txtQtd.Focus();
                return true;
            }

            if (BD.cvNum(ValorProduto.Text).Replace(".00", "") == "0")
            {
                Geral.Erro("Valor do Item não pode ser zero!");
                ValorProduto.Focus();
                return true;
            }

            string Liq = BD.cvNum(txtTotalLiquido.Text).Replace(".00", "");

            if (Liq == "0" || Liq.Contains("-"))
            {
                Geral.Erro("Valor Liquido do Item não pode ser igual ou menor que zero!");
                return true;
            }

            return false;
        }

        private bool ValidarFornecedor()
        {
            if (cbFornecedor.Text == "")
            {
                Geral.Erro("Informe o Fornecedor da Compra!");
                return true;
            }

            if (cbFornecedor.SelectedIndex == -1)
            {
                Geral.Erro("O Fornecedor informado mão está cadastrado!");
                return true;
            }


            return false;
        }

        private bool ValidarInformacoesGerais()
        {
            //Validar Informações Gerais da Nota
            if (Geral.ValidaCampos(panelGerais, errorProvider1))
                return true;

            //Validar Finalidade e Situação não Cadastradas
            if (cbFinalidade.SelectedIndex == -1)
            {
                Geral.Erro("A Finalidade informada não está cadastrada!\r\nUse a tecla INSERT para um novo cadastro!");
                return true;
            }

            if (cbSituacao.SelectedIndex == -1)
            {
                Geral.Erro("A Situação informada não está cadastrada!\r\nUse a tecla INSERT para um novo cadastro!");
                return true;
            }

            return false;
        }

        private void cbFinalidade_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Insert)
            {
                frmFinalidade frm = new frmFinalidade();
                frm.ShowDialog();
                CarregarFinalidade();
                e.SuppressKeyPress = true;
            }
        }

        private void cbSituacao_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Insert)
            {
                frmSituacao frm = new frmSituacao();
                frm.ShowDialog();
                CarregarSituacao();
                e.SuppressKeyPress = true;
            }
        }

        private void frmCadCompra_Load(object sender, EventArgs e)
        {
            Location = new Point(315, 87);
            CarregarFinalidade();
            CarregarSituacao();
            CarregarProdutos();
            CarregarFornecedores();

            if (txtIdCompra.Text != "")
                PegarCompra();
        }


        private void PegarCompra()
        {
            cbFinalidade.SelectedIndex = 0;

            string sql = "SELECT a.SITUACAO_ID, a.DATA, a.NUM_NOTA, a.PESSOA_ID";
            sql += " FROM COMPRA a";
            sql += " WHERE a.COMPRA_ID = " + txtIdCompra.Text;

            DataTable dt = BD.Buscar(sql);

            cbSituacao.SelectedValue = dt.Rows[0]["SITUACAO_ID"];
            txtData.Text = Convert.ToDateTime(dt.Rows[0]["DATA"]).ToShortDateString();
            txtNumero.Text = dt.Rows[0]["NUM_NOTA"].ToString();

            cbFornecedor.SelectedValue = dt.Rows[0]["PESSOA_ID"];

            CarregarItens();
        }

        private void CarregarFornecedores()
        {
            cbFornecedor.DataSource = BD.Buscar("SELECT a.PESSOA_ID, a.NOME FROM PESSOA a ORDER BY a.NOME");
            cbFornecedor.SelectedIndex = -1;
        }

        private void CarregarProdutos()
        {
            string sql = "SELECT a.PRODUTO_ID, a.NOME FROM PRODUTO a ORDER BY a.NOME";
            cbProduto.DataSource = BD.Buscar(sql);
            cbProduto.SelectedIndex = -1;

        }

        private void CarregarFinalidade()
        {
            string sql = "SELECT * FROM FINALIDADE a ORDER BY a.FINALIDADE_ID";
            cbFinalidade.DataSource = BD.Buscar(sql);
            cbFinalidade.SelectedIndex = 0;
        }

        private void CarregarSituacao()
        {
            string sql = "SELECT * FROM SITUACAO a ORDER BY a.SITUACAO_ID";
            cbSituacao.DataSource = BD.Buscar(sql);
            cbSituacao.SelectedIndex = 0;
        }

        private void cbFornecedor_Leave(object sender, EventArgs e)
        {
            SelecionarFornecedor();
        }

        private void SelecionarFornecedor()
        {
            cbFornecedor.SelectedIndex = cbFornecedor.FindStringExact(cbFornecedor.Text);

            DataTable dt;
            string sql;

            if(cbFornecedor.SelectedIndex == -1 && cbFornecedor.Text.Trim() != "")
            {
                sql = "SELECT NOME FROM PESSOA WHERE CODIGO = '" + cbFornecedor.Text + "'";
                dt = BD.Buscar(sql);

                if (dt.Rows.Count > 0)
                {
                    cbFornecedor.Text = dt.Rows[0]["NOME"].ToString();
                    cbFornecedor.SelectedIndex = cbFornecedor.FindStringExact(cbFornecedor.Text);
                }
                else
                    Geral.Erro("Código não localizado!");
            }            

            if (cbFornecedor.SelectedIndex == -1)
            {
                txtCod.Text = "";
                txtDocumento.Text = "";
                txtCidade.Text = "";
                //Geral.Erro("Fornecedor não cadastrado!\r\n\r\nPressione a tecla INSERT dentro do controle para cadastrar um novo fornecedor!");
            }
            else
            {
                sql = "SELECT a.CODIGO, a.CPF, a.CNPJ, c.CIDADE FROM PESSOA a ";
                sql += " INNER JOIN ENDERECO e ON e.PESSOA_ID = a.PESSOA_ID ";
                sql += " INNER JOIN CIDADE c ON c.CIDADE_ID = e.CIDADE_ID ";
                sql += " WHERE a.PESSOA_ID = " + cbFornecedor.SelectedValue;
                sql += " ORDER BY a.NOME";

                dt = BD.Buscar(sql);

                txtCod.Text = dt.Rows[0]["CODIGO"].ToString();
                txtDocumento.Text = dt.Rows[0]["CPF"].ToString() + dt.Rows[0]["CNPJ"].ToString();
                txtCidade.Text = dt.Rows[0]["CIDADE"].ToString();
            }

        }

        private void cbFornecedor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Insert)
            {
                frmCadPessoa frm = new frmCadPessoa();
                frm.ShowDialog();
                e.SuppressKeyPress = true;
            }
        }

        private void cbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarFornecedor();
            Alteracao = 1;
        }

        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarProduto();
        }

        private void SelecionarProduto()
        {
            cbProduto.SelectedIndex = cbProduto.FindStringExact(cbProduto.Text);

            DataTable dt;
            string sql;

            if(cbProduto.SelectedIndex == -1 && cbProduto.Text.Trim() != "")
            {
                sql = "SELECT NOME FROM PRODUTO WHERE COD = '" + cbProduto.Text + "' OR COD_BARRA = '" + cbProduto.Text + "'";
                dt = BD.Buscar(sql);

                if (dt.Rows.Count > 0)
                {
                    cbProduto.Text = dt.Rows[0][0].ToString();
                    cbProduto.SelectedIndex = cbProduto.FindStringExact(cbProduto.Text);
                }
                else 
                    Geral.Erro("Código não localizado!");
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
                sql = "SELECT a.COD, a.VENDA, a.ESTOQUE_ATUAL, a.ESTOQUE_MINIMO FROM PRODUTO a ";
                sql += "WHERE a.PRODUTO_ID = " + cbProduto.SelectedValue;

                dt = BD.Buscar(sql);

                CodProduto.Text = dt.Rows[0]["COD"].ToString();
                Estoque.Text = dt.Rows[0]["ESTOQUE_ATUAL"].ToString();
                ValorProduto.Text = Convert.ToDouble(dt.Rows[0]["VENDA"]).ToString("c");

                double EstAtual = Convert.ToDouble(dt.Rows[0]["ESTOQUE_ATUAL"].ToString());
                double EstMin = Convert.ToDouble(dt.Rows[0]["ESTOQUE_MINIMO"].ToString());

                if (EstAtual < EstMin)
                    Estoque.BackColor = Color.LightPink;
                else
                    Estoque.BackColor = Color.LightGreen;
            }
        }

        private void cbProduto_Leave(object sender, EventArgs e)
        {
            SelecionarProduto();
        }

        private void CalculoCompra()
        {
            double Qtd = 0;
            double Unit = 0;
            double DescRS = 0;
            double DescPerc = 0;

            try
            {
                if (txtQtd.Text != "" && txtQtd.Text != ",")
                    Qtd = Convert.ToDouble(txtQtd.Text);

                if (ValorProduto.Text != "" && ValorProduto.Text != ",")
                    Unit = Convert.ToDouble(ValorProduto.Text.Replace("R$", "").Trim());

                txtValorBruto.Text = (Qtd * Unit).ToString("c");

                if (txtDescRS.Text != "" && txtDescRS.Text != ",")
                    DescRS = Convert.ToDouble(txtDescRS.Text.Replace("R$", "").Trim());

                if (txtDescPerc.Text != "" && txtDescPerc.Text != ",")
                    DescPerc = Convert.ToDouble(txtDescPerc.Text);


                if (DescPerc > 0)
                {
                    txtTotalDescPerc.Text = ((Qtd * Unit) * (DescPerc / 100)).ToString("c");
                    txtTotalDesconto.Text = ((Qtd * Unit) * (DescPerc / 100)).ToString("c");
                }
                else
                {
                    txtTotalDesconto.Text = (DescRS).ToString("c");
                    txtTotalDescPerc.Text = "R$ 0,00";
                }

                txtTotalLiquido.Text = (Convert.ToDouble(txtValorBruto.Text.Replace("R$", "").Trim()) - Convert.ToDouble(txtTotalDesconto.Text.Replace("R$", "").Trim())).ToString("c");

            }
            catch
            {
                txtValorBruto.Text = "R$ 0,00";
            }                        
        }

        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            CalculoCompra();
        }

        private void ValorProduto_TextChanged(object sender, EventArgs e)
        {
            CalculoCompra();
        }

        private void txtDescRS_TextChanged(object sender, EventArgs e)
        {
            if (txtDescRS.Text.Trim() != "")
                txtDescPerc.Text = "";

            CalculoCompra();
        }

        private void txtDescPerc_TextChanged(object sender, EventArgs e)
        {
            if (txtDescPerc.Text.Trim() != "" || txtDescPerc.Text.Trim() != "0")
                txtDescRS.Text = "";

            CalculoCompra();
        }

        private void frmCadCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if (EstaCancelada())
                return;

            if (dgProdutos.RowCount == 0)
            {
                Geral.Erro("Não há produto na lista!");
                return;
            }

            BtAlterar.Enabled = false;
            BtExcluir.Enabled = false;
            dgProdutos.Enabled = false;
            cbProduto.Enabled = false;

            DataGridViewRow l = dgProdutos.CurrentRow;

            txtIdItem.Text = l.Cells["IDItens"].Value.ToString();
            cbProduto.Text = l.Cells["Nome"].Value.ToString();
            txtQtd.Text = l.Cells["Qtd"].Value.ToString();
            ValorProduto.Text = Convert.ToDouble(l.Cells["Valor"].Value.ToString()).ToString("c");
            txtDescRS.Text = Convert.ToDouble(l.Cells["DescRS"].Value.ToString()).ToString("c");
            txtDescPerc.Text = l.Cells["DescPerc"].Value.ToString();

            Alteracao = 1;

        }

        private void dgProdutos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (EstaCancelada())
                return;

            if (dgProdutos.RowCount == 0)
            {
                Geral.Erro("Não há produto na lista!");
                return;
            }

            Geral.Pergunta("Deseja Realmente Excluir o Produto " + 
                dgProdutos.CurrentRow.Cells["Nome"].Value.ToString() +
                "\r\nEssa Ação NÃO PODERÁ SER DESFEITA!");

            if (!Geral.Resposta)
                return;

            string sql = "DELETE FROM COMPRA_ITENS WHERE COMPRA_ITENS_ID = " +
                dgProdutos.CurrentRow.Cells["IDItens"].Value.ToString();

            BD.ExecutarSQL(sql);
            CarregarItens();

            Alteracao = 1;
        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            if (EstaCancelada())
                return;

            LimparItens();
        }

        private void frmCadCompra_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (Fechar == 0)
                //Geral.Erro("Use o botão Sair!");
            //e.Cancel = true;
        }

        

        private void BtNovaCompra_Click(object sender, EventArgs e)
        {
            if (Alteracao == 1 && txtIdCompra.Text != "")
            {
                Geral.Erro("Há alterações que ainda não foram salvas!");
                return;
            }

            txtIdCompra.Text = "";

            cbFinalidade.SelectedIndex = 0;
            cbSituacao.SelectedIndex = 0;

            txtData.Text = "";
            txtNumero.Text = "";

            cbFornecedor.SelectedIndex = -1;

            txtIdItem.Text = "";
            cbProduto.SelectedIndex = -1;

            txtQtd.Text = "";
            ValorProduto.Text = "";

            txtValorBruto.Text = "R$ 0,00";

            txtDescRS.Text = "";
            txtDescPerc.Text = "";

            txtTotalDescPerc.Text = "";
            txtTotalDesconto.Text = "R$ 0,00";

            txtTotalLiquido.Text = "R$ 0,00";

            dgProdutos.Enabled = true;

            BtAlterar.Enabled = true;
            BtExcluir.Enabled = true;
            cbProduto.Enabled = true;

            CarregarItens();

            txtJustificativa.Text = "";

            //groupBox1.Enabled = true;
            //groupBox2.Enabled = true;
            //groupBox3.Enabled = true;
            //dgProdutos.Enabled = true;
            //txtJustificativa.Enabled = true;
            //BtCancelar.Enabled = true;
            //BtSalvar.Enabled = true;

            txtData.Focus();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if (EstaCancelada())
                return;

            try
            {
                SalvarCompra();
                Geral.OK("Compra salva som sucesso!");
                Alteracao = 0;
                cbFornecedor.Enabled = false;
            }
            catch (Exception ex)
            {
                Geral.Erro(ex.Message);
            }
        }

        private void VerificaCancelamento()
        {
            if(cbSituacao.SelectedIndex == 1)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                dgProdutos.Enabled = false;
                txtJustificativa.Enabled = false;
                BtCancelar.Enabled = false;
                BtSalvar.Enabled = false;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            if (EstaCancelada())
                return;

            if (txtIdCompra.Text == "")
            {
                Geral.Erro("Compra ainda não está salva!");
                return;
            }

            if(txtJustificativa.Text.Trim()=="")
            {
                Geral.Erro("Informe o motivo do cancelamento!");
                txtJustificativa.Focus();
                return;
            }

            Geral.Pergunta("Deseja realmente cancelar essa compra?");

            if (Geral.Resposta == false)
                return;

            if (BD.AcessoLiberado("Cancelar Compra ID: " + txtIdCompra.Text) == false)
                return;

            string sql = "";
            double Qtd;
            //Verificar se todos os items vão ter estoque correto após o cancelamento
            foreach (DataGridViewRow lin in dgProdutos.Rows)
            {
                sql = "SELECT ESTOQUE_ATUAL FROM PRODUTO WHERE PRODUTO_ID = " + lin.Cells["IdProd"].Value.ToString();
                Qtd = Geral.CvDbl(BD.Buscar(sql).Rows[0][0].ToString());

                if(Convert.ToDouble(lin.Cells["Qtd"].Value) > Qtd)
                {
                    Geral.Erro("Não será possível Cancelar essa compra!\r\n\r\nMotivo:\r\nO Item " + lin.Cells["Nome"].Value.ToString() + " ficaria com estoque negativo!");
                    return;
                }
            }

            sql = "UPDATE COMPRA SET SITUACAO_ID = 2 WHERE COMPRA_ID = " + txtIdCompra.Text;
            BD.ExecutarSQL(sql);

            cbSituacao.SelectedIndex = 1;

            sql = "INSERT INTO CANCELAMENTO (CANCELAMENTO_ID, TIPO, TIPO_ID, JUSTIFICATIVA) ";
            sql += "VALUES(NULL, 'C', " + txtIdCompra.Text +  ", '" + txtJustificativa.Text + "')";

            BD.ExecutarSQL(sql);


            foreach (DataGridViewRow lin in dgProdutos.Rows)
            {
                sql = "UPDATE PRODUTO SET ESTOQUE_ATUAL = ESTOQUE_ATUAL - " + Convert.ToDouble(lin.Cells["Qtd"].Value).ToString() + " WHERE PRODUTO_ID = " + lin.Cells["IdProd"].Value.ToString();
                BD.ExecutarSQL(sql);
            }


            Geral.OK("Compra Cancelada com Sucesso!");

             VerificaCancelamento();
        }
        
        private void txtData_KeyUp(object sender, KeyEventArgs e)
        {
            Alteracao = 1;
        }

        private void txtNumero_KeyUp(object sender, KeyEventArgs e)
        {
            Alteracao = 1;
        }

        private void BtALterarFornecedor_Click(object sender, EventArgs e)
        {
            Alteracao = 1;
            cbFornecedor.Enabled = true;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            if (Alteracao == 1 && txtIdCompra.Text == "")
                Geral.Erro("Há alterações que ainda não foram salvas!");
            else
            {
                Fechar = 1;
                this.Dispose();
            }
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            if (Alteracao == 1 && txtIdCompra.Text == "")
                Geral.Erro("Há alterações que ainda não foram salvas!");
            else
            {
                Fechar = 1;
                this.Dispose();
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
