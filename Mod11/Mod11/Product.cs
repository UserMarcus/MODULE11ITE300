using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod11
{
    class Product
    {
        public string name;
        public int quantity;
        public string unit;
        public double price;
        public int amount;

        

        public Product(string name, int quantity, string unit, double price, int amount)
        {
            this.name = name;
            this.quantity = quantity;
            this.unit = unit;
            this.price = price;
            this.amount = amount;
        }
    }
}
