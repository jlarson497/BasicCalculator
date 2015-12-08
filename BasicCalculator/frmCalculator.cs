using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }
        //Instantiate a new calculator
        //create a global variable for the current entry/ answer to be stored
        Calculator calculator = new Calculator();
        public string currentEntry = "";

        //method to update the text field with the current entry
        private void UpdateCurrentEntry()
        {
            txtEntryViewer.Text = calculator.CurrentValue;
        }

        #region NumberButtons

        private void btn1_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("1");
            UpdateCurrentEntry();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("2");
            UpdateCurrentEntry();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("3");
            UpdateCurrentEntry();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("4");
            UpdateCurrentEntry();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("5");
            UpdateCurrentEntry();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("6");
            UpdateCurrentEntry();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("7");
            UpdateCurrentEntry();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("8");
            UpdateCurrentEntry();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("9");
            UpdateCurrentEntry();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder("0");
            UpdateCurrentEntry();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            calculator.CurrentNumberBuilder(".");
            UpdateCurrentEntry();
        }
        #endregion


        #region OperatorButtons
        
        private void btnPlus_Click(object sender, EventArgs e)
        {
            calculator.Add();
            txtEntryViewer.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            calculator.Subtract();
            
            txtEntryViewer.Clear();
        }

        private void btnMulitply_Click(object sender, EventArgs e)
        {
            calculator.Multiply();
            
            txtEntryViewer.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            calculator.Divide();
            
            txtEntryViewer.Clear();
        }


        #endregion

        private void btnEqual_Click(object sender, EventArgs e)
        {
            
            decimal result = calculator.Equals(calculator.Operand1, calculator.CurrentValue, calculator.Operator);
            txtEntryViewer.Text = Convert.ToString(result);
            calculator.Operand1 = txtEntryViewer.Text;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            calculator.Back();
            UpdateCurrentEntry();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtEntryViewer.Clear();
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            txtEntryViewer.Text = Convert.ToString(calculator.Reciprocal());
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtEntryViewer.Text = Convert.ToString(calculator.SquareRoot());
        }











    }
}
