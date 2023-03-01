using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Oop
{
    internal class Student
    {
        
        
             string id;
             string name;
             int[] marks = new int[3];

            public void AcceptDetails()
            {
                Console.Write("Enter student ID: ");
                id = Console.ReadLine();
                Console.Write("Enter student name: ");
                name = Console.ReadLine();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"Enter mark for subject {i + 1}: ");
                    marks[i] = int.Parse(Console.ReadLine());
                }
            }

            public double CalculatePercentage()
            {
                double totalMarks = 0;
                foreach (int mark in marks)
                {
                    totalMarks += mark;
                }
                double percentage = (totalMarks / 3)* 100;
                return percentage;
            }

            public void DisplayDetails()
            {
                double percentage = CalculatePercentage();
                Console.WriteLine("ID: "+id);
                Console.WriteLine("Name: "+name);
                Console.WriteLine("Marks: "+marks[0]+ " "+ marks[1] + "  "+marks[2]);
                Console.WriteLine("Percentage: "+percentage+"%");
            }


        static void Main(string[] args)
        {
            Student s=new Student();
            s.AcceptDetails();
        }
        }
}
// write code to show all the uses of this in one apllication constructor chaining ,refer variable

//in product class calculate the total bill if the quantity is >0 other wise display error msg