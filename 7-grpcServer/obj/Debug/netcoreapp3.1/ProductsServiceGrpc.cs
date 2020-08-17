// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ProductsService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace curso {
  public static partial class ProductsService
  {
    static readonly string __ServiceName = "ProductsService";

    static readonly grpc::Marshaller<global::curso.ProductRequest> __Marshaller_ProductRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::curso.ProductRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::curso.Product> __Marshaller_Product = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::curso.Product.Parser.ParseFrom);

    static readonly grpc::Method<global::curso.ProductRequest, global::curso.Product> __Method_GetProductById = new grpc::Method<global::curso.ProductRequest, global::curso.Product>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_ProductRequest,
        __Marshaller_Product);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::curso.ProductsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ProductsService</summary>
    [grpc::BindServiceMethod(typeof(ProductsService), "BindService")]
    public abstract partial class ProductsServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::curso.Product> GetProductById(global::curso.ProductRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ProductsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetProductById, serviceImpl.GetProductById).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ProductsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetProductById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::curso.ProductRequest, global::curso.Product>(serviceImpl.GetProductById));
    }

  }
}
#endregion
