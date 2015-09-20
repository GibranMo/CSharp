//Gibran Morales 008959470
//cmpe 137
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1 = 0, num2 = 0, result = 0, MS =0;
        bool MSFlag = false;
        string operation;

        ///-
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font("Arial", 12, FontStyle.Bold);
            textBox1.Cursor = Cursors.Arrow;
        }
        //MS = the function in calculator where a number is stored in memory for later use
        private void MSClick(object sender, EventArgs e)
        {
            MS = Convert.ToDouble(this.textBox1.Text);
            this.textBox1.Text = String.Empty;
            MSFlag = true;
            
        }
        //'M+' :  If the calculator is showing 3 in textbox1, then it adss 3 + whatever is in MS and
        //stores it in MS. ALl textboxes are cleared
        private void MPlusClick(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(this.textBox1.Text);
            MS = MS + num1;
            this.textBox1.Text = String.Empty;
            num1 = num2 = result = 0;
        }
        //'MR' = the Enter key but uses the value stored in MS
        private void MRClick(object sender, EventArgs e)
        {
            string MSstring = MS.ToString();
            this.textBox1.Text = MSstring;
           
        }
        private void ModClick(object sender, EventArgs e)
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

      
        private void PL_Click(object sender, EventArgs e)
        {
           // if (isThereTextInBox(sender, e) == true)
             //   this.textBox1.Text = String.Empty;

            
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

                DialogResult r;
                r = MessageBox.Show("Error: Can only handle one operation at a time!");
                //r = MessageBox.Show("ERROR**: ", error.Message);
                buttonC_Click(sender, e);
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty)
            
            try
            {
                operation = "-";
                num1 = System.Convert.ToDouble(this.textBox1.Text);
                this.textBox2.Text = this.textBox1.Text + "−";
                this.textBox1.Text = String.Empty;
            }
            catch (FormatException  ex)
            {
                DialogResult r;
                r = MessageBox.Show(ex.Message + " Please enter a number");
                buttonC_Click(sender, e);
            }
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {          
             operation = "/";
             num1 = System.Convert.ToDouble(this.textBox1.Text);
             this.textBox2.Text = this.textBox1.Text + "/";
             this.textBox1.Text = String.Empty;
        }
        private void buttonMul_Click(object sender, EventArgs e)
        {
            operation = "*";
            num1 = System.Convert.ToDouble(this.textBox1.Text);
            this.textBox2.Text = this.textBox1.Text + "*";
            this.textBox1.Text = String.Empty;
        }

        private void buttonDecPointClick(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + ".";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = "";

            this.textBox1.Text = this.textBox1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;

            this.textBox1.Text = this.textBox1.Text +  "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (isThereTextInBox(sender, e) == true)
                this.textBox1.Text = String.Empty;
            
            this.textBox1.Text = this.textBox1.Text + "0";
            //num1 = num2 = result = 0;
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Empty;
            this.textBox2.Text = String.Empty;
            num1 = num2 = result = MS = 0;
        }
        //Enter key
        private void buttonResult_Click(object sender, EventArgs e)
        {
            
            num2 = System.Convert.ToDouble(this.textBox1.Text);
            this.textBox2.Text = "";

            calculate(operation);

        }
        public void calculate(string op)
        {
            switch (op)
            {
                case "+": result = num2 + num1;
                    textBox1.Text = result.ToString(); break;

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
                            DialogResult r;
                            r = MessageBox.Show("Error: can only handle one operation at a time! ");
                            //buttonC_Click(sender, e);
                        }break;
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
                            //MessageBox.Show(ex.Message);
                            DialogResult r;
                            r = MessageBox.Show("Error: can only handle one operation at a time! ");
                            //buttonC_Click(sender, e);
                        } break;
                    }
                case "-": result = num1 - num2;
                            textBox1.Text = result.ToString();break;

                case "%": result = num1 % num2;
                    textBox1.Text = result.ToString();break; 
                  
            }
            num1 = result= num2 = 0;
        }

        double safeDivision (double a, double b )
        {
            try
            {
                double ans = a / b;
                
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show(e.Message);
            }
            return a / b;

            
        }

        
        
        
       
       

    }
}
