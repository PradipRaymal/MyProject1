using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Assignment
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char operation;

            do
            {
                Console.Write("Enter first number: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operation (+, -, *, /): ");
                operation = char.Parse(Console.ReadLine());

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("Result: " + result);
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("Result: " + result);
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("Result: " + result);
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: division by zero.");
                        }
                        else
                        {
                            result = num1 / num2;
                            Console.WriteLine("Result: " + result);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operation.");
                        break;
                }

                Console.Write("Do you want to perform another operation? (y/n): ");
            } while (char.Parse(Console.ReadLine()) == 'y');
        }
    }
}
