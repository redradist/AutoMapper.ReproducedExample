using System;

namespace AutoMapper.ReproducedExample.Entities
{
    public class StoreProductEntity
    {
        public int StoreId { get; set; }
        public StoreEntity Store { get; set; }
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; }
    }
}