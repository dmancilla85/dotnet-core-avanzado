using System;
using curso;
using Grpc.Net.Client;
using System.Threading.Tasks;

namespace grpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int productId = args != null && args.Length > 0 && int.TryParse(args[0], out int value) ? value : 1;

            // Establece el canal de comunicación con el servidor
            GrpcChannel channel = GrpcChannel.ForAddress("https://localhost:5001");
            
            // Construye la instancia cliente
            ProductsService.ProductsServiceClient client =
                new ProductsService.ProductsServiceClient(channel);

            // Construye una nueva solicitud    
            ProductRequest request = new ProductRequest() { Id = productId };
            
            // Envía la solicitud
            Product result = await client.GetProductByIdAsync(request);

            Console.WriteLine(
                $"Id: {result.Id} Nombre: {result.Name} Precio: {result.Price}" +
                $" Disponible: {result.IsAvailable} Categoria: {result.Category}");
            Console.ReadKey();
        }
    }
}
