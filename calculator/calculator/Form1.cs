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
            double firValue = Convert.ToDouble(firstValue.Text);
            double secValue = Convert.ToDouble(secondValue.Text);
            double result;
            switch (((Button) sender).Name)
            {
                 case "Plus":
                 {
                   
                    result = firValue + secValue;
                   
                    break;
                 }

                 case "Minus":
                 { result = firValue - secValue;
                     break;
                 }

                 case "Multiply":
                 { result = firValue * secValue;
                     break;
                 }

                 case "Divide":
                 { result = firValue / secValue;
                     break;
                 }

                default:
                    throw new Exception("Неизвестная операция");
            }

            Result.Text = result.ToString();
        }
    }
}
