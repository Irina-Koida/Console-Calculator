using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple console calculator\n");
            Console.WriteLine("Input first operand-> ");
            double firstOperand = Calc.NumInput();
            Console.WriteLine();

            Console.WriteLine("Input operator(+ - * / %): ");
            bool isSecondNeed = Calc.OperatorInput( out string mathOperator);
            double secondOperand = 0;
            if (isSecondNeed == true)
            {
                Console.WriteLine("Input second operand ->");
                secondOperand = Calc.NumInput();
                Console.WriteLine();
            }
            double result = 0;
            switch (mathOperator)
            {
                case "+":
                    result = Calc.Plus(firstOperand, secondOperand);
                    break;
                case "-":
                    result = Calc.Minus(firstOperand, secondOperand);
                    break;
                case "/":
                    result = Calc.Division(firstOperand, secondOperand);
                    break;
                case "*":
                    result = Calc.Multiply(firstOperand, secondOperand);
                    break;
                case "%":
                    result = Calc.RestOfDivide(firstOperand, secondOperand);
                    break;
                case "^":
                    result = Calc.Power(firstOperand, secondOperand);
                    break;
                case "!":
                    result = Calc.Factorial(firstOperand);
                    break;
                default:
                    Console.WriteLine("No such operator");
                    break;
            }
            Console.WriteLine($"Your result is {result}");
        }
    }
}
