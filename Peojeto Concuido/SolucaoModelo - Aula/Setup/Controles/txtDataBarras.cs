using System;
using System.Drawing;
using System.Windows.Forms;

namespace Setup.Controles
{
    public class txtDataBarras : txt
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

                if (t == 10)
                    e.Handled = true;

                if (t == 2 || t == 5)
                    this.Text = this.Text + "/";

                this.SelectionStart = this.Text.Length;
            }
            else
                e.Handled = true;

            base.OnKeyPress(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;

            if (this.Text.Trim() == "")
                return;

            string dataDigitada = this.Text;

            try
            {
                DateTime data = Convert.ToDateTime(this.Text);
                this.Text = data.ToShortDateString();
            }
            catch
            {
                this.Text = "";
                Geral.Erro("Data inválida!\r\n\r\nData Informada: " + dataDigitada);
            }

            base.OnLostFocus(e);
        }

    }
}
