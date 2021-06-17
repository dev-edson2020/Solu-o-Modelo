using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Setup.Formularios
{
    public partial class frmMenuProduto : Form
    {
        public frmMenuProduto()
        {
            InitializeComponent();
        }

        private string Criterio;

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btAdd.Left;
        }

        private void btAlterar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btAlterar.Left;
        }

        private void btExcluir_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btExcluir.Left;
        }

        private void btRelatorio_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btRelatorio.Left;
        }

        private void btDashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btDashBoard.Left;
        }

        private void btBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btBuscar.Left;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCadProduto frm = new frmCadProduto();
            frm.ShowDialog();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {

            frmCadProduto frm = new frmCadProduto();
            frm.txtId.Text = dgProduto.CurrentRow.Cells["PRODUTO_ID"].Value.ToString();

            frm.ShowDialog();

            BuscaGeral();
        }

        private void BuscaGeral()
        {
            string sql = "SELECT a.PRODUTO_ID, a.NOME, a.COD, a.VALIDADE, a.CUSTO, a.PERC_REAJUSTE, a.VENDA, a.ESTOQUE_ATUAL, a.ESTOQUE_MINIMO, CASE a.ATIVO WHEN 'S' THEN 'Ativo' ELSE 'Inativo' END AS ATIVO ";
            sql += "FROM PRODUTO a ";
            sql += Criterio;
            sql += " ORDER BY a.NOME";

            dgProduto.DataSource = BD.Buscar(sql);

            ColorirProduto();
            ContarStatus();
            CalcularEstoque();
            CalcularCustoEstoque();
        }

        private void ColorirProduto()
        {
            //int ativo = 0;
            //int inativo = 0;

            foreach (DataGridViewRow linha in dgProduto.Rows)
            {
                //Colorir de laranja quando estoque estiver baixo
                if(Convert.ToDouble(linha.Cells["EST_MINIMO"].Value) > Convert.ToDouble(linha.Cells["EST_ATUAL"].Value))
                {
                    linha.DefaultCellStyle.ForeColor = Color.Orange;
                }

                //Colorir de Vermelhor os produtos cancelados
                if (linha.Cells["Status"].Value.ToString() == "Inativo")
                {
                    linha.DefaultCellStyle.ForeColor = Color.Red;
                    //inativo++;
                }
                //else
                    //ativo++;

                //lblTotalAtivos.Text = ativo + " Produtos ativos";
                //lblTotalInativos.Text = inativo + " Produtos Inativos";
            }
        }

        private void ContarStatus()
        {
            string sql = "SELECT ";
            sql += "SUM(CASE WHEN p.ATIVO = 'S' THEN 1 ELSE 0 END) AS ATIVO, ";
            sql += "SUM(CASE WHEN p.ATIVO = 'N' THEN 1 ELSE 0 END) AS INATIVO ";
            sql += "FROM PRODUTO p";

            DataTable dt = BD.Buscar(sql);
            lblTotalAtivos.Text = dt.Rows[0]["ATIVO"].ToString() + " Produtos Ativos";
            lblTotalInativos.Text = dt.Rows[0]["INATIVO"].ToString() + " Produtos Inativos";
        }

        private void CalcularEstoque()
        {
            string v = "SELECT COUNT(*) FROM PRODUTO p WHERE p.ESTOQUE_ATUAL < p.ESTOQUE_MINIMO AND p.ATIVO = 'S'";
            v = BD.Buscar(v).Rows[0][0].ToString();
            lblTotalEstoqueBaixo.Text = v + " Produtos Baixo Estoque";
        }

        private void CalcularCustoEstoque()
        {
            string sql = "SELECT COALESCE(SUM(p.CUSTO * p.ESTOQUE_ATUAL), 0) FROM PRODUTO p WHERE p.ATIVO = 'S'";
            double Custo = Convert.ToDouble(BD.Buscar(sql).Rows[0][0].ToString());
            lblCustoEstoque.Text = Custo.ToString("c");
        }


        private void frmMenuProduto_Load(object sender, EventArgs e)
        {
            Location = new Point(215, 48); //x,y

            Criterio = "";
            //BuscaGeral();

            for (int i = 0; i < dgProduto.Columns.Count; i++)
            {
                if (i != 1)
                {
                    dgProduto.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgProduto.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }

        }

        private void dgProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5 || e.ColumnIndex == 7 || e.ColumnIndex == 8)
            {
                if (e.Value.ToString() == "0")
                    e.Value = "";
            }

            //if(e.ColumnIndex==9)
            //{
            //    if (e.Value.ToString() == "S")
            //        e.Value = "Ativo";
            //    else
            //        e.Value = "Inativo";
            //}
        }

        private void BuscarDescricao()
        {
            if (NomeContem.Checked)
                Criterio = "WHERE a.NOME CONTAINING '" + BuscaNome.Text + "'";

            if (NomeExato.Checked)
                Criterio = "WHERE a.NOME = '" + BuscaNome.Text + "'";

            if (NomeInicio.Checked)
                Criterio = "WHERE a.NOME LIKE '" + BuscaNome.Text + "%'";

            BuscaGeral();
        }

        private void BuscaNome_TextChanged(object sender, EventArgs e)
        {
            BuscarDescricao();
        }

        private void NomeContem_CheckedChanged(object sender, EventArgs e)
        {
            if (NomeContem.Checked)
                BuscarDescricao();
        }

        private void NomeExato_CheckedChanged(object sender, EventArgs e)
        {
            if (NomeExato.Checked)
                BuscarDescricao();
        }

        private void NomeInicio_CheckedChanged(object sender, EventArgs e)
        {
            if (NomeInicio.Checked)
                BuscarDescricao();
        }   
        
        private void BuscarCodigo()
        {
            string codigo = "*/*/";

            if (CodigoBusca.Text != "")
                codigo = CodigoBusca.Text;

            if (CodigoContem.Checked)
                Criterio = "WHERE a.COD LIKE '%" + codigo + "%'";

            if(CodigoExato.Checked)
                Criterio = "WHERE a.COD = '" + codigo + "'";

            BuscaGeral();
        }

        private void BuscarCodBarra()
        {

        }

        private void CodigoBusca_TextChanged(object sender, EventArgs e)
        {
            BuscarCodigo();
        }

        private void CodigoContem_CheckedChanged(object sender, EventArgs e)
        {
            if (CodigoContem.Checked)
                BuscarCodigo();
        }

        private void CodigoExato_CheckedChanged(object sender, EventArgs e)
        {
            if (CodigoExato.Checked)
                BuscarCodigo();
        }

        private void CodBarraBusca_Leave(object sender, EventArgs e)
        {
            Criterio = "WHERE a.COD_BARRA = '" + CodBarraBusca.Text + "'";
            BuscaGeral();
        }

        private void BtBuscaValidade_Click(object sender, EventArgs e)
        {
            if (ValidadeFinal.Value.Date < ValidadeInicial.Value.Date)
            {
                Geral.Erro("Data final não pode ser inferior a data Inicial!");
                return;
            }

            string DataI = ValidadeInicial.Value.ToShortDateString().Replace("/", ".");
            string DataF = ValidadeFinal.Value.ToShortDateString().Replace("/", ".");

            Criterio = "WHERE a.VALIDADE BETWEEN '" + DataI + "' AND '" + DataF + "'";
            BuscaGeral();
        }

        private void BuscaCusto()
        {
            string Valor = "0";

            if (CustoValor.Text != "")
                Valor = BD.cvNum(CustoValor.Text);

            if (CustoIgual.Checked)
                Criterio = "WHERE a.CUSTO = " + Valor;

            if (CustoMaior.Checked)
                Criterio = "WHERE a.CUSTO >= " + Valor;

            if (CustoMenor.Checked)
                Criterio = "WHERE a.CUSTO <= " + Valor;

            BuscaGeral();
        }

        private void CustoValor_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BuscaCusto();
                e.SuppressKeyPress = true;
            }
        }

        private void CustoIgual_CheckedChanged(object sender, EventArgs e)
        {
            if (CustoIgual.Checked)
                BuscaCusto();
        }

        private void CustoMaior_CheckedChanged(object sender, EventArgs e)
        {
            if (CustoMaior.Checked)
                BuscaCusto();
        }

        private void CustoMenor_CheckedChanged(object sender, EventArgs e)
        {
            if (CustoMenor.Checked)
                BuscaCusto();
        }

        private void BuscaVenda()
        {
            string Valor = "0";

            if (VendaValor.Text != "")
                Valor = BD.cvNum(VendaValor.Text);

            if (VendaIgual.Checked)
                Criterio = "WHERE a.VENDA = " + Valor;

            if (VendaMaior.Checked)
                Criterio = "WHERE a.VENDA >= " + Valor;

            if (VendaMenor.Checked)
                Criterio = "WHERE a.VENDA <= " + Valor;

            BuscaGeral();
        }

        private void VendaValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscaVenda();
                e.SuppressKeyPress = true;
            }
        }

        private void VendaIgual_CheckedChanged(object sender, EventArgs e)
        {
            if (VendaIgual.Checked)
                BuscaVenda();
        }

        private void VendaMaior_CheckedChanged(object sender, EventArgs e)
        {
            if (VendaMaior.Checked)
                BuscaVenda();
        }

        private void VendaMenor_CheckedChanged(object sender, EventArgs e)
        {
            if (VendaMenor.Checked)
                BuscaVenda();
        }

        private void BuscaEstoque()
        {
            string Estoque = "0";

            if (EstoqueBusca.Text != "")
                Estoque = BD.cvNum(EstoqueBusca.Text);

            if (EstoqueIgual.Checked)
                Criterio = "WHERE a.ESTOQUE_ATUAL = " + Estoque;

            if(EstoqueMaior.Checked)
                Criterio = "WHERE a.ESTOQUE_ATUAL >= " + Estoque;

            if(EstoqueMenor.Checked)
                Criterio = "WHERE a.ESTOQUE_ATUAL <= " + Estoque;

            BuscaGeral();
        }

        private void EstoqueBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                BuscaEstoque();
                e.SuppressKeyPress = true;
            }
        }

        private void EstoqueIgual_CheckedChanged(object sender, EventArgs e)
        {
            if (EstoqueIgual.Checked)
                BuscaEstoque();
        }

        private void EstoqueMaior_CheckedChanged(object sender, EventArgs e)
        {
            if (EstoqueMaior.Checked)
                BuscaEstoque();
        }

        private void EstoqueMenor_CheckedChanged(object sender, EventArgs e)
        {
            if (EstoqueMenor.Checked)
                BuscaEstoque();
        }

        private void BuscaEstoqueMinimo()
        {
            Criterio = "WHERE a.ESTOQUE_ATUAL < A.ESTOQUE_MINIMO";
            BuscaGeral();
        }

        private void EstoqueMInimo_Click(object sender, EventArgs e)
        {
            BuscaEstoqueMinimo();
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            AlterarStatusProduto("N");
        }

        private void AlterarStatusProduto(string Status)
        {
            if (dgProduto.Rows.Count == 0)
            {
                Geral.Erro("Não há produto selecionado!");
                return;
            }

            if (Status == "N")
                Geral.Pergunta("Deseja realmente Inativar o produto " + dgProduto.CurrentRow.Cells["NOME"].Value.ToString() + "?");
            else
                Geral.Pergunta("Deseja realmente Ativar o produto " + dgProduto.CurrentRow.Cells["NOME"].Value.ToString() + " novamente?");

            if (!Geral.Resposta)
                return;

            string sql = "UPDATE PRODUTO SET ATIVO = '" + Status + "' WHERE PRODUTO_ID = " + dgProduto.CurrentRow.Cells["PRODUTO_ID"].Value.ToString();
            BD.ExecutarSQL(sql);

            Geral.OK("Produto inativado com sucesso!");
            BuscaGeral();
        }

        private void dgProduto_SelectionChanged(object sender, EventArgs e)
        {
            if(dgProduto.CurrentRow.Cells["Status"].Value.ToString().Trim() =="Ativo")
            {
                lblStatus.Text = "Inativar";
                btExcluir.Visible = true;
                BtAtivar.Visible = false;
            }
            else
            {
                lblStatus.Text = "Ativar";
                btExcluir.Visible = false;
                BtAtivar.Visible = true;
            }
        }

        private void BtAtivar_Click(object sender, EventArgs e)
        {
            AlterarStatusProduto("S");
        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {

            int total = 0;
            int cancelados = 0;
            int ativos = 0;

            foreach (DataGridViewRow linha in dgProduto.Rows)
            {
                total++;

                if (linha.Cells["Status"].Value.ToString() == "Inativo")
                    cancelados++;
                else
                    ativos++;
            }

            ReportParameterCollection p = new ReportParameterCollection();

            p.Add(new ReportParameter("total", total.ToString()));
            p.Add(new ReportParameter("cancelados", cancelados.ToString()));
            p.Add(new ReportParameter("ativo", ativos.ToString()));

            reportViewer1.LocalReport.SetParameters(p);

            bindingSource1.DataSource = dgProduto.DataSource;
            Geral.ImprimirPDF_2(reportViewer1, "RelatorioProduto", @"C:\EdivamSistema\Pdfs");

        }

        private void dgProduto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string sql;
            string valor = "";

            foreach (DataGridViewCell Celula in dgProduto.SelectedCells)
            {
                if (Celula.ColumnIndex != 4)
                    return;

                if (valor == "")
                    valor = BD.cvNum(Celula.Value.ToString());

                sql = "UPDATE PRODUTO SET CUSTO = " + valor + 
                      " WHERE PRODUTO_ID = " + dgProduto.Rows[Celula.RowIndex].Cells["PRODUTO_ID"].Value.ToString();

                BD.ExecutarSQL(sql);

                Celula.Value = valor;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
