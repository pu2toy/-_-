using System;
namespace Task03
{
    public class ProductFileReader
    {
        static public List<Product> ReadProducts()
        {
            List<Product> products = new List<Product>();
            BinaryReader reader = new BinaryReader(File.Open("/Users/boga/Desktop/КПиЯП/9_Работа_с_файлами/Topic_9/Task02/bin/Debug/net6.0/file.data", FileMode.Open));
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                string name = reader.ReadString();
                float price = reader.ReadSingle();
                string category = reader.ReadString();

                products.Add(new Product(name, price, category));
            }
            reader.Close();
            return products;
        }
    }
}

