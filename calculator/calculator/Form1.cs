using System;
using System.Windows.Forms;
using calculator.OneArgument;
using calculator.TwoArguments;

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
            double firstArgument = Convert.ToDouble(firstValue.Text);
            double secondArgument = Convert.ToDouble(secondValue.Text);
            ICalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double result=0;
            try
            {
                result = calculator.Calculate(firstArgument, secondArgument);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK);
            }

            Result.Text = result.ToString();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            double firstArgument = Convert.ToDouble(firstValue.Text);
            IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button) sender).Name);
            double result = 0;
            try
            {
                result = calculator.Calculate(firstArgument);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK);
            }

            Result.Text = result.ToString();
        }
    }
}
