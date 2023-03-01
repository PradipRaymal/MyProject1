using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Oop
{
    internal class Car
    {
        string cName = "Toyota";
        string cModel = "Fortuner 4X4";
        string cColor = "Black";
        double cPrice = 5000000;
        static void Main(string[] args)
        {
            Car cr= new Car();
            Console.WriteLine(cr.cName);
            Console.WriteLine(cr.cModel);   
            Console.WriteLine(cr.cColor);
            Console.WriteLine(cr.cPrice);
        }

    }

    //1) Write code to create product class product has Product name ,product price and quantity
    //Assign value to product details and display in proper way .
    //2) WC to create a method which is dispaly factors of given parameter .
    // 3) create student class student has id name three subject marks .
    //create first method to accept details for student create second method to calculate the percentage percentage for three subject and
    //third to display all the details of student with percentage

   // int n = 20; // Change this to any number you want to find the factors of
    //Console.WriteLine("Factors of " + n + ":");
      //  for (int i = 1; i <= n; i++) {
        //    if (n % i == 0) {
          //      Console.Write(i + " ");



}

