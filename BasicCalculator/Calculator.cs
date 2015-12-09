using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Calculator
    {
        //properties for the calculator class
        public string CurrentValue{get; set;}
        public string Operand1{get; set;}
        public string Operand2 {get; set;}
        public char Operator {get; set;}

        //empty constructor
        public Calculator()
        {
        }

        //Method for add
        public void Add()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("+");
            CurrentValue = "";
        }

        //Method for subtract
        public void Subtract()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("-");
            CurrentValue = "";
        }

        //method for multiply
        public void Multiply()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("*");
            CurrentValue = "";
        }

        //method for divide
        public void Divide()
        {
            Operand1 = CurrentValue;
            Operator = Convert.ToChar("/");
            CurrentValue = "";
        }
        
        //method for reciprocals
        public decimal Reciprocal()
        {
            Operand1 = CurrentValue;
            decimal numOp1 = Convert.ToDecimal(Operand1);
            decimal result = 1 / numOp1;
            return result;
        }

        //method for calculating squareroots
        public double SquareRoot()
        {
            Operand1 = CurrentValue;
            double numOp1 = Convert.ToDouble(Operand1);
            double result = Math.Sqrt(numOp1);
            return result;

        }

        //method for the equals button, takes two string operands and a character
        //operator, and switches based on what the operator is
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

        //method for building a string for the current entry
        public void CurrentNumberBuilder(string nextNumber)
        {
            CurrentValue += nextNumber;
        }

        //method for going back and clearing one number from the current value
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

        //Resets the properties back to default values
        public void Clear()
        {
            CurrentValue = "";
            Operand1 = "";
            Operand2 = "";
            Operator = ' ';
        }

        //Method for contolling the plus/minus key
        public void PlusMinus()
        {
            decimal numCurrentValue = Convert.ToDecimal(CurrentValue);
            numCurrentValue = numCurrentValue * -1;
            CurrentValue = Convert.ToString(numCurrentValue);
        }
    }
}
