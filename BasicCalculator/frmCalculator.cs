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

        //This region contains the code for all the number buttons
        //It is all the same and should be pretty self documenting
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

        //This region contains the code for the 4 major operators
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

        //handler for equals button
        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                decimal result = calculator.Equals(calculator.Operand1, calculator.CurrentValue, calculator.Operator);
                txtEntryViewer.Text = Convert.ToString(result);
                calculator.Operand1 = txtEntryViewer.Text;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }


        //handler for back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            calculator.Back();
            UpdateCurrentEntry();
        }

        //handler for clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtEntryViewer.Clear();
        }

        //handler for reciprocal
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try
            {
                txtEntryViewer.Text = Convert.ToString(calculator.Reciprocal());
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
        //handler for sqrt button
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtEntryViewer.Text = Convert.ToString(calculator.SquareRoot());
        }
        //handler for plus/minus button
        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            txtEntryViewer.Clear();
            calculator.PlusMinus();
            UpdateCurrentEntry();
        }











    }
}
