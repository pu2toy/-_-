using System;
namespace Task03
{
    public class Product
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Category { get; set; }

        public Product(string name, float price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
    }
}

