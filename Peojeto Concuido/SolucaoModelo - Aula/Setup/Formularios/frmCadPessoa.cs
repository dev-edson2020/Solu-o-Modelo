using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmCadPessoa : Form
    {
        public frmCadPessoa()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (txtIdPessoa.Text == "")
            {
                this.Close();
                return;
            }

            if(txtIdEndereco.Text=="")
            {
                Geral.Erro("É necessário cadastrar um endereço para essa pessoa");
                LayoutBotoes(btnEndereco);
                MudarPanel(3);
                return;
            }

            if(dgContato.Rows.Count==0)
            {
                Geral.Erro("É necessário cadastrar pelo menos um contato para essa pessoa");
                LayoutBotoes(btnContato);
                MudarPanel(2);
                return;
            }

            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            if (txtIdPessoa.Text == "")
            {
                Geral.Erro("Cadastre os dados da pessoa para cadastrar dados de usuário!");
                return;
            }

            if (BD.AcessoLiberado("Acessar dados de usuário") == false)
                return;

            MudarPanel(1);
            txtLogin.Focus();
            LayoutBotoes(btnUsuario);
            PegarUsuario();
        }

        private void LayoutBotoes(Button botao)
        {
            //Devolver o padrão de preenchimento
            btnDadosPessoais.BackColor = Color.Gainsboro;
            btnUsuario.BackColor = Color.Gainsboro;
            btnEndereco.BackColor = Color.Gainsboro;
            btnContato.BackColor = Color.Gainsboro;

            //Remover a borda
            btnDadosPessoais.FlatAppearance.BorderSize = 0;
            btnUsuario.FlatAppearance.BorderSize = 0;
            btnEndereco.FlatAppearance.BorderSize = 0;
            btnContato.FlatAppearance.BorderSize = 0;
            
            //Formatando o botão que recebeu o clique
            botao.BackColor = Color.White;
            botao.FlatAppearance.BorderSize = 1;
            lblBarraSuperior.Location = new Point(botao.Location.X, 7);
            lblBarraInferior.Location = new Point(botao.Location.X + 1, 57);
        }

        private void MudarPanel(int i)
        {
            tabControl1.SelectedIndex = i;
        }

        private void btnDadosPessoais_Click(object sender, EventArgs e)
        {
            MudarPanel(0);
            LayoutBotoes(btnDadosPessoais);
        }

        private void frmCadPessoa_Load(object sender, EventArgs e)
        {
            MudarPanel(0);
            CarregarCidades();
            CarregarBairros();
            CarregarEstados();
            CarregarLogradouros();

            if (txtIdPessoa.Text != "")
                PegarDadosPessoais();

            tabControl1.Focus();
            txtNome.Focus();
        }

        private void PegarDadosPessoais()
        {
            string sql = "SELECT p.NOME, p.CODIGO, p.CPF, p.CNPJ, p.SEXO, p.DATA_NASC, p.CADASTRO FROM PESSOA p WHERE p.PESSOA_ID = " + txtIdPessoa.Text;
            DataTable dt = BD.Buscar(sql);

            txtNome.Text = dt.Rows[0]["NOME"].ToString();
            txtCodigo.Text = dt.Rows[0]["CODIGO"].ToString();
            txtCPF.Text = dt.Rows[0]["CPF"].ToString();
            txtCNPJ.Text = dt.Rows[0]["CNPJ"].ToString();

            rbFeminino.Checked = true;
            if (dt.Rows[0]["SEXO"].ToString() == "M")
                rbMaculino.Checked = true;

            txtDataNascimento.Text =Convert.ToDateTime(dt.Rows[0]["DATA_NASC"].ToString()).ToShortDateString();
            txtDataCadastro.Text = Convert.ToDateTime(dt.Rows[0]["CADASTRO"].ToString()).ToShortDateString();

            PegarEndereco();
        }

        private void PegarEndereco()
        {
            string sql = "SELECT e.ENDERECO_ID, e.CEP, e.LOGRADOURO, e.NUMERO, e.COMPLEMENTO, ";
            sql += "e.BAIRRO_ID, e.CIDADE_ID, e.ESTADO, e.CADASTRO ";
            sql += "FROM ENDERECO e WHERE e.PESSOA_ID = " + txtIdPessoa.Text;

            DataTable dt = BD.Buscar(sql);
            txtIdEndereco.Text = dt.Rows[0]["ENDERECO_ID"].ToString();
            txtCEP.Text = dt.Rows[0]["CEP"].ToString();
            cbLogradouro.Text = dt.Rows[0]["LOGRADOURO"].ToString();
            txtNumero.Text = dt.Rows[0]["NUMERO"].ToString();
            txtComplemento.Text = dt.Rows[0]["COMPLEMENTO"].ToString();
            cbBairro.SelectedValue = dt.Rows[0]["BAIRRO_ID"].ToString();
            cbCidade.SelectedValue = dt.Rows[0]["CIDADE_ID"].ToString();
            cbEstado.SelectedValue = dt.Rows[0]["ESTADO"].ToString();
            txtCadastroEndereco.Text = Convert.ToDateTime(dt.Rows[0]["CADASTRO"].ToString()).ToShortDateString();

            BuscarContatos();
        }


        private void PegarUsuario()
        {
            if (txtIdPessoa.Text != "")
            {
                string sql = "SELECT a.USUARIO_ID, a.ADM, a.OPERA_CAIXA, a.OPERA_SITEMA, " +
                             "a.REALIZA_VENDA, a.ATIVO, a.CADASTRO " +
                             "FROM USUARIO a WHERE a.PESSOA_ID = " + txtIdPessoa.Text;

                DataTable dt = BD.Buscar(sql);

                if (dt.Rows.Count == 0)
                    return;

                txtIdUsuario.Text = dt.Rows[0]["USUARIO_ID"].ToString();
                rbUsuarioComum.Checked = true;
                ckCaixa.Checked = false;
                ckSistema.Checked = false;
                ckVenda.Checked = false;
                ckAtivo.Checked = false;

                if (dt.Rows[0]["ADM"].ToString() == "S")
                    rbAdmin.Checked = true;

                if (dt.Rows[0]["OPERA_CAIXA"].ToString() == "S")
                    ckCaixa.Checked = true;

                if (dt.Rows[0]["OPERA_SITEMA"].ToString() == "S")
                    ckSistema.Checked = true;

                if (dt.Rows[0]["REALIZA_VENDA"].ToString() == "S")
                    ckVenda.Checked = true;

                if (dt.Rows[0]["ATIVO"].ToString() == "S")
                    ckAtivo.Checked = true;

                lblCadastrousuario.Text = "Usuário Cadastrado em: " + Convert.ToDateTime(dt.Rows[0]["CADASTRO"].ToString()).ToShortDateString();
            }
        }

        private void frmCadPessoa_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtIdUsuario.Text == "")
                SalvarUsuario();
            else
                AlterarUsuario();
        }

        private void AlterarUsuario()
        {
            //Alteração do login
            if(txtLogin.Text!="")
            {
                if (txtLogin.Text.Trim().Length < 6)
                {
                    Geral.Erro("Login deve ter 6 ou mais caracteres!");
                    return;
                }

                try
                {
                    string sql = "UPDATE USUARIO SET LOGIN = '" +
                     BD.Criptografar(txtLogin.Text) + "' WHERE USUARIO_ID = " +
                     txtIdUsuario.Text;

                    BD.ExecutarSQL(sql);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("USUARIO_UNICO"))
                        Geral.Erro("Este usuário não está disponível!");

                    return;
                }
                
            }
            //Alteração da Senha
            if(txtSenha.Text!="")
            {
                if (txtSenha.Text.Trim().Length != 8)
                {
                    Geral.Erro("A Senha deve ter exatos 8 digitos!");
                    return;
                }

                string[] c1 = new string[1];
                string[] v1 = new string[1];

                c1[0] = "SENHA";
                v1[0] = BD.Criptografar(txtSenha.Text);

                BD.Salvar("USUARIO", c1, v1, txtIdUsuario.Text);
            }

            //Alterar as permissões
            string[] c = new string[6];
            string[] v = new string[6];

            string valor = "S";

            c[0] = "PESSOA_ID";
            v[0] = txtIdPessoa.Text;

            valor = "S";
            if (!ckAtivo.Checked)
                valor = "N";

            c[1] = "ATIVO";
            v[1] = valor;

            valor = "S";
            if (rbUsuarioComum.Checked)
                valor = "N";

            c[2] = "ADM";
            v[2] = valor;

            valor = "S";
            if (!ckCaixa.Checked)
                valor = "N";

            c[3] = "OPERA_CAIXA";
            v[3] = valor;

            valor = "S";
            if (!ckSistema.Checked)
                valor = "N";

            c[4] = "OPERA_SITEMA";
            v[4] = valor;

            valor = "S";
            if (!ckVenda.Checked)
                valor = "N";

            c[5] = "REALIZA_VENDA";
            v[5] = valor;

            try
            {
                BD.Salvar("USUARIO", c, v, txtIdUsuario.Text);
                Geral.OK("Usuário alterado com sucesso!");
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("USUARIO_UNICO"))
                    Geral.Erro("Este usuário não está disponível!");
                else
                    Geral.Erro(ex.ToString());
            }
        }

        private void SalvarUsuario()
        {
            //Verificar se os campos foram preenchidos
            if (Geral.ValidaCampos(pnUsuario, errorUsuario) == true)
                return;

            //Verificar se o login tem mais de 5 caracteres
            if(txtLogin.Text.Trim().Length<6 || txtLogin.Text.Trim().Length > 20)
            {
                Geral.Erro("Login deve ter entre 6 e 20 caracteres!");
                return;
            }

            //Verificar se a senha tem 8 digitos
            if(txtSenha.Text.Trim().Length!=8)
            {
                Geral.Erro("A Senha deve ter exatos 8 digitos!");
                return;
            }

            string[] c = new string[8];
            string[] v = new string[8];

            c[0] = "LOGIN";
            v[0] = BD.Criptografar(txtLogin.Text);

            c[1] = "SENHA";
            v[1] = BD.Criptografar(txtSenha.Text);

            string valor = "S";
            if (rbUsuarioComum.Checked)
                valor = "N";

            c[2] = "ADM";
            v[2] = valor;

            valor = "S";
            if (!ckCaixa.Checked)
                valor = "N";

            c[3] = "OPERA_CAIXA";
            v[3] = valor;

            valor = "S";
            if (!ckSistema.Checked)
                valor = "N";

            c[4] = "OPERA_SITEMA";
            v[4] = valor;

            valor = "S";
            if (!ckVenda.Checked)
                valor = "N";

            c[5] = "REALIZA_VENDA";
            v[5] = valor;

            c[6] = "PESSOA_ID";
            v[6] = txtIdPessoa.Text;

            valor = "S";
            if (!ckAtivo.Checked)
                valor = "N";

            c[7] = "ATIVO";
            v[7] = valor;

            try
            {
                BD.Salvar("USUARIO", c, v);
                Geral.OK("Usuário salvo com sucesso!");
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("USUARIO_UNICO"))
                    Geral.Erro("Este usuário não está disponível!");
                else
                    Geral.Erro(ex.ToString());
            }

        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            if (txtIdPessoa.Text == "")
            {
                Geral.Erro("Cadastre os dados da pessoa para cadastrar dados de contato!");
                return;
            }

            LayoutBotoes(btnContato);
            MudarPanel(2);
        }

        private void BuscarContatos()
        {
            string sql = "SELECT a.CONTATO_ID, a.TIPO, a.VALOR, a.PRINCIPAL, a.OBS FROM CONTATO a where a.PESSOA_ID = " + txtIdPessoa.Text;
            dgContato.DataSource = BD.Buscar(sql);

            sql = "SELECT DISTINCT c.TIPO FROM CONTATO c ORDER BY c.TIPO";
            txtTipoContato.DataSource = BD.Buscar(sql);
            txtTipoContato.SelectedIndex = -1;
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {
            //Verificar se os campos obrigatórios estão preenchidos
            if (Geral.ValidaCampos(pnPessoa, errorProvider1))
                return;

            //garantir que o CPF ou o CNPJ estejam informados
            if(txtCPF.Text=="" && txtCNPJ.Text=="")
            {
                Geral.Erro("Informe o CPF ou o CNPJ!");
                txtCPF.Focus();
                return;
            }

            //Validar o total de digitos do CPF
            if(txtCPF.Text!="" && txtCPF.Text.Length!=14)
            {
                Geral.Erro("CPF precisa de 11 digitos");
                txtCPF.Focus();
                return;
            }

            //Validar o total de digitos do CNPJ
            if (txtCNPJ.Text != "" && txtCNPJ.Text.Length != 18)
            {
                Geral.Erro("CNPJ precisa de 14 digitos");
                txtCNPJ.Focus();
                return;
            }

            if(!rbMaculino.Checked && !rbFeminino.Checked)
            {
                Geral.Erro("Informe o sexo da pessoa!");
                return;
            }

            string cpf = "null";
            if (txtCPF.Text != "")
                cpf = txtCPF.Text; 

            string cnpj = "null";
            if (txtCNPJ.Text != "")
                cnpj = txtCNPJ.Text;

            string sexo = "null";
            if (rbMaculino.Checked)
                sexo = "M";

            if (rbFeminino.Checked)
                sexo = "F";


            string[] v = new string[7];
            v[0] = txtIdPessoa.Text;
            v[1] = txtNome.Text;
            v[2] = txtCodigo.Text;
            v[3] = cpf;
            v[4] = cnpj;
            v[5] = sexo;
            v[6] = BD.CvData(txtDataNascimento.Text);

            txtIdPessoa.Text = BD.ExecutarProcedure("PESSOA_SALVAR", v, "Dados Pessoais");


        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtCPF.Text != "")
                txtCNPJ.Text = "";
        }

        private void txtCNPJ_TextChanged(object sender, EventArgs e)
        {
            if (txtCNPJ.Text != "")
                txtCPF.Text = "";
        }

        private void btnCancelarPessoa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvarContato_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(panelContato, errorContato))
                return;

            string[] v = new string[6];
            v[0] = txtIdContato.Text;
            v[1] = txtTipoContato.Text;
            v[2] = txtValorContato.Text;

            string principal = "N";
            if (ckPadraoContato.Checked)
                principal = "S";

            string sql = "SELECT COUNT(*) FROM CONTATO a WHERE a.PESSOA_ID = " + txtIdPessoa.Text;
            if (BD.Buscar(sql).Rows[0][0].ToString() == "0")
                principal = "S";

            v[3] = principal;
            v[4] = txtObs.Text;
            v[5] = txtIdPessoa.Text;

            string id = BD.ExecutarProcedure("CONTATO_SALVAR", v, "Contato");

            if (principal == "S")
            {
                BD.ExecutarSQL("UPDATE CONTATO SET PRINCIPAL = 'N' WHERE PESSOA_ID = " + txtIdPessoa.Text);
                BD.ExecutarSQL("UPDATE CONTATO SET PRINCIPAL = 'S' WHERE CONTATO_ID = " + id);
            }

            LimparContato();
            BuscarContatos();
        }

        private void LimparContato()
        {

            txtIdContato.Text = "";
            txtTipoContato.Text = "";
            txtTipoContato.SelectedIndex = -1;
            txtValorContato.Text = "";
            txtObs.Text = "";
            ckPadraoContato.Checked = false;
            ckPadraoContato.Enabled = true;
            btnNovoContato.Visible = false;

            dgContato.Enabled = true;
            btnSalvarContato.Text = "Salvar";
            btnSalvarContato.BackColor = Color.Green;

            txtTipoContato.Focus();
        }

        private void dgContato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.E)
                PegarContato();
        }

        private void PegarContato()
        {
            btnNovoContato.Visible = true;
            dgContato.Enabled = false;
            btnSalvarContato.Text = "Editar";
            btnSalvarContato.BackColor = Color.SteelBlue;

            txtIdContato.Text = dgContato.CurrentRow.Cells["CONTATO_ID"].Value.ToString();
            txtTipoContato.Text = dgContato.CurrentRow.Cells["TIPO_CONTATO"].Value.ToString();
            txtValorContato.Text =  dgContato.CurrentRow.Cells["CONTATO"].Value.ToString();

            
            if (dgContato.CurrentRow.Cells["principal"].Value.ToString() == "S")
                ckPadraoContato.Checked = true;
            else
                ckPadraoContato.Checked = false;

            if (ckPadraoContato.Checked)
                ckPadraoContato.Enabled = false;

            txtObs.Text = dgContato.CurrentRow.Cells["obs"].Value.ToString();
        }

        private void btnNovoContato_Click(object sender, EventArgs e)
        {
            LimparContato();
        }

        private void btnExcluirContato_Click(object sender, EventArgs e)
        {
            if(txtIdContato.Text=="")
            {
                Geral.Erro("Selecione um item e use o atalho (Ctrl + E)");
                return;
            }

            if (BD.Excluir("CONTATO", txtIdContato.Text) == true)
            {

                if (ckPadraoContato.Checked==true)
                {
                    string sql = "select count(*) from contato c where c.PESSOA_ID = " + txtIdPessoa.Text;
                    string total = BD.Buscar(sql).Rows[0][0].ToString();

                    if(total!="0")
                    {
                        sql = "select first 1 c.contato_id from contato c ";
                        sql += "where c.PESSOA_ID = " + txtIdPessoa.Text;

                        sql = BD.Buscar(sql).Rows[0][0].ToString();

                        BD.ExecutarSQL("UPDATE CONTATO SET PRINCIPAL = 'S' WHERE CONTATO_ID = " + sql);
                    }
                }

                LimparContato();
                BuscarContatos();
            }
        }

        private void btnSalvarEndereco_Click(object sender, EventArgs e)
        {
            //Validar Campos Vazios
            if (Geral.ValidaCampos(pnEndereco, errorProvider1))
                return;

            //Validar o CEP
            if(txtCEP.Text.Length != 9)
            {
                Geral.Erro("Campo CEP imcompleto!");
                txtCEP.Focus();
                return;
            }

            //Validar Bairro
            string idBairro;
            if (cbBairro.SelectedIndex == -1)
            {
                idBairro = SalvarBairro();
                CarregarBairros();
                cbBairro.SelectedValue = idBairro;
            }
            else
                idBairro = cbBairro.SelectedValue.ToString();


            //Validar Cidade
            string idCidade;
            if (cbCidade.SelectedIndex == -1)
            {
                idCidade = SalvarCidade();
                CarregarCidades();
                cbCidade.SelectedValue = idCidade;
            }
            else
                idCidade = cbCidade.SelectedValue.ToString();


            string[] v = new string[9];

            v[0] = txtIdEndereco.Text;
            v[1] = txtCEP.Text;
            v[2] = cbLogradouro.Text;
            v[3] = txtComplemento.Text;
            v[4] = idBairro;
            v[5] = idCidade;
            v[6] = cbEstado.SelectedValue.ToString();
            v[7] = txtIdPessoa.Text;
            v[8] = txtNumero.Text;

            txtIdEndereco.Text = BD.ExecutarProcedure("ENDERECO_SALVAR", v, "Endereço");

        }

        private string SalvarBairro()
        {
            string sql = "SELECT p.ID FROM BAIRRO_SALVAR(NULL, '" + cbBairro.Text + "') p";
            return BD.Buscar(sql).Rows[0][0].ToString();
        }

        private string SalvarCidade()
        {
            string sql = "SELECT p.ID FROM CIDADE_SALVAR(NULL, '" + cbCidade.Text + "') p";
            return BD.Buscar(sql).Rows[0][0].ToString();
        }

        private void btnEndereco_Click(object sender, EventArgs e)
        {
            if (txtIdPessoa.Text == "")
            {
                Geral.Erro("Cadastre os dados da pessoa para cadastrar dados de endereço!");
                return;
            }

            LayoutBotoes(btnEndereco);
            MudarPanel(3);
        }

        private void CarregarCidades()
        {
            cbCidade.DataSource = BD.Buscar("SELECT CIDADE_ID, CIDADE FROM CIDADE ORDER BY CIDADE");
            cbCidade.SelectedIndex = -1;
        }

        private void CarregarBairros()
        {
            cbBairro.DataSource = BD.Buscar("SELECT BAIRRO_ID, BAIRRO FROM BAIRRO ORDER BY BAIRRO");
            cbBairro.SelectedIndex = -1;
        }

        private void txtCEP_Leave(object sender, EventArgs e)
        {
            //Validar CEP
            if(txtCEP.Text.Length < 9)
            {
                Geral.Erro("CEP incompleto!");
                return;
            }

            string xml = "https://viacep.com.br/ws/" + txtCEP.Text + "/xml/";

            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            try
            {
                if (cbLogradouro.Text != "" && cbLogradouro.Text != ds.Tables[0].Rows[0]["logradouro"].ToString())
                {
                    Geral.Pergunta("O logradouro (" + ds.Tables[0].Rows[0]["logradouro"].ToString() + ") é diferente do logradrouro já cadastrado, Deseja Substituir?");
                    if (Geral.Resposta == true)
                        cbLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                }
                else
                    cbLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();


                if (txtComplemento.Text != "" && txtComplemento.Text != ds.Tables[0].Rows[0]["complemento"].ToString())
                {
                    Geral.Pergunta("O complemento (" + ds.Tables[0].Rows[0]["complemento"].ToString() + ") é diferente do complemento já cadastrado, Deseja Substituir?");
                    if (Geral.Resposta == true)
                        txtComplemento.Text = ds.Tables[0].Rows[0]["complemento"].ToString();
                }
                else
                    cbLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();


                cbBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                cbCidade.Text = ds.Tables[0].Rows[0]["localidade"].ToString();
                cbEstado.SelectedValue = ds.Tables[0].Rows[0]["uf"].ToString();
            }
            catch
            {
                cbLogradouro.Text = "";
                cbLogradouro.SelectedIndex = -1;
                txtComplemento.Text = "";
                cbBairro.Text = "";
                cbBairro.SelectedIndex = -1;
                cbCidade.Text = "";
                cbCidade.SelectedIndex = -1;
                cbEstado.Text = "";
                cbEstado.SelectedIndex = -1;
                txtNumero.Text = "";
                Geral.Erro("CEP inválido!");
            }
        }

        private void cbEstado_Leave(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = cbEstado.FindStringExact(cbEstado.Text);

            if(cbEstado.Text.Trim() != "" && cbEstado.SelectedIndex==-1)
            {
                Geral.Pergunta("Estado não cadastrado deseja cadastrar agora?");

                if (Geral.Resposta)
                {
                    string NovoEstado = cbEstado.Text;
                    frmCadEstado frm = new frmCadEstado();
                    frm.txtEstado.Text = cbEstado.Text;
                    frm.ShowDialog();
                    CarregarEstados();
                    cbEstado.SelectedIndex = cbEstado.FindStringExact(NovoEstado);
                }
            }
        }

        private void CarregarEstados()
        {
            string sql = "SELECT a.SIGLA, a.ESTADO FROM ESTADO a order by a.ESTADO";
            cbEstado.DataSource = BD.Buscar(sql);
            cbEstado.SelectedIndex = -1;
        }

        private void CarregarLogradouros()
        {
            string sql = "SELECT DISTINCT a.LOGRADOURO FROM ENDERECO a order by a.LOGRADOURO";
            cbLogradouro.DataSource = BD.Buscar(sql);
            cbLogradouro.SelectedIndex = -1;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedIndex == -1)
            {
                lblSigla.Text = "";
                return;
            }

            lblSigla.Text = cbEstado.SelectedValue.ToString();
        }

        private void btnAddEstado_Click(object sender, EventArgs e)
        {
            frmCadEstado frm = new frmCadEstado();
            frm.ShowDialog();
        }

        private void cbBairro_Leave(object sender, EventArgs e)
        {
            cbBairro.SelectedIndex = cbBairro.FindStringExact(cbBairro.Text);
        }

        private void cbCidade_Leave(object sender, EventArgs e)
        {
            cbCidade.SelectedIndex = cbCidade.FindStringExact(cbCidade.Text);
        }
    }
}
