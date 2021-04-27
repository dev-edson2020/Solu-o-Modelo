using System;
using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class cbCombo : ComboBox
    {
        protected override void OnCreateControl()
        {
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            base.OnCreateControl();
        }

        protected override void OnGotFocus(EventArgs e)
        {
            this.BackColor = Color.SkyBlue;
            this.SelectAll();
            base.OnGotFocus(e);
        }

        protected override void OnLostFocus(EventArgs e)
        {
            this.BackColor = Color.White;
            base.OnLostFocus(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\u001b")
                this.Text = "";

            base.OnKeyPress(e);
        }
    }
}
