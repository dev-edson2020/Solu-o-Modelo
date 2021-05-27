using System;
using System.Drawing;
using System.Windows.Forms;

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

        private void frmMenuPessoa_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            tabControl2.SelectedIndex = 0;

            //CriterioPessoa = "";
            //BuscaPessoa();

            DashBoardStatus();
            DashBoardAniversario();          
        }

        private void btDashBoard_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }
        //Inicio Busca        

        private void BuscaPessoa(bool Msg = false)
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
            lblTotalInativos.Text = BD.Buscar(sql).Rows[0][0].ToString() +  "  Pessoas  Inativas";

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.ATIVO = 'S'";
            lblTotalAtivos.Text = BD.Buscar(sql).Rows[0][0].ToString() +  "  Pessoas  Ativas";

            string MesAtual = DateTime.Now.ToString("MM");

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE EXTRACT(MONTH FROM a.DATA_NASC) = " + MesAtual;
            lblAniversariantes.Text = "Aniversariantes: " + BD.Buscar(sql).Rows[0][0].ToString();
        }

        private void RodapePessoaErrada()
        {
            string sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.ATIVO = 'N'";
            lblTotalInativos.Text = BD.Buscar(sql).Rows[0][0].ToString()  +  " Pessoas Inativas";

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.ATIVO = 'S'";
            lblTotalAtivos.Text = BD.Buscar(sql).Rows[0][0].ToString()  +  " Pessoas Inativas";

            DateTime DiaPrimeiro = Convert.ToDateTime("01/" + DateTime.Now.ToString("MM/yyyy"));
            DateTime UltimoDia = DiaPrimeiro.AddMonths(1).AddDays(-1);

            sql = "SELECT COUNT(*) FROM PESSOA a WHERE a.DATA_NASC BETWEEN '" + DiaPrimeiro.ToShortDateString().Replace("/", ".") + "' AND '" + UltimoDia.ToShortDateString().Replace("/", ".") + "'";
            lblAniversariantes.Text = "Aniversariantes: " + BD.Buscar(sql).Rows[0][0].ToString();
        }

        private void ColorirPessoa()
        {
            foreach (DataGridViewRow  linha in dgPessoa.Rows)
            {
                if(linha.Cells["ATIVO"].Value.ToString() == "N")
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
                CriterioPessoa = "AND a.NOME LIKE '%" + txtBuscaNome.Text + "%'";

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
                CriterioPessoa = "AND a.CODIGO CONTAINING  '" + txtBuscaCodigo.Text + "'";

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
                Geral.Erro("Informe a duas Datas!");
                return;
            }
            if (Convert.ToDateTime(txtDataInicial.Text) > (Convert.ToDateTime(txtDataFinal.Text)))
            {
                Geral.Erro("Data FInal não pode ser menor do que a Data Inicial!");
                return;
            }
            CriterioPessoa = "AND a.DATA_NASC BETWEEN '" + txtDataInicial.Text + "' AND '" + txtDataFinal.Text.Replace("/", ".") + "'";
            BuscaPessoa();
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

        private void txtBuscaNome_TextChanged(object sender, EventArgs e)
        {
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
            if (btStatusTodos.Checked)
            {
                CriterioPessoa = "";
                BuscaPessoa();
            }
        }

        private void btStatusAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (btStatusAtivo.Checked)
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

       
        //Fim Buscas
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

        private void btExcluir_Click(object sender, EventArgs e)
        {
            AlterarStatus("N", "inativar");
        }

        private void dgPessoa_SelectionChanged(object sender, EventArgs e)
        {
            if (dgPessoa.CurrentRow == null)
                return;

            if (dgPessoa.CurrentRow.Cells["ATIVO"].Value.ToString() == "S")
            {
                btExcluir.Visible = true;
                btAtivar.Visible = false;
                lblStatus.Text = "Inativar";
            }
            else
            {
                btExcluir.Visible = false;
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
            string PrimeiroDia = "01/01/" + DateTime.Now.ToString("yyyy");

            string UltimoDia = Convert.ToDateTime(PrimeiroDia).AddYears(1).AddDays(-1).ToString("dd/MM/yyyy");

            lblTituloAniversario.Text = "ANIVERSÁRIANTES POR MÊS:  " + PrimeiroDia +  " até " + UltimoDia;

            PrimeiroDia = PrimeiroDia.Replace("/", ".");
            UltimoDia = UltimoDia.Replace("/", ".");

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

        private void btRelatorio_Click(object sender, EventArgs e)
        {
            string sql = "SELECT p.NOME, e.LOGRADOURO, c.CIDADE, co.VALOR FROM PESSOA p ";
            sql += "INNER JOIN ENDERECO e ON e.PESSOA_ID = p.PESSOA_ID ";
            sql += "INNER JOIN CIDADE c ON C.CIDADE_ID = e.CIDADE_ID ";
            sql += "INNER JOIN CONTATO co ON co.PESSOA_ID = p.PESSOA_ID ";
            sql += "WHERE co.PRINCIPAL = 'S' ";
            sql += "order by p.NOME";

            bsRelatorioPessoa.DataSource = BD.Buscar(sql);
            Geral.ImprimirPDF(rpRelatorio, "PessoaRelatorio");
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
            lblBarraMenu.Left = btExcluir.Left;
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
    }
}
