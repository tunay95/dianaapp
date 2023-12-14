

namespace Diana.Models
{
    public class Color:BaseEntity
    {
        public string Name { get; set; }
        public ICollection<ProductColors> ProductColors { get; set; }

    }
}
