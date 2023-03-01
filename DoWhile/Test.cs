using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.DoWhile
{
    internal class Test
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int row = 4;

            for (i = 1; i <= row; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class Test2

    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int row = 4;

            for (i = 1; i <= row; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }

    class Test3

    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int row = 4;

            for (i = row; i >= 1; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    class Test4
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int row = 4;

            for (i = row; i >= 1; i--)
            {
                for (j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
    class Test5
    {
        static void Main(string[] args)
        {
            int row = 5;
            int i, j;

            for (i = 1; i >= row; i++)
            {
                for (j = 1; j >= row; j++)
                {
                    if (i == j)

                    {
                        Console.Write(" *");
                    }
                }
                Console.WriteLine("");
            }

        }
    }
    class Plus
    {
        static void Main(string[] args)
        {
            int n = 5;
            int i, j;
            for (i = 0; i <= 4; i++)
            {
                for (j = 0; j <= 4; j++)
                {
                    if (i == 2 || j == 2)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }
    }

    class Test7
    {
        static void Main(string[] args)
        {
            int num = 5;
            int i, j;

            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("O ");
                    }
                    else
                    { Console.Write("X "); }

                }
                Console.WriteLine();
            }
        }
    }
    class Test8
    ///Star N
    {
        static void Main(string[] args)
        {
            int n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (j == 1 || j == n || i == j)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }

    class Test9
    {
        static void Main(string[] args)
        {

            char i, j;

            for (i = 'A'; i <= 'D'; i++)
            {
                for (j = 'A'; j <= 'D'; j++)
                {
                    if (i == 'A' || j == 'A' || i == 'D' || j == 'D')
                    {
                        Console.Write(j);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class SumOfPrime
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 2; i <= 10; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of prime numbers between 1 and 10 is: " + sum);
        }

    }

    class TableOf1To5
    {
        static void Main(string[] args)
        {
            int table = 1;
            int result = 0;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    
                    result =  i * j;
                    Console.WriteLine(" "+result);
                }
                
               
            }
          
        }
    }

    class SumOfFactOf1to5 
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                sum += factorial;
            }
            Console.WriteLine("The sum of factorials of the numbers 1 through 5 is: " +sum);
        }
    }

}
