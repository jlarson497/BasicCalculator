using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Calculator
    {
        public string CurrentValue{get; set;}
        public string Operand1{get; set;}
        public string Operand2 {get; set;}
        public char Operator {get; set;}

        public Calculator()
        {
        }

        public void Add()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("+");
            CurrentValue = "";
        }

        public void Subtract()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("-");
            CurrentValue = "";
        }

        public void Multiply()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("*");
            CurrentValue = "";
        }

        public void Divide()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("/");
            CurrentValue = "";
        }

        public decimal Reciprocal()
        {
            Operand1 = CurrentValue;
            decimal numOp1 = Convert.ToDecimal(Operand1);
            decimal result = 1 / numOp1;
            return result;
        }

        public double SquareRoot()
        {
            Operand1 = CurrentValue;
            double numOp1 = Convert.ToDouble(Operand1);
            double result = Math.Sqrt(numOp1);
            return result;

        }
        public decimal Equals(string operand1, string operand2, char currentOperator)
        {

            decimal numOperand1 = Convert.ToDecimal(operand1);
            decimal numOperand2 = Convert.ToDecimal(operand2);
            decimal result = 0m;


            switch (currentOperator)
            {
                case '+':
                    result = numOperand1 + numOperand2;
                    break;
                case '-':
                    result = numOperand1 - numOperand2;
                    break;
                case '*':
                    result = numOperand1 * numOperand2;
                    break;
                case '/':
                    result = numOperand1 / numOperand2;
                    break;
            }


            return result;
        }

        public void CurrentNumberBuilder(string nextNumber)
        {
            CurrentValue += nextNumber;
        }

        public void Back()
        {
            if (CurrentValue.Length > 0)
            {
                CurrentValue = CurrentValue.Remove(CurrentValue.Length - 1);
            }
            else
            {
                CurrentValue = "";
            }
        }

        public void Clear()
        {
            CurrentValue = "";
            Operand1 = "";
            Operand2 = "";
            Operator = ' ';
        }
    }
}
