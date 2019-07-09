using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Plus_Click(object sender, EventArgs e)
        {
            double firValue = Convert.ToDouble(firstValue.Text);
            double secValue = Convert.ToDouble(secondValue.Text);
            double result = firValue + secValue;
            Result.Text = result.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            double firValue = Convert.ToDouble(firstValue.Text);
            double secValue = Convert.ToDouble(secondValue.Text);
            double result = firValue - secValue;
            Result.Text = result.ToString();
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            double firValue = Convert.ToDouble(firstValue.Text);
            double secValue = Convert.ToDouble(secondValue.Text);
            double result = firValue * secValue;
            Result.Text = result.ToString();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            double firValue = Convert.ToDouble(firstValue.Text);
            double secValue = Convert.ToDouble(secondValue.Text);
            double result = firValue / secValue;
            Result.Text = result.ToString();
        }
    }
}
