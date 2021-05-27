using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Formularios
{
    public partial class frmCadEstado : Form
    {
        public frmCadEstado()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadEstado_Load(object sender, EventArgs e)
        {
            CarregarEstados();
        }

        private void CarregarEstados()
        {
            string sql = "SELECT ESTADO_ID, ESTADO, SIGLA FROM ESTADO ORDER BY ESTADO";
            dgEstado.DataSource = BD.Buscar(sql);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Geral.ValidaCampos(panelEstado, errorProvider1))
                return;

            string[] v = new string[3];
            v[0] = txtIdEstado.Text;
            v[1] = txtEstado.Text;
            v[2] = txtSigla.Text;

            txtIdEstado.Text = BD.ExecutarProcedure("ESTADO_SALVAR", v, "Estado ");

            CarregarEstados();
            LimparEstado();
        }

        private void txtEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter || e.KeyCode==Keys.Tab)
            {
                txtSigla.Focus();
            }
        }

        private void frmCadEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void dgEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.E)
            {
                txtIdEstado.Text = dgEstado.CurrentRow.Cells["ESTADO_ID"].Value.ToString();
                txtEstado.Text = dgEstado.CurrentRow.Cells["ESTADO"].Value.ToString();
                txtSigla.Text = dgEstado.CurrentRow.Cells["SIGLA"].Value.ToString();

                dgEstado.Enabled = false;
                btnNovo.Visible = true;
                btnSalvar.Text = "Editar";
                btnSalvar.BackColor = Color.SteelBlue;
            }
        }

        private void LimparEstado()
        {
            txtIdEstado.Text = "";
            txtEstado.Text = "";
            txtSigla.Text = "";

            dgEstado.Enabled = true;
            btnNovo.Visible = false;
            btnSalvar.Text = "Salvar";
            btnSalvar.BackColor = Color.Green;

            txtEstado.Focus();
        }

        private void btnNovoContato_Click(object sender, EventArgs e)
        {
            LimparEstado();
        }
    }
}
