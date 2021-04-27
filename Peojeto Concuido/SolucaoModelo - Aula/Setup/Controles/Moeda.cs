using System;
using System.Windows.Forms;


namespace Setup.Controles
{
    public class Moeda : txt
    {
        protected override void OnCreateControl()
        {
            this.TextAlign = HorizontalAlignment.Center;
            base.OnCreateControl();
        }

        
        protected override void OnLostFocus(EventArgs e)
        {
            try
            {
                if (this.Text.Replace(" ", "") == ",")
                {
                    this.Text = "R$ 0,00";
                    return;
                }

                if (this.Text != "")
                {
                    string valor = this.Text;
                    valor = valor.Replace("R", "").Replace("$", "");
                    valor = valor.Replace(".", "");
                    valor = valor.Trim();

                    this.Text = Convert.ToDouble(valor).ToString("c");
                }
            }
            catch (Exception)
            {
                this.Text = "";
                Geral.Erro("Valor Inválido!");
            }
            

            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b")
                this.Text = "";

            if (e.KeyChar.ToString() == "\b")
                return;

            if (this.Text.Length == 0 && e.KeyChar == ',')
            {
                this.Text = "0,";
                this.SelectionStart = this.Text.Length;
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',' && this.Text.Contains(","))
                e.Handled = true;

            base.OnKeyPress(e);
        }
    }
}
