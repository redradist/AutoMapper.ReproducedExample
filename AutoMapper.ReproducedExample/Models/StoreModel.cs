using System.Collections.Generic;

namespace AutoMapper.ReproducedExample.Models
{
    public class StoreModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}