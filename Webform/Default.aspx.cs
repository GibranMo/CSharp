/* *Default.aspx.cs
 * Gibran Morales
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        double num1, num2, result = 0, MS = 0;
        bool MSFlag = false;
        string operation ="";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //MS = the function in calculator where a number is stored in memory for later use
        protected void MSClick(object sender, EventArgs e)
        {
            MS = Convert.ToDouble(this.textBox1.Text);
            this.textBox1.Text = String.Empty;
            MSFlag = true;

        }
        //'M+' :  If the calculator is showing 3 in Textbox1, then it adss 3 + whatever is in MS and
        //stores it in MS. ALl textboxes are cleared
        protected void MPlusClick(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(this.textBox1.Text);
            MS = MS + num1;
            this.textBox1.Text = String.Empty;
            num1 = num2 = result = 0;
        }
        //'MR' = the Enter key but uses the value stored in MS
        protected void MRClick(object sender, EventArgs e)
        {
            string MSstring = MS.ToString();
            this.textBox1.Text = MSstring;

        }
        protected void ModClick(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(this.textBox1.Text);
            operation = "%";
            this.textBox2.Text = this.textBox1.Text + "%";
            this.textBox1.Text = String.Empty;

        }

        private bool isThereTextInBox(object sender, EventArgs e)
        {
            if (this.textBox2.Text == String.Empty)
                return true;
            else
                return false;

        }


        protected void PL_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (this.textBox2.Text != String.Empty)
                    throw new System.Exception();

                num1 = System.Convert.ToDouble(this.textBox1.Text);
                operation = "+";
                this.textBox2.Text = this.textBox1.Text + "+";
                this.textBox1.Text = String.Empty;
            }
            catch (Exception error)
            {

                Response.Write("<h2> can only handle one op. at a time 1 <</h2>\n");
                buttonC_Click(sender, e);
            }
        }

        protected void buttonSub_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)

                try
                {
                    operation = "-";
                    num1 = System.Convert.ToDouble(this.textBox1.Text);
                    this.textBox2.Text = this.textBox1.Text + "−";
                    this.textBox1.Text = String.Empty;
                }
                catch (FormatException ex)
                {
                  

                    Response.Write("<h2> can only handle one op. at a time 2<</h2>\n");
                    
                    buttonC_Click(sender, e);
                }
        }

        protected void buttonDiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            num1 = System.Convert.ToDouble(this.textBox1.Text);
            this.textBox2.Text = this.textBox1.Text + "/";
            this.textBox1.Text = String.Empty;
        }
        protected void buttonMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = System.Convert.ToDouble(this.textBox1.Text);
            this.textBox2.Text = this.textBox1.Text + "*";
            this.textBox1.Text = String.Empty;
        }

        protected void buttonDecPointClick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + ".";
        }

        ///////////////////////////////////////////////
        protected void shit (object sender, EventArgs e)
        {
           // if (isThereTextInBox(sender, e) == true)
             //   this.textBox1.Text = "";

            this.textBox1.Text = this.textBox1.Text + "1";
        }

        protected void button2_Click(object sender, EventArgs e)
        {
           // if (isThereTextInBox(sender, e) == true)
             //   this.textBox1.Text = String.Empty;

            this.textBox1.Text = this.textBox1.Text + "2";
        }

        protected void button3_Click(object sender, EventArgs e)
        {
         
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        protected void button4_Click(object sender, EventArgs e)
        {
            
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        protected void button5_Click(object sender, EventArgs e)
        {
         
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        protected void button6_Click(object sender, EventArgs e)
        {
            //if (isThereTextInBox(sender, e) == true)
              //  this.textBox1.Text = String.Empty;

            this.textBox1.Text = this.textBox1.Text + "6";
        }
        protected void button7_Click(object sender, EventArgs e)
        {
            //if (isThereTextInBox(sender, e) == true)
              //  this.textBox1.Text = String.Empty;

            this.textBox1.Text = this.textBox1.Text + "7";
        }
        protected void button8_Click(object sender, EventArgs e)
        {
            //if (isThereTextInBox(sender, e) == true)
              //  this.textBox1.Text = String.Empty;

            textBox1.Text = this.textBox1.Text + "8";
        }

        protected void button9_Click(object sender, EventArgs e)
        {
            //if (isThereTextInBox(sender, e) == true)
              //  this.textBox1.Text = String.Empty;

            this.textBox1.Text = this.textBox1.Text + "9";
        }

        protected void button0_Click(object sender, EventArgs e)
        {
            //if (isThereTextInBox(sender, e) == true)
              //  this.textBox1.Text = String.Empty;

            this.textBox1.Text = this.textBox1.Text + "0";
            //num1 = num2 = result = 0;
        }

        protected void buttonC_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Empty;
            this.textBox2.Text = String.Empty;
            num1 = num2 = result = MS = 0;
        }
        //Enter key
        protected void buttonResult_Click(object sender, EventArgs e)
        {

            num2 = System.Convert.ToDouble(this.textBox1.Text);
            this.textBox2.Text = "";
            calculate(operation);

        }
        public void dummy()
        {
            this.textBox2.Text = "()";
        }

        public void calculate(string op)
        {
            

            switch (op)
            {
                case "+": result = num2 + num1;
                    this.textBox2.Text = "@";
                    this.textBox1.Text = result.ToString(); break;

                case "/":
                    {
                        //result = safeDivision(num1, num2);
                        //textBox1.Text = result.ToString(); break;

                        try
                        {
                            result = num1 / num2;
                            textBox1.Text = result.ToString();

                        }
                        catch (DivideByZeroException ex)
                        {
                            //MessageBox.Show(ex.Message);

                            //DialogResult r;
                            //r = MessageBox.Show("Error: can only handle one operation at a time! ");

                            //buttonC_Click(sender, e);
                        } break;
                    }
                case "*":
                    {
                        try
                        {
                            result = num1 * num2;
                            textBox1.Text = result.ToString();

                        }
                        catch (OverflowException ex)
                        {
                           
                            //buttonC_Click(sender, e);

                            Response.Write("<h2> can only handle one op. at a time <</h2>\n");
                        } break;
                    }
                case "-": result = num1 - num2;
                    textBox1.Text = result.ToString(); break;

                case "%": result = num1 % num2;
                    textBox1.Text = result.ToString(); break;

            }
           
            
            num1 = result = num2 = 0;
        
        
        }

        double safeDivision(double a, double b)
        {
            try
            {
                double ans = a / b;

            }
            catch (DivideByZeroException e)
            {
               // MessageBox.Show(e.Message);
                Response.Write("<h2> cannot divide by zero!<</h2>\n");

            }
            return a / b;


        }
    }
}