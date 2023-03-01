using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Assignment
{
    internal class PB4to3
    {
        static void Main(string[] args) 
        {
            int count = 0;
            for (int i = 300; i <= 400; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && i > 1)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }
            Console.WriteLine($"Total prime numbers: {count}");
        }
           
        }

    class ProductOfDigitOfAnyNumber 
    
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int product = 1;
            while (number > 0)
            {
                int digit = number % 10;
                product *= digit;
                number /= 10;
            }
            Console.WriteLine("The product of the digits of the number is: "+product);
        }
    }

    class Automorphic 
    {
        static void Main(string[] args)
        {
            int num = 625;
            int square = num * num;
            int temp = 0;
            int temp2 = 0;
            int count = 2;
            int count2 = 2;
            int rem;
            int rem1;

            while (count >= 0) 
            {
                 rem = num % 10;
                temp = (temp * 10) + rem;
                num = num / 10;
                count--;
            }
            while (count2 >0) 
            {
                rem1 = square % 10;
                temp2 = (temp2 * 10) + rem1;
                square = square / 10;
                count--;

            }

            if (temp == temp2)
            {
                Console.WriteLine("automorphic");
            }
            else 
            {
                Console.WriteLine("sorry");
            }
        }
    }

    class KrishnMurti 
    {
         static void Main()
        {
            int num = 145;
            int sum = 0, temp = num, fact = 1;

            while (temp > 0)
            {
                int digit = temp % 10;

                
                fact = 1;
                for (int i = 1; i <= digit; i++)
                {
                    fact *= i;
                }

                
                sum += fact;

                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine("is a Krishnamurti number");
            }
            else
            {
                Console.WriteLine(" not a Krishnamurti number");
            }
        }
    }

    class Disarium 
    {
         static void Main()
        {
            int num = 175;
            int temp = num, count = 0, sum = 0;

            while (temp > 0)
            {
                count++;
                temp /= 10;
            }

            temp = num;
            while (temp > 0)
            {
                int digit = temp % 10;
                int product = digit;

                
                for (int i = 1; i < count; i++)
                {
                    product *= digit;
                }

                sum += product;
                count--;
                temp /= 10;
            }

            if (sum == num)
            {
                Console.WriteLine("is a Disarium number " +num);
            }
            else
            {
                Console.WriteLine("not a Disarium number " +num);
            }
        }
    }
        
    }
    


