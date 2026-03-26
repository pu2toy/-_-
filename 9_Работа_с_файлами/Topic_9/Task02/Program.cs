namespace Task02
{
    class Program
    {
        public static void Main()
        {
            List<Product> products = new List<Product>
            {
                new Product("Apple", 999.9f, "Devices"),
                new Product("Ferrari", 400000f, "Car")
            };

            ProductFileWriter p = new ProductFileWriter();
            p.WriteProducts(products);
            Console.WriteLine("File successed saved");
        }
    }
}