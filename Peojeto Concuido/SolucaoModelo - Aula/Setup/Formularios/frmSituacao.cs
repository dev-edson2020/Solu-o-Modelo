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
    public partial class frmSituacao : Form
    {
        public frmSituacao()
        {
            InitializeComponent();
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            if(txtSituacao.Text=="")
            {
                Geral.Erro("Campo situação é obrigatório!");
                return;
            }

            try
            {
                string sql = "INSERT INTO SITUACAO VALUES (NULL, '" + txtSituacao.Text + "')";

                if (txtId.Text != "")
                    sql = "UPDATE SITUACAO SET NOME = '" + txtSituacao.Text +
                                        "' WHERE SITUACAO_ID = " + txtId.Text;

                BD.ExecutarSQL(sql);

                Busca();
                Limpar();

            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("UNQ_SITUACAO_UNICO"))
                    Geral.Erro("Situação já cadastrada!");
            }            
        }

        private void frmSituacao_Load(object sender, EventArgs e)
        {
            Busca();
        }

        private void Busca()
        {
            dgSituacao.DataSource = BD.Buscar("SELECT * FROM SITUACAO ORDER BY SITUACAO_ID");
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if(dgSituacao.Rows.Count==0)
            {
                Geral.Erro("Não h á item selecionado!");
                return;
            }

            if(dgSituacao.CurrentRow.Cells["PADRAO"].Value.ToString()=="S")
            {
                Geral.Erro("Não é permitido alterar essa situação!");
                return;
            }

            BtAlterar.Enabled = false;
            BtExcluir.Enabled = false;
            dgSituacao.Enabled = false;

            txtId.Text = dgSituacao.CurrentRow.Cells["id"].Value.ToString();
            txtSituacao.Text = dgSituacao.CurrentRow.Cells["Situacao"].Value.ToString();
            txtSituacao.Focus();
        }

        private void Limpar()
        {
            BtAlterar.Enabled = true;
            BtExcluir.Enabled = true;
            dgSituacao.Enabled = true;

            txtId.Text = "";
            txtSituacao.Text = "";
            txtSituacao.Focus();
        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            if (dgSituacao.Rows.Count == 0)
            {
                Geral.Erro("Não há item selecionado!");
                return;
            }

            if (dgSituacao.CurrentRow.Cells["PADRAO"].Value.ToString() == "S")
            {
                Geral.Erro("Não é permitido excluir essa situação!");
                return;
            }


            Geral.Pergunta("Deseja realmente excluir a Situação '" + 
                dgSituacao.CurrentRow.Cells["Situacao"].Value.ToString() + "'?");

            if (Geral.Resposta == false)
                return;

            try
            {
                BD.ExecutarSQL("DELETE FROM SITUACAO WHERE SITUACAO_ID = " +
                    dgSituacao.CurrentRow.Cells["id"].Value.ToString());

                Busca();
                Limpar();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("FK_COMPRA_SITUACAO"))
                    Geral.Erro("Situação não pode ser Excluída por que está sendo usada pelo sistema!");
            }

        }

        private void BtNovo_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
