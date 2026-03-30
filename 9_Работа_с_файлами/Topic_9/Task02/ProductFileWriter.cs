using System;
namespace Task02
{
    public class ProductFileWriter
    {
        public void WriteProducts(List<Product> products)
        {
            BinaryWriter writer = new BinaryWriter(File.Open("file.data", FileMode.Create));
            foreach (Product product in products)
            {
                writer.Write(product.Name);
                writer.Write(product.Price);
                writer.Write(product.Category);
            }
            writer.Close();
        }
    }
}

