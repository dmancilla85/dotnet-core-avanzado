using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace json
{
    enum Category{
        Food,
        Technology
    }
    class Product{
        public int Id{get;set;}
        public string Name {get;set;}
        public decimal Price{get;set;}
        public Category Category{get;set;}
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            var products = new List<Product>();
            products.Add(new Product(){ Id = 1, Name = "Chocolate", Price = 2, Category = Category.Food});
            products.Add(new Product(){ Id = 2, Name = "Mouse", Price = 10, Category = Category.Technology});
            var result = JsonSerializer.Serialize(products);
            Console.WriteLine(result);

            var deserializedProducts = JsonSerializer
                .Deserialize<IEnumerable<Product>>(result);

            using var stream = File.OpenRead("VolcanoData.json");
            var doc = await JsonDocument.ParseAsync(stream);

            Console.WriteLine(doc.RootElement);
            return;
        }
    }
}
