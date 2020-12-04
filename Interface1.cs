using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    interface Interface1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="res"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void drawShape(String[] res, Color color, Graphics g, int a, int b);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="res"></param>
        /// <param name="color"></param>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        void fill(String[] res, Color color, Graphics g, int a, int b);
    }
}

