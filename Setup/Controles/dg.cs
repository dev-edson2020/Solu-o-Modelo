using System.Windows.Forms;
using System.Drawing;

namespace Setup.Controles
{
    public class dg : DataGridView
    {
        protected override void OnCreateControl()
        {
            this.TabStop = false;
            this.BorderStyle = BorderStyle.None;
            this.GridColor = Color.Black;
            this.RowHeadersWidth = 10;
            this.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            this.BackgroundColor = Color.White;
            this.Font = new Font("Consolas", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            base.OnCreateControl();
        }
    }
}
