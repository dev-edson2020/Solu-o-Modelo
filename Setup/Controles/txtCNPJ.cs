
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
    }
}
