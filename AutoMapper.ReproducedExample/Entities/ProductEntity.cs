using System.Collections.Generic;

namespace AutoMapper.ReproducedExample.Entities
{
    public class ProductEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StoreProductEntity> Stores { get; set; } = new List<StoreProductEntity>();
    }
}