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
            double firsrValue = Convert.ToDouble(firstValue.Text);
            double seconddValue = Convert.ToDouble(secondValue.Text);
            ICalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result = calculator.Calculate(firsrValue, seconddValue);


            Result.Text = result.ToString();
        }
    }
}
