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
        public IFormFile MainPhoto { get; set; }

       


    }
}
