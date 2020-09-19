using System.Collections.Generic;

namespace AutoMapper.ReproducedExample.Entities
{
    public class StoreEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StoreProductEntity> Products { get; set; } = new List<StoreProductEntity>();
    }
}