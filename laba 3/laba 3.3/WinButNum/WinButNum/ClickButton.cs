using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ClickButton : Button
{
    int mClicks = 0;

    public int Clicks
    {
        get { return mClicks; }
    }

    protected override void OnClick(EventArgs e)
    {
        mClicks++;
        base.OnClick(e);
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        Graphics g = pevent.Graphics;
        SizeF stringSize = g.MeasureString(Clicks.ToString(), this.Font);
        g.DrawString(Clicks.ToString(), this.Font, SystemBrushes.ControlText,
                     this.Width - stringSize.Width - 3,
                     this.Height - stringSize.Height - 3);
    }
}
