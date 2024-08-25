using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace SecureCalculator
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        private long currentNumber;
        private long prevNumber;
        enum Operations { modulo = 1, division, multiply, minus, plus }
        Operations operation;
        bool firstOp = true;
        long Result;


        private void takeTheNumber()
        {
            if(firstOp)
            {
                prevNumber = Convert.ToInt64(tbResultScreen.Text);
                firstOp = false;
            }
            else
            {
                currentNumber = Convert.ToInt64(tbResultScreen.Text);
                calculate();
                prevNumber = Result;

            }
            tbResultScreen.Text = "";
        }
        private void calculate()
        {
            switch(operation)
            {
                case Operations.modulo:
                    Result = prevNumber % currentNumber;
                break;
                case Operations.division:
                    Result = prevNumber / currentNumber;
                break;
                case Operations.multiply:
                    Result = prevNumber * currentNumber;
                break;
                case Operations.minus:
                    Result = prevNumber - currentNumber;
                break;
                case Operations.plus:
                    Result = prevNumber + currentNumber;
                break;

            }
            
        }

        private void number_Click(object sender, EventArgs e)
        {
            if (tbResultScreen.Text.Length < 9)
            {
                tbResultScreen.Text += ((Guna2Button)sender).Tag;
            }
            else
            {
                tbResultScreen.Text = tbResultScreen.Text;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            tbResultScreen.Text = tbResultScreen.Text.Substring(0, tbResultScreen.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResultScreen.Text = "";
            prevNumber = 0;
            currentNumber = 0;
            firstOp = true;
        }

        private void btnModelus_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            operation = Operations.modulo;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            operation = Operations.division;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            operation = Operations.multiply;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            operation = Operations.minus;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            operation = Operations.plus;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            currentNumber = Convert.ToInt64(tbResultScreen.Text);
            calculate();
            tbResultScreen.Text = Result.ToString();
            firstOp = true;
        }
    }
}
