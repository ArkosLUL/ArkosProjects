using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopSystem
{
    class Product
    {
        readonly string name;
        readonly double price;
        readonly string description;

        public Product(string name, double price, string description)
        {
            this.name = name;
            this.price = price;
            this.description = description;
        }

        public override string ToString()
        {
            return string.Format($"{name}, {price}, {description}");
        }
    }
}
