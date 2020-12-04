// importing header files
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK
{

    /// <summary>
    /// this is the class where validation work is done
    /// </summary>
    public class Validate
    {

        /// <summary>
        /// this is the method where 
        /// </summary>
        /// <param name="a"> this is the parameter used to take input as string</param>
        /// <param name="temp1"> this is the parameter used to take the value in x axis</param>
        /// <param name="temp2"> this is the paramter used to take the value in y axis</param>
        /// <returns></returns>
        public string[] getValidate(string a, int temp1, int temp2)
        {

            string[] txt = { }; //for getting the text from input
            string[] send = a.Split(',', ' '); //  reading the input with delimeters

            {

                // this statement checks if the moveto is correct or not
                if (send[0].ToUpper() == "MOVETO")
                {
                    if (send.Length < 4)
                    {
                        int x = Convert.ToInt32(send[1]);
                        int y = Convert.ToInt32(send[2]);
                        string a1 = Convert.ToString(x);
                        string b1 = Convert.ToString(y);
                        string[] k = { "moveto", a1, b1 };
                        txt = k;
                    }
                }

                // this statement checks if the drawto command is correct or not
                else
                {
                    if (send[0].ToUpper() == "DRAWTO")
                    {
                        if (send.Length == 3)
                        {
                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string[] k = { "drawto", a1, b1 };
                            txt = k;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("For moveto please check the format ");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }

                    // this statement checks if the rectangle has correct parameters or not while input
                    else if (send[0].ToUpper() == "RECTANGLE")
                    {
                        if (send.Length == 3)
                        {
                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string[] k = { "rectangle", a1, b1 };
                            txt = k;

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please input the right value for Rectangle");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }

                    // this statement checks if the circle has correct parameters or not while input

                    else if (send[0].ToUpper() == "CIRCLE")
                    {
                        if (send.Length == 2)
                        {
                            int x = Convert.ToInt32(send[1]);
                            string a1 = Convert.ToString(x * 2);
                            string[] k = { "circle", a1 };
                            txt = k;
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please input the right value for Circle");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }

                    // this statement checks if the triangle has correct parameters or not while input
                    else if (send[0].ToUpper() == "TRIANGLE")
                    {
                        if (send.Length == 4)
                        {

                            int x = Convert.ToInt32(send[1]);
                            int y = Convert.ToInt32(send[2]);
                            int z = Convert.ToInt32(send[3]);
                            string a1 = Convert.ToString(x);
                            string b1 = Convert.ToString(y);
                            string c1 = Convert.ToString(z);
                            string[] k = { "triangle", a1, b1, c1 };
                            txt = k;

                        }

                        // this statement gives the message if the value for triangle is wrong
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Please input the right value for Triangle");
                            string[] n = { "123" };
                            txt = n;
                        }
                    }

                    // all this statement below checks if the pen color has right spelling or not
                    else if (send[0].ToUpper() == "PEN" && send[1].ToUpper() == "GREEN")
                    {

                    }
                    else if (send[0].ToUpper() == "PEN" && send[1].ToUpper() == "PINK")
                    {

                    }
                    else if (send[0].ToUpper() == "PEN" && send[1].ToUpper() == "YELLOW")
                    {

                    }
                    else if (send[0].ToUpper() == "PEN" && send[1].ToUpper() == "RED")
                    {

                    }
                    // this statement checks if the fill on is right or not
                    else if (send[0].ToUpper() == "FILL" && send[1].ToUpper() == "ON")
                    {

                    }

                    else if (send[0].ToUpper() == "FILL" && send[1].ToUpper() == "OFF")
                    {

                    }

                    else
                    {
                        string[] k = { "error" };
                        txt = k;
                    }
                }


                return txt;
            }
        }

        internal string[] getValidate(TextBox runtextbox)
        {
            throw new NotImplementedException();
        }
    }
}
