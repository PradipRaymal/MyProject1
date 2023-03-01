using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyProject1.Oop
{
    internal class Product
    {

        String name;
        double price;
        double quantity;


        public void Assign(string pname, double price, double quantity) 
        {
            this.name = name;
          this.price = price;
            this.quantity = quantity;


            

            
        }

        public void Display()
        {
            Console.WriteLine(this.Bill);
            Console.WriteLine("Product Name: " + name);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Quantity: " + quantity);
        }

        public void Bill(int quantity)
        {
            int bil = 1;
            this.quantity = quantity;
            if (quantity > 0)
            {
                for (int i = 1; i <= quantity; i++)
                {
                    if (i > 1)
                    {
                        bil = bil * i;
                    }
                }
                Console.WriteLine("bill is  " + bil);
            }
            else
            {
                Console.WriteLine("Error Due to undefined Quantity");
            }
        }
        static void Main(string[] args)
        {
            // Write code to create product class product has Product name ,product price and quantity
            //Assign value to product details and display in proper way .


           


            Product p = new Product();
            p.Assign("Ashirwad",250,250);
            p.Display();

                }
}
}
