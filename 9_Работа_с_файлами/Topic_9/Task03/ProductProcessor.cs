using System;
namespace Task03
{
    public class ProductProcessor
    {
        public List<Product> products;

        public ProductProcessor(List<Product> products)
        {
            this.products = products;
        }

        public void SortByPrice(bool ascending)
        {
            if (ascending)
            {
                products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));
            }
            else
            {
                products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));
            }
        }
    }
}

