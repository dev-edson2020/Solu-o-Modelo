using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using Microsoft.Reporting.WinForms;

namespace Setup.Formularios
{
    public partial class frmMenuPessoa : Form
    {
        private string CriterioPessoa;

        public frmMenuPessoa()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btAdicionar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btAdicionar.Left;
        }

        private void btAlterar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btAlterar.Left;
        }

        private void btExcluir_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btInativar.Left;
        }

        private void btRelatorio_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btRelatorio.Left;
        }

        private void btFicha_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btFicha.Left;
        }

        private void btDashBoard_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btDashBoard.Left;
        }

        private void btBuscar_MouseMove(object sender, MouseEventArgs e)
        {
            lblBarraMenu.Left = btBuscar.Left;
        }

        private void frmMenuPessoa_Load(object sender, EventArgs e)
        {
            //CriterioPessoa = "";
            //BuscaPessoa();
            Location = new Point(215, 48); //x,y
            DashBoardStatus();
            DashBoardAniversario();
            tabControl1.SelectedIndex = 0;
            btDashBoard.Enabled = false;               
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            DashBoardStatus();
            DashBoardAniversario();

            btDashBoard.Enabled = false;
            btBuscar.Enabled = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

            btDashBoard.Enabled = true;
            btBuscar.Enabled = false;

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {           

            frmCadPessoa frm = new frmCadPessoa();
            frm.ShowDialog();
              
                       
        }

        //Inicio Buscas
        private void BuscaPessoa(bool Msg=false)
        {
            string sql = "SELECT a.PESSOA_ID, a.NOME, a.CODIGO, co.VALOR, a.CPF, a.CNPJ, a.SEXO, a.DATA_NASC, e.LOGRADOURO AS ENDERECO, e.CEP, b.BAIRRO, c.CIDADE, es.ESTADO, e.ESTADO AS SIGLA, a.ATIVO ";
            sql += "FROM PESSOA a ";
            sql += "INNER JOIN ENDERECO e ON e.PESSOA_ID = a.PESSOA_ID ";
            sql += "INNER JOIN BAIRRO b ON e.BAIRRO_ID = b.BAIRRO_ID ";
            sql += "INNER JOIN CIDADE c ON e.CIDADE_ID = c.CIDADE_ID ";
            sql += "INNER JOIN ESTADO es ON es.SIGLA = E.ESTADO ";
            sql += "INNER JOIN CONTATO co ON co.PESSOA_ID = a.PESSOA_ID ";
            sql += "WHERE co.PRINCIPAL = 'S' " + CriterioPessoa;
            sql += " ORDER BY a.NOME";

            dgPessoa.DataSource = BD.Buscar(sql);
            ColorirPessoa();
            RodapePessoa();

            if (!Msg)
                return;

            if (dgPessoa.RowCount == 0)
                Geral.Erro("Nenhum registro encontrado!");

        }

        private void RodapePessoa()
        {
            string sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.ATIVO = 'N'";
            lblTotalInativos.ForeColor = Color.DimGray;
            lblTotalInativos.TextAlign = ContentAlignment.TopLeft;

            lblTotalInativos.Text = BD.Buscar(sql).Rows[0][0].ToString() + " Pessoas Inativas";

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.ATIVO = 'S'";
            lblTotalAtivos.ForeColor = Color.DimGray;
            
            lblTotalAtivos.Text = BD.Buscar(sql).Rows[0][0].ToString() + " Pessoas Ativas";

            string MesAtual = DateTime.Now.ToString("MM");

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE EXTRACT(MONTH FROM a.DATA_NASC) = " + MesAtual;
            lblAniversariantes.ForeColor = Color.DimGray;
            lblAniversariantes.Text = "Aniversariantes: " + BD.Buscar(sql).Rows[0][0].ToString();
        }


        private void RodapePessoaErrada()
        {
            string sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.ATIVO = 'N'";
            lblTotalInativos.Text = BD.Buscar(sql).Rows[0][0].ToString() + " Pessoas Inativas";
            

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.ATIVO = 'S'";
            lblTotalAtivos.Text = BD.Buscar(sql).Rows[0][0].ToString() + " Pessoas Inativas";

            DateTime DiaPrimeiro = Convert.ToDateTime("01/" + DateTime.Now.ToString("MM/yyyy"));
            DateTime UltimoDia = DiaPrimeiro.AddMonths(1).AddDays(-1);

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.DATA_NASC BETWEEN '" + DiaPrimeiro.ToShortDateString().Replace("/", ".") + "' AND '" + UltimoDia.ToShortDateString().Replace("/", ".") + "'";
            lblAniversariantes.Text = "Aniversariantes: " + BD.Buscar(sql).Rows[0][0].ToString();
        }

        private void ColorirPessoa()
        {
            foreach (DataGridViewRow linha in dgPessoa.Rows)
            {
                if (linha.Cells["ATIVO"].Value.ToString() == "N")
                    linha.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void btNomeExato_CheckedChanged(object sender, EventArgs e)
        {
            if (btNomeExato.Checked)
                BuscarPessoaNome();
        }

        private void BuscarPessoaNome()
        {
            if (btNomeExato.Checked)
                CriterioPessoa = "AND a.NOME = '" + txtBuscaNome.Text + "'";

            if (btNomeContem.Checked)
                CriterioPessoa = "AND a.NOME CONTAINING '" + txtBuscaNome.Text + "'";

            if (btNomeInicio.Checked)
                CriterioPessoa = "AND a.NOME LIKE '" + txtBuscaNome.Text + "%'";

            if (btNomeTermino.Checked)
                CriterioPessoa = "AND a.NOME LIKE '%" + txtBuscaNome.Text + "'";

            BuscaPessoa(true);
        }

        private void btNomeContem_CheckedChanged(object sender, EventArgs e)
        {
            if (btNomeContem.Checked)
                BuscarPessoaNome();
        }

        private void btNomeInicio_CheckedChanged(object sender, EventArgs e)
        {
            if (btNomeInicio.Checked)
                BuscarPessoaNome();
        }

        private void btNomeTermino_CheckedChanged(object sender, EventArgs e)
        {
            if (btNomeTermino.Checked)
                BuscarPessoaNome();
        }

        private void txtBuscaNome_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void opCodigoExato_CheckedChanged(object sender, EventArgs e)
        {
            if (opCodigoExato.Checked)
                BuscaPessoaCodigo();
        }

        private void BuscaPessoaCodigo()
        {
            if (opCodigoExato.Checked)
                CriterioPessoa = "AND a.CODIGO = '" + txtBuscaCodigo.Text + "'";

            if (opCodigoContem.Checked)
                CriterioPessoa = "AND a.CODIGO CONTAINING '" + txtBuscaCodigo.Text + "'";

            BuscaPessoa();
        }

        private void opCodigoContem_CheckedChanged(object sender, EventArgs e)
        {
            if (opCodigoContem.Checked)
                BuscaPessoaCodigo();
        }


        private void opCPFExato_CheckedChanged(object sender, EventArgs e)
        {
            if (opCPFExato.Checked)
                CPFBusca();
        }

        private void CPFBusca()
        {
            if (opCPFExato.Checked)
                CriterioPessoa = "AND a.CPF = '" + txtCPFBusca.Text + "'";

            if (opCPFContem.Checked)
                CriterioPessoa = "AND a.CPF CONTAINING '" + txtCPFBusca.Text + "'";

            BuscaPessoa();
        }

        private void opCPFContem_CheckedChanged(object sender, EventArgs e)
        {
            if (opCPFContem.Checked)
                CPFBusca();
        }

        private void opCNPJExato_CheckedChanged(object sender, EventArgs e)
        {
            if (opCNPJExato.Checked)
                CNPJBusca();
        }

        private void CNPJBusca()
        {
            if (opCNPJExato.Checked)
                CriterioPessoa = "AND a.CNPJ = '" + txtCNPJBusca.Text + "'";

            if (opCNPJContem.Checked)
                CriterioPessoa = "AND a.CNPJ CONTAINING '" + txtCNPJBusca.Text + "'";

            BuscaPessoa();
        }

        private void opCNPJContem_CheckedChanged(object sender, EventArgs e)
        {
            if (opCNPJContem.Checked)
                CNPJBusca();
        }

        private void txtCPFBusca_TextChanged(object sender, EventArgs e)
        {
            CPFBusca();
        }

        private void txtCNPJBusca_TextChanged(object sender, EventArgs e)
        {
            CNPJBusca();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void opMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if (opMasculino.Checked)
            {
                CriterioPessoa = "AND a.SEXO = 'M'";
                BuscaPessoa();
            }

        }

        private void opFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (opFeminino.Checked)
            {
                CriterioPessoa = "AND a.SEXO = 'F'";
                BuscaPessoa();
            }
        }

        private void frmMenuPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btBuscarData_Click(object sender, EventArgs e)
        {
            BuscaDataNascimento();
        }

        private void BuscaDataNascimento()
        {
            if (txtDataInicial.Text.Trim() == "" || txtDataFinal.Text.Trim() == "")
            {
                Geral.Erro("Informe as duas datas!");
                return;
            }

            if (Convert.ToDateTime(txtDataInicial.Text) > Convert.ToDateTime(txtDataFinal.Text))
            {
                Geral.Erro("Data Final não pode ser menor que a Inicial!");
                return;
            }

            CriterioPessoa = "AND a.DATA_NASC BETWEEN '" + BD.CvData(txtDataInicial.Text) + "' AND '" + txtDataFinal.Text.Replace("/", ".") + "'";
            BuscaPessoa();
        }

        private void txtDataFinal_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDataFinal_Leave(object sender, EventArgs e)
        {
            if (txtDataFinal.Text == "")
                return;

            BuscaDataNascimento();
        }

        private void txtBuscaNome_Leave(object sender, EventArgs e)
        {
            if (txtBuscaNome.Text != "")
                BuscarPessoaNome();
        }

        private void txtCEPBusca_TextChanged(object sender, EventArgs e)
        {
            CriterioPessoa = "AND e.CEP CONTAINING '" + txtCEPBusca.Text + "'";
            BuscaPessoa();
        }

        private void txtBuscaEndereco_TextChanged(object sender, EventArgs e)
        {
            CriterioPessoa = "AND (e.LOGRADOURO CONTAINING ':' OR b.BAIRRO CONTAINING ':' OR c.CIDADE CONTAINING ':' OR es.ESTADO CONTAINING ':' OR es.SIGLA CONTAINING ':')";
            CriterioPessoa = CriterioPessoa.Replace(":", txtBuscaEndereco.Text);
            BuscaPessoa();
        }

        private void btStatusTodos_CheckedChanged(object sender, EventArgs e)
        {
            if(btStatusTodos.Checked)
            {
                CriterioPessoa = "";
                BuscaPessoa();
            }
        }

        private void btStatusAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if(btStatusAtivo.Checked)
            {
                CriterioPessoa = "AND a.ATIVO = 'S'";
                BuscaPessoa();
            }
        }

        private void btStatusInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (btStatusInativo.Checked)
            {
                CriterioPessoa = "AND a.ATIVO = 'N'";
                BuscaPessoa();
            }
        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 0)
                txtBuscaNome.Focus();

            if (tabControl2.SelectedIndex == 1)
                txtBuscaCodigo.Focus();

            if (tabControl2.SelectedIndex == 2)
                txtCPFBusca.Focus();

            if (tabControl2.SelectedIndex == 4)
                txtDataInicial.Focus();

            if (tabControl2.SelectedIndex == 5)
                txtBuscaEndereco.Focus();
        }

        private void txtBuscaCodigo_TextChanged(object sender, EventArgs e)
        {
            BuscaPessoaCodigo();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            if (dgPessoa.RowCount == 0)
            {
                Geral.Erro("Não há pessoa selecionada!");
                return;
            }

            frmCadPessoa frm = new frmCadPessoa();
            frm.txtIdPessoa.Text = dgPessoa.CurrentRow.Cells["PESSOA_ID"].Value.ToString();

            frm.ShowDialog();
        }




        //FIM Buscas


        private void btExcluir_Click(object sender, EventArgs e)
        {
            AlterarStatus("N", "inativar");
        }

        private void AlterarStatus(string Status, string Operacao)
        {
            if (dgPessoa.RowCount == 0)
            {
                Geral.Erro("Não há pessoa selecionada!");
                return;
            }

            Geral.Pergunta("Deseja realmente " + Operacao + " a pessoa: " + dgPessoa.CurrentRow.Cells["NOME"].Value.ToString());

            if (Geral.Resposta == false)
                return;

            string sql = "UPDATE PESSOA SET ATIVO = '" + Status + "' WHERE PESSOA_ID = " + dgPessoa.CurrentRow.Cells["PESSOA_ID"].Value.ToString();
            BD.ExecutarSQL(sql);

            Geral.OK(dgPessoa.CurrentRow.Cells["NOME"].Value.ToString() + ", foi inativado com sucesso!");
            BuscaPessoa();
        }

        private void btAtivar_Click(object sender, EventArgs e)
        {
            AlterarStatus("S", "ativar");
        }


        private void dgPessoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPessoa.CurrentRow == null)
                return;

            if (dgPessoa.CurrentRow.Cells["ATIVO"].Value.ToString() == "S")
            {
                btInativar.Visible = true;
                btAtivar.Visible = false;
                lblStatus.Text = "Inativar";
            }
            else
            {
                btInativar.Visible = false;
                btAtivar.Visible = true;
                lblStatus.Text = "Ativar";
            }

        }

        private void DashBoardStatus()
        {
            string sql = "SELECT CASE a.ATIVO WHEN 'S' THEN 'Ativo' WHEN 'N' THEN 'Inativo' END AS ATIVO, COUNT(*) AS TOTAL FROM PESSOA a GROUP BY a.ATIVO";
            graficoSituacao.DataSource = BD.Buscar(sql);
        }

        private void DashBoardAniversario()
        {
            lblTituloAniversario.Text = "ANIVERSÁRIANTES POR MES";

            string sql = "SELECT CASE EXTRACT(MONTH FROM p.DATA_NASC) ";
            sql += "WHEN 1 THEN 'Jan' ";
            sql += "WHEN 2 THEN 'Fev' ";
            sql += "WHEN 3 THEN 'Mar' ";
            sql += "WHEN 4 THEN 'Abr' ";
            sql += "WHEN 5 THEN 'Mai' ";
            sql += "WHEN 6 THEN 'Jun' ";
            sql += "WHEN 7 THEN 'Jul' ";
            sql += "WHEN 8 THEN 'Ago' ";
            sql += "WHEN 9 THEN 'Set' ";
            sql += "WHEN 10 THEN 'Out' ";
            sql += "WHEN 11 THEN 'Nov' ";
            sql += "ELSE 'Dez' ";
            sql += "END AS MES, ";
            sql += "COUNT(*) AS Aniversariantes ";
            sql += "FROM PESSOA p ";
            sql += "GROUP BY EXTRACT(MONTH FROM p.DATA_NASC)";

            graficoAniversario.DataSource = BD.Buscar(sql);
            graficoAniversario.DataBind();
        }

        private void GraficoNiverMes()
        {
            string Mes = DateTime.Now.ToString("MM");

            lblTituloAniversario.Text = "ANIVERSÁRIANTES DO MÊS ATUAL";
            
            string sql = "SELECT EXTRACT(DAY FROM p.DATA_NASC) AS MES, ";
            sql += "COUNT(*) AS Aniversariantes FROM PESSOA p ";
            sql += "WHERE EXTRACT(MONTH FROM p.DATA_NASC) = " + Mes;
            sql += " GROUP BY EXTRACT(DAY FROM p.DATA_NASC)";

            graficoAniversario.DataSource = BD.Buscar(sql);
            graficoAniversario.DataBind();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            MenuRelatorio.Show(btRelatorio, new Point(20, 20));
        }

        private void ExportarRelatorio(string Tipo)
        {
            //string sql = "SELECT p.NOME, e.LOGRADOURO, c.CIDADE, co.VALOR FROM PESSOA p ";
            //sql += "INNER JOIN ENDERECO e ON e.PESSOA_ID = p.PESSOA_ID ";
            //sql += "INNER JOIN CIDADE c ON C.CIDADE_ID = e.CIDADE_ID ";
            //sql += "INNER JOIN CONTATO co ON co.PESSOA_ID = p.PESSOA_ID ";
            //sql += "WHERE co.PRINCIPAL = 'S' ";
            //sql += "order by p.NOME";

            bsRelatorioPessoa.DataSource = dgPessoa.DataSource;

            if (Tipo == "Excel")
                Geral.ImprimirExcel(rpRelatorio, "RelatorioPessoa");
            else
                Geral.ImprimirPDF(rpRelatorio, "RelatorioPessoa");
        }

        private void btFicha_Click(object sender, EventArgs e)
        {
            if (dgPessoa.RowCount == 0)
            {
                Geral.Erro("Não há pessoa selecionada!");
                return;
            }

            ReportParameterCollection p = new ReportParameterCollection();

            p.Add(new ReportParameter("id", dgPessoa.CurrentRow.Cells["PESSOA_ID"].Value.ToString()));
            p.Add(new ReportParameter("nome", dgPessoa.CurrentRow.Cells["NOME"].Value.ToString()));
            p.Add(new ReportParameter("codigo", dgPessoa.CurrentRow.Cells["CODIGO"].Value.ToString()));

            if (dgPessoa.CurrentRow.Cells["SEXO"].Value.ToString() == "F")
                p.Add(new ReportParameter("sexo", "Feminino"));
            else
                p.Add(new ReportParameter("sexo", "Masculino"));

            if (dgPessoa.CurrentRow.Cells["CPF"].Value.ToString() != "")
                p.Add(new ReportParameter("documento", dgPessoa.CurrentRow.Cells["CPF"].Value.ToString()));
            else
                p.Add(new ReportParameter("documento", dgPessoa.CurrentRow.Cells["CNPJ"].Value.ToString()));

            string data = Convert.ToDateTime(dgPessoa.CurrentRow.Cells["DATA_NASC"].Value.ToString()).ToShortDateString();

            p.Add(new ReportParameter("nasc", data));

            p.Add(new ReportParameter("codigo", dgPessoa.CurrentRow.Cells["CODIGO"].Value.ToString()));


            string sql = "SELECT a.CEP, a.LOGRADOURO, a.COMPLEMENTO, a.NUMERO, b.BAIRRO, c.CIDADE, e.ESTADO ";
            sql += "FROM ENDERECO a ";
            sql += "INNER JOIN BAIRRO b ON b.BAIRRO_ID = a.BAIRRO_ID ";
            sql += "INNER JOIN CIDADE c ON c.CIDADE_ID = a.CIDADE_ID ";
            sql += "INNER JOIN ESTADO e ON e.SIGLA = a.ESTADO ";
            sql += "WHERE a.PESSOA_ID = " + dgPessoa.CurrentRow.Cells["PESSOA_ID"].Value.ToString();

            DataTable dt = BD.Buscar(sql);

            p.Add(new ReportParameter("cep", dt.Rows[0]["CEP"].ToString()));
            p.Add(new ReportParameter("numero", dt.Rows[0]["NUMERO"].ToString()));
            p.Add(new ReportParameter("logradouro", dt.Rows[0]["LOGRADOURO"].ToString()));
            p.Add(new ReportParameter("complemento", dt.Rows[0]["COMPLEMENTO"].ToString()));
            p.Add(new ReportParameter("Bairro", dt.Rows[0]["BAIRRO"].ToString()));
            p.Add(new ReportParameter("cidade", dt.Rows[0]["CIDADE"].ToString()));
            p.Add(new ReportParameter("estado", dt.Rows[0]["ESTADO"].ToString()));

            sql = "SELECT p.CADASTRO FROM PESSOA p WHERE p.PESSOA_ID = " + dgPessoa.CurrentRow.Cells["PESSOA_ID"].Value.ToString();
            dt = BD.Buscar(sql);

            p.Add(new ReportParameter("cadastro", Convert.ToDateTime(dt.Rows[0]["CADASTRO"].ToString()).ToShortDateString()));
            rpFicha.LocalReport.SetParameters(p);


            sql = "SELECT FIRST 8 a.TIPO, a.VALOR FROM CONTATO a WHERE a.PESSOA_ID = " + dgPessoa.CurrentRow.Cells["PESSOA_ID"].Value.ToString();
            dt = BD.Buscar(sql);

            ReportDataSource dados = new ReportDataSource("Base", dt as DataTable);
            this.rpFicha.LocalReport.DataSources.Clear();
            this.rpFicha.LocalReport.DataSources.Add(dados);

            Geral.ImprimirPDF(rpFicha, "FichaPessoa");
        }

        private void ExportarPDF_Click(object sender, EventArgs e)
        {
            ExportarRelatorio("PDF");
        }

        private void ExportarExcel_Click(object sender, EventArgs e)
        {
            ExportarRelatorio("Excel");
        }

        private void NiverMes_Click(object sender, EventArgs e)
        {
            GraficoNiverMes();
        }

        private void NiverAno_Click(object sender, EventArgs e)
        {
            DashBoardAniversario();
        }

        private void imprimirRelatórioEmExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadPessoa frm = new frmCadPessoa();
            frm.ShowDialog();
        }

        private void dgPessoa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ColorirPessoa();
        }

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
            CriterioPessoa = "AND a.NOME LIKE '" + txtBuscaNome.Text + "%'";
            BuscaPessoa();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
