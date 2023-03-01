using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Oop
{
    internal class Employee
    {
        int id = 101;
        string name = "deep";
        double sal = 50000;
        static void Main(string[] args)
        {
            Employee emp= new Employee();
            Console.WriteLine(emp.id);
            Console.WriteLine(emp.name);
            Console.WriteLine(emp.sal); 
        }
    }
}
