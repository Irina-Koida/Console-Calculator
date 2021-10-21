using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public static class Calc
   {
        public static double Plus(double x, double y)
        {
            return x + y;
        }

        public static double Minus(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static double Division(double x, double y)
        {
            while(y == 0)
            {
                Console.WriteLine("Error");
                return 0;
            }
            return x / y;
        }

        public static double RestOfDivide(double x, double y)
        {
            return x % y;
        }

        static public double NumInput()
        {
            string numberString = Console.ReadLine();
            bool isDoubleInput = double.TryParse(numberString, out double numberDouble);
            while (!isDoubleInput)
            {
                Console.WriteLine("Eror");
                numberString = Console.ReadLine();
                isDoubleInput = double.TryParse(numberString, out  numberDouble);
            }
            return numberDouble;
        }

        static public bool OperatorInput(out string mathOperator)
        {
            List<string> operatorsWithSecondArgument = new List<string> { "+", "-", "*", "/", "%", "^" };
            List<string> operatorsWithOneArgument = new List<string> { "sqrt", "!"};
            while (true)
            {
                mathOperator = Console.ReadLine();

                if (operatorsWithSecondArgument.Contains(mathOperator))
                {
                    return true; // ask the second number
                }
                else if (operatorsWithOneArgument.Contains(mathOperator))
                {
                    return false;
                }

                Console.WriteLine();
                Console.WriteLine("Error. Try again");
            }
        }
   }
}
