using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace grpcServer
{
    public class ProductsService : curso.ProductsService.ProductsServiceBase
    {
        private readonly List<curso.Product> products = new List<curso.Product>();
        public ProductsService()
        {
            products.Add(new curso.Product() { 
                Id = 1, 
                Name = "Chocolate", 
                Price = 2, 
                IsAvailable = true, 
                Category = curso.Category.Food });

            products.Add(new curso.Product() { 
                Id = 2, 
                Name = "Mouse", 
                Price = 12, 
                IsAvailable = false, 
                Category = curso.Category.Technology });    
        }

        public override Task<curso.Product> GetProductById(curso.ProductRequest
            request, Grpc.Core.ServerCallContext context)
        {
            var result = products.First(a => a.Id ==request.Id);
            return Task.FromResult(result);
        }
    }
}