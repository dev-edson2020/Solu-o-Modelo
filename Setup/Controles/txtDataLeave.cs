using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class txtDataLeave : txt
    {
        protected override void OnCreateControl()
        {
            this.TextAlign = HorizontalAlignment.Center;
            base.OnCreateControl();
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;

            if (this.Text.Trim() == "")
                return;

            try
            {
                DateTime data = Convert.ToDateTime(this.Text);
                this.Text = data.ToShortDateString();
            }
            catch 
            {
                Geral.Erro("Data inválida!");
                this.Text = "";
            }

            base.OnLostFocus(e);
        }
    }
}
