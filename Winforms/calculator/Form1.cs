using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14._04._2021
{
    public partial class Form1 : Form
    {

        double rezultat = 0;
        string operatie_reusita = "";
        bool is_op_reusita = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            switch (operatie_reusita)
            {
                case "+": textBox1.Text = (rezultat + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (rezultat - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (rezultat * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (rezultat / Double.Parse(textBox1.Text)).ToString();
                    break;
            }
            rezultat = Double.Parse(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (rezultat != 0)
            {
                button19.PerformClick();
                operatie_reusita = button.Text;
                is_op_reusita = true;

            }
            else
            {
                operatie_reusita = button.Text;
                rezultat = double.Parse(textBox1.Text);
                is_op_reusita = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || is_op_reusita) textBox1.Clear();
            is_op_reusita = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains(".")) textBox1.Text = textBox1.Text + button.Text;
            }
            else textBox1.Text = textBox1.Text + button.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            is_op_reusita = false;
            operatie_reusita = "";
            rezultat = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            is_op_reusita = false;
            operatie_reusita = "";
            rezultat = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
