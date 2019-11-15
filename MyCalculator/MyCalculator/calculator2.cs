using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Media;

namespace MyCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //Num1.Click +=new EventHandler(Num1_Click);
        }
        //hold my operand
        Double value1, value, value2, mathvalue;
        //hold the operaters input
        char value3;
        //Double calcu = value1 + value2;
        //if and else statement
        bool Decimal = false;
        bool input = true;
       // bool NonNumberEntered = false;





        private void Num1_Click(object sender, EventArgs e)
        {
            //Button Num1 = (Button)sender;
            //if (Char.IsDigit(Num1.Text, 1))
            //{
            //    output1.Text += Num1.Text;
            //}
            //this.output1.Text = "";
            if (input)
            {
                
                output1.Text += Num1.Text;
            }
            else
            {
                output1.Text = Num1.Text;
            }
            input = true;
            //NonNumberEntered = false;

            //this.output1.Text += output1;
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num2.Text;
            }
            else
            {
                output1.Text = Num2.Text;

            }
            input = true;
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num3.Text;
            }
            else
            {
                output1.Text = Num3.Text;
            }
            input = true;
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num4.Text;
            }
            else
            {
                output1.Text = Num4.Text;
            }
            input = true;
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num5.Text;
            }
            else
            {
                output1.Text = Num5.Text;
            }
            input = true;
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num6.Text;
            }
            else
            {
                output1.Text = Num6.Text;
            }
            input = true;
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num7.Text;
            }
            else
            {
                output1.Text = Num7.Text;
            }
            input = true;
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num8.Text;
            }
            else
            {
                output1.Text = Num8.Text;
            }
            input = true;
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            if (input)
            {
                output1.Text += Num9.Text;
            }
            else
            {
                output1.Text = Num9.Text;
            }
            input = true;

        }

        private void Num0_Click(object sender, EventArgs e)
        {
            if (input)
            {
                if (output1.Text.Length >= 1)
                {
                    output1.Text += Num0.Text;
                }
                else
                {
                    output1.Text = "0.";
                }
                
            }
            else
            {
                output1.Text = Num0.Text;
                //input = true;
            }
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //System.Diagnostics.Process.Start("www.google.com");//linkbutton code
            //System.Diagnostics.Process.Start("notepad++");

        }



        private void Fun1_Click(object sender, EventArgs e)
        {
            
            string forth;
            int log;
            if (output1.Text.Length > 0)
            {
                forth = output1.Text.Substring(output1.Text.Length - 1);
                if (forth == "")
                {
                    Decimal = false;


                }
                else
                {
                    log = output1.Text.Length;
                    output1.Text = output1.Text.Remove(log - 1, 1);
                }
            }
            else
            {
                if (output1.Text.Length !=value)
                {
                    //System.Media.SystemSound play =new System.Media.SystemSound
                   // output1.Text = System.Media.SystemSound.play();

 
                }
            }

            //this.output1.Text = "";
            // this.output = string.Empty;
            //this.value1 = 0;
            // this.value2 = string.Empty;
        }

        private void Fun13_Click(object sender, EventArgs e)
        {
            this.output1.Text = "";//clear all on the outbox
            value1 = 0;
            value2 = 0;
            value3 ='0';
            Decimal = false;

            this.input = false;
        }

        private void Num10_Click(object sender, EventArgs e)
        {
            if (input)
            {
                if (!Decimal)//is there no decimal allready
                {
                    if (output1.Text.Length != 0)//check if not equal to zero
                        //check if the last digit is not equalto operand note
                        if (output1.Text != "0") //make sure zerro is not the first number
                        {
                            output1.Text += ".";
                            
                        }
                    
                }
                input = true;
                Decimal = true;

               
            }
            else
            {
                output1.Text = "0.";
            }
            input = true;
            Decimal = true;
        }
        

        private void Fun2_Click(object sender, EventArgs e)
        {
            if (output1.Text.Length != 0) //dose my output box has any value
            {
                value1 = System.Double.Parse(output1.Text);
                output1.Text += "+";
                value3 = '+';
            }
           

            input = false;
            Decimal = false;
                
            
        
        }

        private void fun3_Click_1(object sender, EventArgs e)
        {
            if (output1.Text.Length != 0)
            {
                if (output1.Text != "-")
                {
                    //if (value3==)
                        value1 = System.Double.Parse(output1.Text);
                    output1.Text += "-";
                }
            }
            else 
            {
                equalto();
            }
            value3 = '-';
            Decimal = false;
            input = false;


        }

        private void fun4_Click_1(object sender, EventArgs e)
        {
            if (output1.Text.Length != 0)
            {
                //if (value3 == "")
                    value1 = System.Double.Parse(output1.Text);
                output1.Text = "/";
            }
            else
            {
                equalto();
            }
            {
                value3 = '/';
            }
            Decimal = false;
            input = false;
        }

        private void fun5_Click_1(object sender, EventArgs e)
        {
            if (output1.Text.Length != 0)
            {
                //if (value3 == "")
                    value1 = System.Double.Parse(output1.Text);
                output1.Text = "*";
            }
            else
            {
                equalto();
            }
            {
                value3 = '*';
            }
            Decimal = false;
            input = false;
        }

        private void Fun11_Click(object sender, EventArgs e)
        {
            if (output1.Text.Length != 0)
            {
                //if (value3='0')
                    value1 = System.Double.Parse(output1.Text);
                    output1.Text = "^";
                    //value1 = System.Math.Pow(value1,value2);
                
            }
            else
            {
                equalto();
            }
            {
                value3 = '^';
            }
            Decimal = false;
            input = false;

        
        
        }

        private void equalto()
        {
            
            //Double value2 = Double.PositiveInfinity;
            value2 = System.Double.Parse(output1.Text); ///System.Double.Parse(output1.Text);
            switch (value3) //?:Equalto==""
            {   
                case '+':
                     value =value1 + value2;
                     break;
                case'-':
                    value = value1 - value2;
                    break;
                case'*':
                    value=value1*value2;
                    break;
                case'/':
                    value = value1 / value2;
                    break;
                case'^':
                    value = System.Math.Pow(value1, value2);
                    break;
            }
            output1.Text = value.ToString();
            input = false;

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quite this Calculator", "Exit",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Equal1_Click(object sender, EventArgs e)
        {
            ////if (e.Code  == Keys.Enter)
            //{
            //    Keys.Enter = equalto;
            //}
            //else if (e.Code == Keys.Enter)
            {
                equalto();
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (output1.Text.Length != 0)
            {
                mathvalue = System.Double.Parse(output1.Text);
                mathvalue = System.Math.Sqrt(mathvalue);

                output1.Text = mathvalue.ToString();

                Decimal = false;
                input = false;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Fun12_Click(object sender, EventArgs e)
        {
            if (output1.Text.Length != 0)
            {           
                    value1= 1 / Convert.ToDouble(output1.Text);
                    output1.Text=value1.ToString();
                               
            }
            else
            {
                //value=1 / value;
                output1.Text = value.ToString();
            }
            Decimal = false;
            input = false;
        }

        private void Fun14_Click(object sender, EventArgs e)
        {
            
            if (output1.Text.Length != 0)
            {           
                    value1=Convert.ToDouble(output1.Text) / 100;
                    output1.Text=value1.ToString();
                               
            }
            else
            {
                //value=1 / value;
                output1.Text = value.ToString();
            }
            Decimal = false;
            input = false;
        }

        private void output1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& e.KeyChar != (char)Keys.Back && e.KeyChar != '.' && e.KeyChar !='+' && e.KeyChar!='-' && e.KeyChar !='*' && e.KeyChar !='/' && e.KeyChar !='<' && e.KeyChar !='>' && e.KeyChar !='(' && e.KeyChar !=')')
            {
                e.Handled = true;
            }
            input = false;
            Decimal = false;
        }

       

       
    }


}

       



    




