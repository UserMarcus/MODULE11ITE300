using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product("Ariel",2,"Sachet",7.50,2);
            Console.WriteLine("Item: " + product.name);
            Console.WriteLine("Quantity: " + product.quantity);
            Console.WriteLine("Unit: " + product.unit);
            Console.WriteLine("Price: " + product.price);
            Console.WriteLine("Amount: " + product.amount);
            Console.ReadLine();
        }
    }


}
