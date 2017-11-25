using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalculator
{
    public class RPNCal
    {
        public int? GetRPN(string inputString)
        {
            if (!ValidateInputString(inputString)) return null;

            // "2,4,15,5,^"
            var values = inputString.Split(',');
            int[] numbers = new int[100];


            int number;
            int i = 0;
            foreach (string value in values) {
                if (int.TryParse(value, out number)) {
                    numbers[i] = number;
                    i++;
                }
                else
                {
                    var result = ApplyOperation(numbers[i - 2], numbers[i - 1], value);
                    if (result == null)
                    {
                        numbers[i - 2] = (int)result;
                        numbers[i - 1] = 0;
                    }
                    else {
                        return result;
                    }
                    
                }

            }

            int total = 0;
            for (int j = 0; j < numbers.Length; j++) {
                total = total + numbers[j];
            }

            return total;
        }

        private int? ApplyOperation(int value1, int value2, string operation)
        {
            int? returnValue = null;
            if (operation == "+")
            {
                returnValue = value2+ value1;
            }
            else if (operation == "-")
            {
                returnValue = value1 - value2;
            }
            else if (operation == "%")
            {
                returnValue = value1 / value2 * 100;
            }

            else if (operation == "^")
            {
                int power = 1;
                int max = value2;
                for (int k = 0; k <= max; k++)
                {
                    power *= value1;

                }
                returnValue = power;
            }
            return returnValue;
        }




        private bool ValidateInputString(string inputString) {

            string[] operators = @"+,-,%,^,!".Split(',');
            bool isValid = true;
            bool containsOperator = false;

            if (string.IsNullOrWhiteSpace(inputString)) isValid = false;
            if (inputString.IndexOf(",") == -1) isValid = false;

            foreach (string op in operators) {
                if (inputString.Contains(op)) containsOperator = true;
            }

            if (!containsOperator) { return false; }
            


            return isValid;


        }

    }
}
