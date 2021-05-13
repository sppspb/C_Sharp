using System;

namespace Calculator_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Simple calculator program using C# switch Statement. When we run the program, the output will be:
            Enter first number: -13.11 Enter second number: 2.41 Enter operator (+, -, *, /): * -13.11 * 2.41 = -31.5951 */

          Console.WriteLine("Enter operator (+ -, *, /): ");
            String Operator = Console.ReadLine();
         Console.WriteLine("Basic Calulator");
            double num1 = -13.11, num2 = 2.41, ans;

            switch (Operator)
            {
                case "+":
                    ans = num1 + num2;
                    Console.WriteLine("Addition is : {0}", ans);
                    break;
                case "-":
                    ans = num1 - num2;
                    Console.WriteLine("Subtraction is : {0}", ans);
                    break;
                case "*":
                    ans = num1 * num2;
                    Console.WriteLine("Multiplication is : {0}", ans);
                    break;
                case "/":
                    ans = num1 / num2;
                    Console.WriteLine("Division is : {0}", ans);
                    break;
                default:
                    Console.WriteLine("Enter Valid Operator");
                    break;
            }
        }
    }
}
