using Diana.Models;

namespace Diana.Areas.Admin.ViewModels
{
    public class CreateProductVM
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public bool? IsDeleted { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<ProductColors> ProductColors { get; set; }
        public ICollection<ProductSizes> ProductSizes { get; set; }
        public ICollection<ProductMaterials> ProductMaterials { get; set; }


    }
}
