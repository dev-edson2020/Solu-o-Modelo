using System;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmFinalidade : Form
    {
        public frmFinalidade()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if (txtFinalidade.Text == "")
            {
                Geral.Erro("O campo finalidade é obrigatório!");
                return;
            }
            try
            {
                string sql = "INSERT INTO FINALIDADE VALUES (NULL, '" + txtFinalidade.Text + "')";

                if (txtId.Text != "")
                    sql = "UPDADE FINALIDADE SET NOME = '" + txtFinalidade.Text + "' WHERE FINALIDADE_ID = " + txtId.Text;

                BD.ExecutarSQL(sql);
                Limpar();
                Busca();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FINALIDADE_UNICO"))

                    Geral.Erro("Finalidade já Cadastrada!");
            }
        }
        private void Busca()
        {
            dgFinalidade.DataSource = BD.Buscar("SELECT a.FINALIDADE_ID, a.NOME, a.PADRAO FROM FINALIDADE a ORDER BY a.FINALIDADE_ID");
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if (dgFinalidade.Rows.Count == 0)
            {
                Geral.Erro("Não há item selecionado");
                return;
            }
            if(dgFinalidade.CurrentRow.Cells["Padrao"].Value.ToString() == "S")
            {
                Geral.Erro("Não é possivel alterar essa finalidade! ");
                return;
            }

            BtAlterar.Enabled = false;
            BtExcluir.Enabled = false;
            dgFinalidade.Enabled = false;

            txtId.Text = dgFinalidade.CurrentRow.Cells["ID"].Value.ToString();
            txtFinalidade.Text = dgFinalidade.CurrentRow.Cells["Finalidade"].Value.ToString();
        }
        private void Limpar()
        {
            txtId.Text = "";
            txtFinalidade.Text = "";
            BtAlterar.Enabled = true;
            BtExcluir.Enabled = true;
            dgFinalidade.Enabled = true;
            txtFinalidade.Focus();
        }

        private void frmFinalidade_Load(object sender, EventArgs e)
        {
            Busca();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (dgFinalidade.Rows.Count == 0)
            {
                Geral.Erro("Não há item selecionado");
                return;
            }

            if (dgFinalidade.CurrentRow.Cells["Padrao"].Value.ToString() == "S")
            {
                Geral.Erro("Não é possivel excluir essa finalidade! ");
                return;
            }

            Geral.Pergunta("Deseja realmente excluir a finalidade '" + 
                    dgFinalidade.CurrentRow.Cells["Finalidade"].Value.ToString() + "'?");


            if (!Geral.Resposta)
                return;
            try
            {

                BD.ExecutarSQL("DELETE FROM FINALIDADE WHERE FINALIDADE_ID = " + dgFinalidade.CurrentRow.Cells["Id"].Value.ToString());
                Geral.OK("Excluido com sucesso!");
                Busca();
                Limpar();                
            }

            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_COMPRA_FINALIDADE")) 
                Geral.Erro("Finalidade não pode ser excluida, pois já está sendo usada pelo sistema!");
            }
        }
    }
}
