namespace Diana.Models
{
    public class ProductMaterials:BaseEntity


    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
    }
}
