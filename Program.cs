using System;

namespace MathOperationsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1 – Add (+)");
            Console.WriteLine("2 – Subtract (-)");
            Console.WriteLine("3 – Multiply (*)");
            Console.WriteLine("4 – Divide (/)");
            Console.WriteLine("5 – Power (^)");
            
            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the first number:");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;
            string operation = "";

            switch (choice)
            {
                case 1:
                    result = Add(num1, num2);
                    operation = $"{num1} + {num2} = {result}";
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    operation = $"{num1} - {num2} = {result}";
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    operation = $"{num1} * {num2} = {result}";
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        result = Divide(num1, num2);
                        operation = $"{num1} / {num2} = {result}";
                    }
                    else
                    {
                        operation = "Division by zero is not allowed.";
                    }
                    break;
                case 5:
                    result = Power(num1, num2);
                    operation = $"{num1} ^ {num2} = {result}";
                    break;
                default:
                    operation = "Invalid choice.";
                    break;
            }

            Console.WriteLine(operation);
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            return a / b;
        }

        static double Power(double baseNum, double exponent)
        {
            double result = 1;
            for (int i = 0; i < (int)exponent; i++)
            {
                result = Multiply(result, baseNum);
            }
            return result;
        }
    }
}
