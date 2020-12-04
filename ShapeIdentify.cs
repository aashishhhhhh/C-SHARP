// importing header files
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace TASK
{
    /// <summary>
    /// This is the class which is used to describe the method to identify the shape
    /// </summary>
    class ShapeIdentify
    {
        /// <summary>
        /// This is the method which is called in class form 1 when user gives the command to draw a shape
        /// </summary>
        /// <param name="input"> passes the message from user</param>
        /// <returns></returns>
        public Interface1 getShape(String input)
        {
            {

                // this is the statement to call the rectangle class if user input is rectangle
                if (input == "rectangle")
                {
                    return new Rectangle();
                }
                // this is the statement to call the circle class if user input is circle
                else if (input == "circle")
                {
                    return new Circle();
                }
                // this is the statement to call the triangle class if user input is triangle
                else if (input == "triangle")
                {
                    return new Triangle();
                }
                // this is the statement to call the DrawTo class if user input is drawto
                else if (input == "drawto")
                {
                    return new DrawTo();
                }
                return null;
            }
        }
    }
}

// end of class
