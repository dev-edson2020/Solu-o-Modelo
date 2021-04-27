using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace Setup.Formularios
{
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        string Codigo;
        string CodBarra;
        DataTable dtFotos;
        int TotalFotos;
        int FotoAtual;

        private void btSalvar_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(panel1, errorProvider1))
                return;

            if (ValidaCodigo() == true)
                return;

            if (ValidaCodBarra() == true)
                return;

            int novo = 0;

            string[] v = new string[11];

            v[0] = txtId.Text;
            v[1] = cbProduto.Text;
            v[2] = txtCodigo.Text;
            v[3] = txtCodBarra.Text;
            v[4] = BD.CvData(txtValidade.Text);
            v[5] = BD.cvNum(txtCusto.Text);
            v[6] = BD.cvNum(txtReajuste.Text);
            v[7] = BD.cvNum(txtVenda.Text);
            v[8] = BD.cvNum(txtEstoque.Text);
            v[9] = BD.cvNum(txtEstMinimo.Text);
            v[10] = "N";

            if (CkAtivo.Checked)
                v[10] = "S";

            
            if (txtId.Text != "")
            {
                BD.ExecutarSQL("UPDATE PRODUTO p SET p.USUARIO_ALT = " + BD.UsuarioId + " WHERE p.PRODUTO_ID = " + txtId.Text);
                novo = 1;
            }

            
            try
            {
                txtId.Text = BD.ExecutarProcedure("PRODUTO_SALVAR", v, "Produto");

                if (novo == 0)
                    BD.ExecutarSQL("UPDATE PRODUTO p SET p.USUARIO_CAD = " + BD.UsuarioId + " WHERE p.PRODUTO_ID = " + txtId.Text);

                Codigo = "";
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRODUTO_NOME_UNICO"))
                    Geral.Erro("Produto já cadastrado!");
                else
                    Geral.Erro(ex.Message);
            }
                

        }        


        private bool ValidaCodigo()
        {
            if (txtCodigo.Text == "")
                return false;

            try
            {
                string sql = "";

                if (txtId.Text == "")
                    sql = "SELECT NOME FROM PRODUTO WHERE COD = '" + txtCodigo.Text + "'";
                else
                    sql = "SELECT NOME FROM PRODUTO WHERE PRODUTO_ID <> " + txtId.Text + " AND COD = '" + txtCodigo.Text + "'";

                string nome = BD.Buscar(sql).Rows[0][0].ToString();

                Geral.Erro("O código " + txtCodigo.Text + ", já esta em uso pelo produto " + nome);

                txtCodigo.Text = Codigo;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private bool ValidaCodBarra()
        {
            if (txtCodBarra.Text == "")
                return false;

            try
            {
                string sql = "";

                if (txtId.Text == "")
                    sql = "SELECT NOME FROM PRODUTO WHERE COD_BARRA = '" + txtCodBarra.Text + "'";
                else
                    sql = "SELECT NOME FROM PRODUTO WHERE PRODUTO_ID <> " + txtId.Text + " AND COD_BARRA = '" + txtCodBarra.Text + "'";

                string nome = BD.Buscar(sql).Rows[0][0].ToString();

                Geral.Erro("O código de barras " + txtCodBarra.Text + "\r\njá esta em uso pelo produto " + nome);
                txtCodBarra.Text = CodBarra;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Limpar()
        {
            txtId.Text = "";
            cbProduto.Text = "";
            cbProduto.SelectedIndex = -1;
            txtCodigo.Text = "";
            txtCodBarra.Text = "";
            txtValidade.Text = "";
            txtCusto.Text = "";
            txtReajuste.Text = "";
            txtVenda.Text = "";
            txtEstoque.Text = "";
            txtEstMinimo.Text = "";
            txtCadastro.Text = "";

            FotoProduto.Image = null;

            cbProduto.Focus();
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            if (Codigo == "")
                Codigo = txtCodigo.Text;
        }

        private void txtCodBarra_Enter(object sender, EventArgs e)
        {
            if (CodBarra == "")
                CodBarra = txtCodBarra.Text;
        }

        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            Codigo = "";
            CodBarra = "";
            FotoAtual = 0;

            CarregarProdutos();

            if (txtId.Text != "")
            {
                CarregarFoto();
                NavegarEntreFotos();

                PegarProduto();
            }
        }

        private void CalcularReajuste()
        {
            double Custo = 0;
            double Ajuste = 0;

            try
            {
                if (txtReajuste.Text != "")
                    Ajuste = Convert.ToDouble(txtReajuste.Text);

                if (txtCusto.Text != "")
                    Custo = Convert.ToDouble(txtCusto.Text.Replace("R$", "").Trim());

                if (Ajuste > 0)
                {
                    txtVenda.Text = (Custo * (1 + (Ajuste / 100))).ToString("c");
                }
                else
                    txtVenda.Text = "";
            }
            catch
            {
                txtVenda.Text = "";
            }
        }

        private void CarregarProdutos()
        {
            string sql = "SELECT NOME FROM PRODUTO ORDER BY NOME";
            cbProduto.DataSource = BD.Buscar(sql);
            cbProduto.SelectedIndex = -1;
        }

        private void PegarProduto()
        {
            string sql = "SELECT * FROM PRODUTO WHERE PRODUTO_ID = " + txtId.Text;
            DataTable dt = BD.Buscar(sql);

            cbProduto.Text = dt.Rows[0]["NOME"].ToString();
            txtCodigo.Text = dt.Rows[0]["COD"].ToString();
            txtCodBarra.Text = dt.Rows[0]["COD_BARRA"].ToString();

            if (!String.IsNullOrEmpty(dt.Rows[0]["VALIDADE"].ToString()))
                txtValidade.Text = Convert.ToDateTime(dt.Rows[0]["VALIDADE"].ToString()).ToShortDateString();

            txtCusto.Text = Convert.ToDouble(dt.Rows[0]["CUSTO"]).ToString("c");
            txtReajuste.Text = dt.Rows[0]["PERC_REAJUSTE"].ToString();
            txtVenda.Text = Convert.ToDouble(dt.Rows[0]["VENDA"]).ToString("c");
            txtEstoque.Text = dt.Rows[0]["ESTOQUE_ATUAL"].ToString();
            txtEstMinimo.Text = dt.Rows[0]["ESTOQUE_MINIMO"].ToString();
            txtCadastro.Text = Convert.ToDateTime(dt.Rows[0]["CADASTRO"].ToString()).ToShortDateString();

            if (dt.Rows[0]["ATIVO"].ToString() == "N")
                CkAtivo.Checked = false;
            else
                CkAtivo.Checked = true;
        }

        private void CarregarFoto()
        {
            string sql = "SELECT a.FOTO_PRODUTO_ID, a.FOTO FROM FOTO_PRODUTO a WHERE a.PRODUTO_ID = " + txtId.Text;
            dtFotos = BD.Buscar(sql);

            TotalFotos = dtFotos.Rows.Count;
        }

        private void NavegarEntreFotos()
        {
            if (TotalFotos == 0)
                return;


            if(FotoAtual==0)
            {
                BotaoPrimeira.Enabled = false;
                BotaoAnterior.Enabled = false;
            }
            else
            {
                BotaoPrimeira.Enabled = true;
                BotaoAnterior.Enabled = true;
            }

            if (FotoAtual == TotalFotos - 1)
            {
                BotaoProxima.Enabled = false;
                BotaoUltima.Enabled = false;
            }
            else
            {
                BotaoProxima.Enabled = true;
                BotaoUltima.Enabled = true;
            }

            if(TotalFotos==1)
            {
                BotaoPrimeira.Enabled = false;
                BotaoAnterior.Enabled = false;
                BotaoProxima.Enabled = false;
                BotaoUltima.Enabled = false;
            }

            byte[] foto = (byte[])dtFotos.Rows[FotoAtual]["FOTO"];
            MemoryStream ms = new MemoryStream(foto);
            FotoProduto.Image = Image.FromStream(ms);
        }

        private void BotaoAddFoto_Click(object sender, EventArgs e)
        {
            if(txtId.Text=="")
            {
                Geral.Erro("É necessário salvar o produto!");
                return;
            }

            OpenFileDialog arquivo = new OpenFileDialog();

            arquivo.Title = "Escolha uma imagem para o produto!";
            arquivo.FileName = "";
            arquivo.Filter = "Fotos|*.jpg;*.png;*.bmp";
            arquivo.CheckFileExists = true;

            if(arquivo.ShowDialog() == DialogResult.OK)
            {
                SalvarImagemPequena(arquivo.FileName, "NovaFoto.png", 250, 250, false);

                FotoProduto.Image = Image.FromFile(arquivo.FileName);

                byte[] foto = new byte[0];

                foto = File.ReadAllBytes(Environment.CurrentDirectory + "\\NovaFoto.png");

                string[] v = new string[3];

                v[0] = txtFotoId.Text;
                v[1] = txtId.Text;
                v[2] = BD.UsuarioId;

                txtFotoId.Text = BD.ExecutarProcedure("FOTO_PROD_SALVAR", v, "Foto Produto");
                BD.SalvarImagem("FOTO_PRODUTO", "FOTO", txtFotoId.Text, foto);

                txtFotoId.Text = "";

                CarregarFoto();

                FotoAtual = TotalFotos - 1;

                NavegarEntreFotos();

            }

        }

        private void BotaoProxima_Click(object sender, EventArgs e)
        {
            FotoAtual++;
            NavegarEntreFotos();
        }

        private void BotaoAnterior_Click(object sender, EventArgs e)
        {
            FotoAtual--;
            NavegarEntreFotos();
        }

        private void BotaoPrimeira_Click(object sender, EventArgs e)
        {
            FotoAtual = 0;
            NavegarEntreFotos();
        }

        private void BotaoUltima_Click(object sender, EventArgs e)
        {
            FotoAtual = TotalFotos - 1;
            NavegarEntreFotos();
        }

        public static void SalvarImagemPequena(string ArquivoOriginal, string NovaFoto, int Largura, int Altura, bool onlyResizeIfWider)
        {
            Image TamanhoImagem = Image.FromFile(ArquivoOriginal);

            TamanhoImagem.RotateFlip(RotateFlipType.Rotate180FlipNone);
            TamanhoImagem.RotateFlip(RotateFlipType.Rotate180FlipNone);

            if (onlyResizeIfWider)
            {
                if (TamanhoImagem.Width <= Largura)
                {
                    Largura = TamanhoImagem.Width;
                }
            }

            int newHeight = TamanhoImagem.Height * Largura / TamanhoImagem.Width;

            if (newHeight > Altura)
            {
                Largura = TamanhoImagem.Width * Altura / TamanhoImagem.Height;
                newHeight = Altura;
            }

            Image NovaImagem = TamanhoImagem.GetThumbnailImage(Largura, newHeight, null, IntPtr.Zero);

            TamanhoImagem.Dispose();

            NovaImagem.Save(NovaFoto);
        }

        private void txtCusto_TextChanged(object sender, EventArgs e)
        {
            CalcularReajuste();
        }

        private void txtReajuste_TextChanged(object sender, EventArgs e)
        {
            CalcularReajuste();
        }

        private void frmCadProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
    }
}
