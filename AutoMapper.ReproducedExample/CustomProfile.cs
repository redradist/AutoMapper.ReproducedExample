using AutoMapper.ReproducedExample.Entities;
using AutoMapper.ReproducedExample.Models;

namespace AutoMapper.ReproducedExample
{
    public class CustomProfile : Profile
    {
        public CustomProfile()
        {
            CreateMap<StoreModel, StoreEntity>()
                .ForMember(d => d.Products,
                    opt => opt.MapFrom(s => s.Products))
                .AfterMap((model, entity) =>
                {
                    foreach (var entityProduct in entity.Products)
                    {
                        entityProduct.StoreId = entity.Id;
                        entityProduct.Store = entity;
                    }
                });
            CreateMap<StoreModel, StoreProductEntity>()
                .ForMember(entity => entity.StoreId, opt => opt.MapFrom(model => model.Id))
                .ForMember(entity => entity.Store, opt => opt.MapFrom(model => model))
                .ForMember(entity => entity.ProductId, opt => opt.Ignore())
                .ForMember(entity => entity.Product, opt => opt.Ignore());

            CreateMap<ProductModel, ProductEntity>()
                .ForMember(d => d.Stores,
                    opt => opt.MapFrom(s => s.Stores))
                .AfterMap((model, entity) =>
                {
                    foreach (var entityStore in entity.Stores)
                    {
                        entityStore.ProductId = entity.Id;
                        entityStore.Product = entity;
                    }
                });
            CreateMap<ProductModel, StoreProductEntity>()
                .ForMember(entity => entity.StoreId, opt => opt.Ignore())
                .ForMember(entity => entity.Store, opt => opt.Ignore())
                .ForMember(entity => entity.ProductId, opt => opt.MapFrom(model => model.Id))
                .ForMember(entity => entity.Product, opt => opt.MapFrom(model => model));

        }
    }
}