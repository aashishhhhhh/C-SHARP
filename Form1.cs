using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TASK
{
    /// <summary>
    /// This is the name of class form1 which is inherited from form named 'form'
    /// </summary>
    public partial class Form1 : Form
    {

        int p1 = 0, p2 = 0;
        Graphics g;
        private Color color = Color.Black;
        String s;

        /// <summary>
        /// Creating constructor of class Form1
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This is the method which gives the necessary function to single command line
        /// </summary>

        public void RunProgramMethod()
        {
            try
            {
                String input = textBox1.Text;
                Validate v = new Validate();
                String[] val = v.getValidate(input, p1, p2);


                // This if statement tests if the input is moveto command and gives necessary function to it

                if (val[0] == "moveto")
                {
                    int a = Convert.ToInt32(val[1]);
                    int b = Convert.ToInt32(val[2]);
                    p1 = a;
                    p2 = b;
                }

                // This if statement tests if the input is drawto command and gives necessary function to it
                if (val[0] == "drawto")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);
                    sh.drawShape(val, color, g, p1, p2);
                }

                // This else if statement tests if the input is to draw rectangle shape and gives necessary function to it
                else if (val[0] == "rectangle")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);

                    // This if statement tests if the input is fill off  command and gives necessary function to it
                    if (s == "off")
                    {
                        sh.drawShape(val, color, g, p1, p2);
                    }

                    // This if statement tests if the input is fill on command and gives necessary function to it
                    else if (s == "on")
                    {
                        sh.fill(val, color, g, p1, p2);
                    }
                    // This else statement is the default statement if user doesnot give any input for shape
                    else
                    {
                        sh.drawShape(val, color, g, p1, p2);
                    }
                }


                // This else if statement tests if the input is circle command and gives necessary function to it
                else if (val[0] == "circle")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);

                    // same as explained on above line inside rectangle if statement
                    if (s == "off")
                    {
                        sh.drawShape(val, color, g, p1, p2);
                    }
                    else if (s == "on")
                    {
                        sh.fill(val, color, g, p1, p2);
                    }

                    else
                    {
                        sh.drawShape(val, color, g, p1, p2);
                    }
                }

                // This else if statement tests if the input is triangle command and gives necessary function to it

                else if (val[0] == "triangle")
                {
                    ShapeIdentify s1 = new ShapeIdentify();
                    Interface1 sh = s1.getShape(val[0]);
                    if (s == "off")
                    {
                        sh.drawShape(val, color, g, p1, p2);
                    }
                    else if (s == "on")
                    {
                        sh.fill(val, color, g, p1, p2);
                    }

                    else
                    {
                        sh.drawShape(val, color, g, p1, p2);
                    }



                }

                // This else if statement gives the error message if the user passes invalid command
                else if (val[0] == "error")
                {
                    System.Windows.Forms.MessageBox.Show("Error");
                }
                else
                {

                }
            }
            catch (Exception e)
            {

            }
        }


        /// <summary>
        /// This is the method which gives the necessary function to mulltiple textbox
        /// </summary>
        public void MultipleLineMethod()
        {

            try
            {
                int counter = textBox2.Lines.Length;
                for (int i = 0; i < counter; i++)
                {
                    String input = string.Format("text");
                    input = textBox2.Lines[i];
                    Validate v = new Validate();
                    String[] val = v.getValidate(input, p1, p2);


                    if (val[0] == "moveto")
                    {
                        int a = Convert.ToInt32(val[1]);
                        int b = Convert.ToInt32(val[2]);
                        p1 = a;
                        p2 = b;
                    }
                    else if (val[0] == "drawto")
                    {
                        ShapeIdentify s1 = new ShapeIdentify();
                        Interface1 sh = s1.getShape(val[0]);
                        sh.drawShape(val, color, g, p1, p2);
                    }

                    else if (val[0] == "rectangle")
                    {
                        ShapeIdentify s1 = new ShapeIdentify();
                        Interface1 sh = s1.getShape(val[0]);

                        if (s == "off")
                        {
                            sh.drawShape(val, color, g, p1, p2);
                        }
                        else if (s == "on")
                        {
                            sh.fill(val, color, g, p1, p2);
                        }

                        else
                        {
                            sh.drawShape(val, color, g, p1, p2);
                        }
                    }
                    else if (val[0] == "circle")
                    {
                        ShapeIdentify s1 = new ShapeIdentify();
                        Interface1 sh = s1.getShape(val[0]);


                        if (s == "off")
                        {
                            sh.drawShape(val, color, g, p1, p2);
                        }
                        else if (s == "on")
                        {
                            sh.fill(val, color, g, p1, p2);
                        }

                        else
                        {
                            sh.drawShape(val, color, g, p1, p2);
                        }
                    }

                    else if (val[0] == "triangle")
                    {
                        ShapeIdentify s1 = new ShapeIdentify();
                        Interface1 sh = s1.getShape(val[0]);


                        if (s == "off")
                        {
                            sh.drawShape(val, color, g, p1, p2);
                        }
                        else if (s == "on")
                        {
                            sh.fill(val, color, g, p1, p2);
                        }

                        else
                        {
                            sh.drawShape(val, color, g, p1, p2);
                        }
                    }
                    else if (val[0] == "error")
                    {
                        System.Windows.Forms.MessageBox.Show("Please enter valid value");
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception e)
            {

            }

        }




        /// <summary>
        /// This method gives necessary function to the button after user write some programs on multiple command box
        /// </summary>
        /// <param name="sender"> this is the object which raises the event of eventArgs. </param>
        /// <param name="e"> this is the parameter of event named EventArgs which passes the message </param>
        private void button1_Click(object sender, EventArgs e)
        {
            MultipleLineMethod();
        }

        /// <summary>
        /// This method gives necessary function to the button after user write command on single line command box
        /// </summary>
        /// <param name="sender"> this is the object which raises the event of eventArgs. </param>
        /// <param name="e"> this is the parameter of event named EventArgs which passes the message </param>
        private void button2_Click(object sender, EventArgs e)
        {
            RunProgramMethod();
        }



        /// <summary>
        /// This method gives necessary function to the multiple line textbox 
        /// </summary>
        /// <param name="sender"> this is the object which raises the event of eventArgs. </param>
        /// <param name="e"> this is the parameter of event named EventArgs which passes the message </param>
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // this statement gives the necessary fucntion to the pen color 
            if (textBox2.Text.ToUpper() == "PEN GREEN")
            {
                color = Color.Green;
            }
            else if (textBox2.Text.ToUpper() == "PEN PINK")
            {
                color = Color.Pink;
            }
            else if (textBox2.Text.ToUpper() == "PEN YELLOW")
            {
                color = Color.Yellow;
            }
            else if (textBox2.Text.ToUpper() == "PEN RED")
            {
                color = Color.Red;
            }

            else if (textBox2.Text.ToUpper() == "FILL ON")
            {
                s = "on";
            }
            else if (textBox2.Text.ToUpper() == "FILL OFF")
            {
                s = "off";
            }
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// This method gives necessary function to the save the program written in multiple textbox
        /// </summary>
        /// <param name="sender"> this is the object which raises the event of eventArgs. </param>
        /// <param name="e"> this is the parameter of event named EventArgs which passes the message </param>


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(saveFile.FileName));
                saveStream.Write(textBox2.Text);
                MessageBox.Show("File Saved");
                saveStream.Dispose();
            }
        }


        /// <summary>
        /// This method gives necessary function to the load the program written in multiple textbox
        /// </summary>
        /// <param name="sender"> this is the object which raises the event of eventArgs. </param>
        /// <param name="e"> this is the parameter of event named EventArgs which passes the message </param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(openFile.FileName));
                textBox2.Text = openStream.ReadToEnd();
                MessageBox.Show("File Loaded");
                openStream.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This method gives necessary function to the single line textbox 
        /// </summary>
        /// <param name="sender"> this is the object which raises the event of eventArgs. </param>
        /// <param name="e"> this is the parameter of event named EventArgs which passes the message </param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // this statement gives the necessary fucntion to the run command
            if (textBox1.Text.ToUpper() == "RUN")
            {
                button1_Click(this, new EventArgs());
            }
            // this statement gives the necessary fucntion to the clear command
            else if (textBox1.Text.ToUpper() == "CLEAR")
            {
                panel1.Refresh();
            }

            // this statement gives the necessary fucntion to the reset command
            else if (textBox1.Text.ToUpper() == "RESET")
            {
                p1 = 0;
                p2 = 0;
            }
            // this statement gives the necessary fucntion to the pen color 
            else if (textBox1.Text.ToUpper() == "PEN GREEN")
            {
                color = Color.Green;
            }
            else if (textBox1.Text.ToUpper() == "PEN PINK")
            {
                color = Color.Pink;
            }
            else if (textBox1.Text.ToUpper() == "PEN YELLOW")
            {
                color = Color.Yellow;
            }
            else if (textBox1.Text.ToUpper() == "PEN RED")
            {
                color = Color.Red;
            }

            else if (textBox1.Text.ToUpper() == "FILL ON")
            {
                s = "on";
            }
            else if (textBox1.Text.ToUpper() == "FILL OFF")
            {
                s = "off";
            }
            // this statement gives the necessary fucntion to the enter key which run the commands
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        // End of class Form1
      
       




    }
}
