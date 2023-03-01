using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.WhileLoop
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int num = 35;
            while (num <= 50)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }
        }
    }

    class Class2 
    {
        static void Main(string[] args)
        {
            //odd number between 20 to 50
            int num = 21;
            int count = 0;

            while (num <= 50) 
            {
                count++;
                num += 2;
            }

            Console.WriteLine("count is "+count);
        }
    }

    class Class3 
    {
        static void Main(string[] args)
        {
            int num = 5;
            int i = 1;

            while (i >= 10)
            {
                Console.WriteLine( num+i);
                i++;
            }
        }
    }
    class Class4

    {
        static void Main(string[] args)
        {
            int num = 320;
            while (num >= 225) 
            
            {
                Console.WriteLine(num);
                num--;
            }
        }
    }


}

