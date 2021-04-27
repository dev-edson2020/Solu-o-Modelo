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
            if (this.Text != "")
            {
                string valor = this.Text;
                valor = valor.Replace("R$", "");
                valor = valor.Replace(".", "");
                valor = valor.Trim();

                this.Text = Convert.ToDouble(valor).ToString("c");
            }

            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b")
                this.Text = "";

            if (e.KeyChar.ToString() == "\b")
                return;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if (e.KeyChar == ',' && this.Text.Contains(","))
                e.Handled = true;

            base.OnKeyPress(e);
        }
    }
}
