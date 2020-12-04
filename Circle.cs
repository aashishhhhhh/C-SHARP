using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    class Circle : Interface1
    {
        public void drawShape(string[] res, Color color, Graphics g, int a, int b)
        {
            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[1]);
            Pen p = new Pen(color, 2);
            g.DrawEllipse(p, a, b, c, d);
        }

        public void fill(string[] res, Color color, Graphics g, int a, int b)
        {
            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[1]);
            SolidBrush brush = new SolidBrush(color);
            g.FillEllipse(brush, a, b, c, d);
        }
    }
}
