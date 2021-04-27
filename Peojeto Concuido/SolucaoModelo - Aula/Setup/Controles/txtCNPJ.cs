
using System;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class txtCNPJ : txt
    {
        protected override void OnCreateControl()
        {
            this.TextAlign = HorizontalAlignment.Center;
            base.OnCreateControl();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b")
                this.Text = "";

            if (e.KeyChar.ToString() == "\b")
                return;

            if (char.IsDigit(e.KeyChar))
            {
                int t = this.Text.Length;

                if (t == 18)
                    e.Handled = true;
                
                if (t == 2 || t == 6)
                    this.Text = this.Text + ".";

                if(t == 10)
                    this.Text = this.Text + "/";
                
                if (t == 15)
                    this.Text = this.Text + "-";

                this.SelectionStart = this.Text.Length;
            }
            else
                e.Handled = true;

            base.OnKeyPress(e);
        }


        private bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            if (this.Text != "")
                if (!IsCnpj(this.Text))
                {
                    Geral.Erro("Número do CNPJ Inválido!");
                    this.Focus();
                }
            base.OnLostFocus(e);
        }

    }
}
