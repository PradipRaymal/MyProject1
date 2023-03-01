using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Oop
{
    internal class UseThis
    {
        int id;
        string name;
        double sal;
        string city;



        public UseThis() : this(01, "deep", 50000) 
        {
            Console.WriteLine("This are the details");
        }
        public UseThis(int id, string name, double sal) 
        {
            this.id = id;
            this.name = name;       
            this.sal = sal; 
        }


        public void Accept(string city)
        
        {
            this.Display();
            this.city = city;
            Console.WriteLine(city);
            
            
        }

        public void Display() 
        {
            Console.WriteLine(id+ " " + name);
            Console.WriteLine("city name is " + this.city);
        }


        static void Main(string[] args)
        {
            UseThis ut=new UseThis();
           //t.Accept("pune");
        }
    }
}
