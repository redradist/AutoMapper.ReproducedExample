using System.Collections.Generic;

namespace AutoMapper.ReproducedExample.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StoreModel> Stores { get; set; } = new List<StoreModel>();
    }
}