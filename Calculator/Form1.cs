using System;
using System.Windows.Forms;

namespace claculator
{
    public partial class Equal : Form
    {
        double number1;
        double number2;
        bool oneOrTwo = true;

        public Equal()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "8";


        }

        private void button3_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "3";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "9";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + ".";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //clear

            steven.Text = "";
            textNum.Text = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            parseNum1();
            steven.Text = number1 + " +";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            parseNum1();
            steven.Text = number1 + " *";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double soltuin = 0;

            parseNum2();

            if (steven.Text.Contains("+"))
            {
                soltuin = (number1 + number2);
            }
            else if (steven.Text.Contains("-"))
            {
                soltuin = (number1 - number2);
            }
            else if (steven.Text.Contains("/"))
            {
                soltuin = (number1 / number2);
            }
            else if (steven.Text.Contains("*"))
            {
                soltuin = (number1 * number2);
            }

            steven.Text = soltuin.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "1";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "2";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "4";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textNum.Text = textNum.Text + "0";

        }


        public void parseNum1()
        {
            bool parsed = Double.TryParse(textNum.Text, out number1);

            textNum.Text = "";

        }

        public void parseNum2()
        {
            bool parsed = Double.TryParse(textNum.Text, out number2);
            textNum.Text = "";


        }

        private void button14_Click(object sender, EventArgs e)
        {
            parseNum1();
            steven.Text = number1 + " -";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            parseNum1();
            steven.Text = number1 + " /";
        }


    }
}
