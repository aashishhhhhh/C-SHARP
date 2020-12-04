using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{

    class DrawTo : Interface1
    {
        public void drawShape(string[] res, Color color, Graphics g, int k, int l)
        {
            int a = Convert.ToInt32(res[1]);
            int b = Convert.ToInt32(res[2]);
            Pen p = new Pen(color, 2);
            g.DrawLine(p, k, l, a, b);
        }

        public void fill(string[] res, Color color, Graphics g, int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
