using System.Collections.Generic;
using Guna.UI2.WinForms;
namespace SecureCalculator
{
    public partial class CalculatorControl : UserControl
    {
        public CalculatorControl()
        {
            InitializeComponent();
        }

        #region CalculatorStructure
        private struct Calculator
        {
            public enum Operations { modulo = 1, division, multiply, minus, plus }
            public long FirstNumber;
            public long SecondNumber;
            public Operations operation;
            public bool firstOp = true;
            public long Result;
            public List<Calculator> Calculations = new List<Calculator>();

            public void calculate()
            {
                switch (operation)
                {
                    case Calculator.Operations.modulo:
                        Result = FirstNumber % SecondNumber;
                        break;
                    case Calculator.Operations.division:
                        Result = FirstNumber / SecondNumber;
                        break;
                    case Calculator.Operations.multiply:
                        Result = FirstNumber * SecondNumber;
                        break;
                    case Calculator.Operations.minus:
                        Result = FirstNumber - SecondNumber;
                        break;
                    case Calculator.Operations.plus:
                        Result = FirstNumber + SecondNumber;
                        break;

                }
                Calculations.Add(this);
            }

            public Calculator(){}
        };

        Calculator C1 = new Calculator();
        #endregion

        #region CalculationsHistory
        // Handel last calculations
        #endregion

        #region UiHandeling
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

        private void sign_Clicked(object sender, EventArgs e)
        {
            lb_Sign.Text = ((Guna2Button)sender).Text;
        }
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            tbResultScreen.Text = tbResultScreen.Text.Substring(0, tbResultScreen.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResultScreen.Text = "";
            C1.FirstNumber = 0;
            C1.SecondNumber = 0;
            C1.firstOp = true;
            lb_Sign.Text = lb_firstNum.Text = "";

        }

        #endregion

        #region SendingDataToCalculator
        private void takeTheNumber()
        {
            if(C1.firstOp)
            {
                lb_firstNum.Text = tbResultScreen.Text;
                C1.FirstNumber = Convert.ToInt64(tbResultScreen.Text);
                C1.firstOp = false;
            }
            else
            {
                C1.SecondNumber = Convert.ToInt64(tbResultScreen.Text);
                C1.calculate();
                C1.FirstNumber = C1.Result;
                lb_firstNum.Text = C1.Result.ToString();

            }
            tbResultScreen.Text = "";
        }
        
        private void btnModelus_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            C1.operation = Calculator.Operations.modulo;
        }

        private void btnDevide_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            C1.operation = Calculator.Operations.division;

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            C1.operation = Calculator.Operations.multiply;

        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            C1.operation = Calculator.Operations.minus;

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            takeTheNumber();
            C1.operation = Calculator.Operations.plus;

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            C1.SecondNumber= Convert.ToInt64(tbResultScreen.Text);
            C1.calculate();
            tbResultScreen.Text = C1.Result.ToString();
            C1.firstOp = true;
            lb_Sign.Text = lb_firstNum.Text = "";
        }
        #endregion

    }
}
