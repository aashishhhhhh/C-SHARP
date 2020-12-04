using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    /// <summary>
    /// This class gives all the fucntion to rectangle shape by inherting the method of abstract interface class
    /// </summary>
    class Rectangle : Interface1
    {

        /// <summary>
        /// This method gives the function to draw the rectangle shape by calling DrawRectangle function 
        /// </summary>
        /// <param name="res">  passes the message of name of shape given by user input</param>
        /// <param name="color"> passes the name of color</param>
        /// <param name="g"> passes the variable of graphics param>
        /// <param name="a"> passes the value for x axis</param>
        /// <param name="b"> passes the value for y axis</param>
        public void drawShape(string[] res, Color color, Graphics g, int a, int b)
        {

            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[2]);
            Pen p = new Pen(color, 2);
            g.DrawRectangle(p, a, b, c, d);
        }

        /// <summary>
        /// This method gives the function to draw the rectangle shape by calling DrawRectangle function 
        /// </summary>
        /// <param name="res">  passes the message of name of shape given by user input</param>
        /// <param name="color"> passes the name of color</param>
        /// <param name="g"> passes the variable of graphics param>
        /// <param name="a"> passes the value for x axis</param>
        /// <param name="b"> passes the value for y axis</param>

        public void fill(string[] res, Color color, Graphics g, int a, int b)
        {

            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[2]);
            SolidBrush brush = new SolidBrush(color);
            g.FillRectangle(brush, a, b, c, d);
        }
    }
}
