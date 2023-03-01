using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Written_Assignment
{
        
    //prime number between 1 to 100 bt num is not divisible by5 or 10
    internal class PrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prime number between 1 to 100");
            for(int i=2;i<=100;i++) 
            {
                bool isPrime = true;
                for(int j=2;j*j<=i;j++) 
                { 
                    if(i%j==0) 
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
        }
    }

    class SpyNumber 
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number :");
            int num=Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int product = 1;

            while(num> 0) 
            {
                int digit = num % 10;
                sum += digit;
                product*= digit;
                num /= 10;
            }
            if (sum == product)
            {
                Console.WriteLine("the number is spy");
            }
            else 
            {
                Console.WriteLine("the number is not spy");
            }

        }
    }

    class Trimorphic 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int cube = num * num * num;
            int temp = num;

            while(temp > 0) 
            {
                if (temp % 10 != cube % 10) 
                {
                    Console.WriteLine("The Number Is Not Trimorphic");
                    return;

                }
                temp /= 10;
                cube /= 10;
                
            }
            Console.WriteLine("The number is a trimorphic");
        }
    }

    class TwinPrime 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The First Number");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            int num2=Convert.ToInt32(Console.ReadLine());
            bool isTwinPrime=false;

            if (isPrime(num1) && isPrime(num2) && (num1 - num2 == 2) || (num2 - num1 == 2) )
                { 
                    isTwinPrime=true;
                }
            if (isTwinPrime)
            {
                Console.WriteLine(num1 + " and " + num2 + "  is Twinprime number");
            }
            else 
            {
                Console.WriteLine(num1 + " and " + num2 + "  is not Twinprime number");
            }
        }
        public static bool isPrime(int num)
        {
            if (num <= 1)
            { 
                return false; 
            }
            for (int i = 2; i <= num / 2; i++) 
            { 
                if(num%i==0) 
                {
                    return false;
                }
            }
            return true;

        }


    }

    class Series 
    {
        //2 12 36 80 150 252 
        static void Main(string[] args)
        {
            int n = 10;
            int num = 2;
            int ps = 0;  //previous number square
            for (int i = 0; i < n; i++) 
            {
                Console.WriteLine(num+" ");
                ps = num * num;
                num = num + ps + 2; // next number in the series
            }

        }
    }

    class OddEven2 
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++) 
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");

                }
                else
                {
                    int square = i * i;
                    Console.WriteLine("-"+square+" ");
                }
            }
        }
    }
    class Fibonacci 
    {
        static void Main(string[] args)
        {
            int n = 20;
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.WriteLine(num1+" "+num2+" ");

            for (int i = 2; i < n; i++) 
            { 
                num3=num1+ num2;

                Console.WriteLine(num3);

                num1 = num2;
                num2 = num3;

            }
        }
    }

    class SumOfFact 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value of n ");

            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++) 
            {
                int fact = 1;
                for (int j = 1; j <= i; j++) 
                {
                    fact = fact * j;

                }
                sum+= fact;
            }
            Console.WriteLine(n+"  "+sum);
        }
    }
    class Pattern1 
    {
        static void Main(string[] args)
        {
            for (int i = 5; i <= 1; i--) 
            {
                for (int j = 5; j >= i; j--) 
                {
                    Console.Write(" ");
                }
                for (int k = 1; k < (i * 2); k++) 
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }

}
