using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    /// <summary>
    /// This class does all the function requred to draw a rectangle
    /// </summary>
    class Triangle : Interface1
    {

        /// <summary>
        /// This method drawShape is defined 
        /// </summary>
        /// <param name="res"> parameter to pass message from input</param>
        /// <param name="color">parameter to choose color</param>
        /// <param name="g">parameter to call graphics</param>
        /// <param name="k"> parameter for x axis</param>
        /// <param name="l">parameter for y axis</param>
        public void drawShape(string[] res, Color color, Graphics g, int k, int l)
        {
            int point2 = 0;
            int temps = 0;
            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[2]);
            int e = Convert.ToInt32(res[3]);

            // statements to draw  a triangle
            if (c + d > e && c + e > d && d + e > c)
            {


                if (d > c)
                {
                    if (e > d)
                    {
                        temps = e;
                        e = c;
                        c = temps;

                    }
                    else
                    {
                        temps = d;
                        d = c;
                        c = temps;
                    }
                }
                if (e > c)
                {
                    temps = e;
                    e = c;
                    c = temps;

                }
                double s = (c + d + e) / 2;
                double area = Math.Sqrt(s * (s - c) * (s - d) * (s - e));
                double h = 2 * area / c;
                double point = (h * h) - (d * d);
                int h2 = Convert.ToInt32(h);
                if (point < 0)
                {
                    point *= (-1);
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);

                }
                else
                {
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);
                }




                Point[] points = new Point[3];
                points[0] = new Point(k, l);
                points[1] = new Point(k, c + l);
                points[2] = new Point(h2 + k, point2 + l);

                Pen p = new Pen(color, 2);
                g.DrawLine(p, points[0], points[1]);
                g.DrawLine(p, points[1], points[2]);
                g.DrawLine(p, points[0], points[2]);


            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not a valid triangle");

            }
        }

        public void fill(string[] res, Color color, Graphics g, int k, int l)
        {
            int point2 = 0;
            int temps = 0;
            int c = Convert.ToInt32(res[1]);
            int d = Convert.ToInt32(res[2]);
            int e = Convert.ToInt32(res[3]);
            if (c + d > e && c + e > d && d + e > c)
            {


                if (d > c)
                {
                    if (e > d)
                    {
                        temps = e;
                        e = c;
                        c = temps;

                    }
                    else
                    {
                        temps = d;
                        d = c;
                        c = temps;
                    }
                }
                if (e > c)
                {
                    temps = e;
                    e = c;
                    c = temps;

                }
                double s = (c + d + e) / 2;
                double area = Math.Sqrt(s * (s - c) * (s - d) * (s - e));
                double h = 2 * area / c;
                double point = (h * h) - (d * d);
                int h2 = Convert.ToInt32(h);
                if (point < 0)
                {
                    point *= (-1);
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);

                }
                else
                {
                    double temp = Math.Sqrt(point);

                    point2 = Convert.ToInt32(temp);
                }

                Point[] points = new Point[3];
                points[0] = new Point(k, l);
                points[1] = new Point(k, c + l);
                points[2] = new Point(h2 + k, point2 + l);
                SolidBrush brush = new SolidBrush(color);

                g.FillPolygon(brush, points);



            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Not a valid triangle");

            }



        }
    }
}

// end of code