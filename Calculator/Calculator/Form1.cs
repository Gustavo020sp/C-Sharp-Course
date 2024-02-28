//Author: Gustavo Araújo Gomes 
//Development day: 27/02/2024
//Just for fun!

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "00";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + ".";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "x";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "-";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "4";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        public string text;
        private void button1_Click(object sender, EventArgs e)
        {           
            text = textBox1.Text = textBox1.Text + "7";          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = textBox1.Text = textBox1.Text + "8";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Calculate calculate = new Calculate(text);
            calculate.DoCalculation(text);
            textBox1.Text = calculate.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}