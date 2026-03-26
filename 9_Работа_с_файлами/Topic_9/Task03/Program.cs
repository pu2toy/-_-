namespace Task03
{
    class Programm
    {
        public static void Main()
        {
            List<Product> products = new List<Product>();
            products = ProductFileReader.ReadProducts();
            ProductProcessor processor = new ProductProcessor(products);
            bool ascending = true;
            processor.SortByPrice(ascending);
            products = processor.products;
            foreach (Product product in products)
            {
                Console.WriteLine("Продукт: " + product.Name + " Цена: " + product.Price +
                    " Категория: " + product.Category);
            }
        }
    }
}