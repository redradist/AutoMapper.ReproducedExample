using System;
using System.Diagnostics;
using AutoMapper.ReproducedExample.Entities;
using AutoMapper.ReproducedExample.Models;

namespace AutoMapper.ReproducedExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<CustomProfile>();
            });
#if DEBUG
            configuration.AssertConfigurationIsValid();
#endif
            var mapper = configuration.CreateMapper();
            var store0 = new StoreModel()
            {
                Id = 1,
                Name = "Store0",
            };
            var store1 = new StoreModel()
            {
                Id = 2,
                Name = "Store1",
            };
            var product = new ProductModel()
            {
                Id = 1,
                Name = "Product",
            };
            store1.Products.Add(product);
            product.Stores.Add(store1);
            store0.Products.Add(product);
            product.Stores.Add(store0);
            
            var store0Entity = mapper.Map<StoreEntity>(store0);
            Debug.Assert(store0Entity.Products[0].Product.Stores[0].Store.Id ==
                         store0Entity.Products[0].Product.Stores[0].Store.Products[0].StoreId);
            Debug.Assert(store0Entity.Id ==
                         store0Entity.Products[0].StoreId);
        }
    }
}