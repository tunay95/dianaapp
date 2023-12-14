

namespace Diana.Models
{
    public class Material:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductMaterials> ProductMaterials { get; set; }
    }
}
