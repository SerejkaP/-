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
            switch (((Button) sender).Name)
            {
                 case "Plus":
                 {
                    double firValue = Convert.ToDouble(firstValue.Text);
                    double secValue = Convert.ToDouble(secondValue.Text);
                    double result = firValue + secValue;
                    Result.Text = result.ToString();
                    break;
                 }

                 case "Minus":
                 {
                     double firValue = Convert.ToDouble(firstValue.Text);
                     double secValue = Convert.ToDouble(secondValue.Text);
                     double result = firValue - secValue;
                     Result.Text = result.ToString();
                     break;
                 }

                 case "Multiply":
                 {
                     double firValue = Convert.ToDouble(firstValue.Text);
                     double secValue = Convert.ToDouble(secondValue.Text);
                     double result = firValue * secValue;
                     Result.Text = result.ToString();
                     break;
                 }

                 case "Divide":
                 {
                     double firValue = Convert.ToDouble(firstValue.Text);
                     double secValue = Convert.ToDouble(secondValue.Text);
                     double result = firValue / secValue;
                     Result.Text = result.ToString();
                     break;
                 }

                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}
