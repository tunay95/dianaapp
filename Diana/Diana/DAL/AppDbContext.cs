using Diana.Models;
using Microsoft.EntityFrameworkCore;

namespace Diana.DAL
{
    public class AppDbContext:DbContext
    {
       public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }  
       public DbSet<Product>Products { get; set; }
       public DbSet<Category>Categories { get; set; }
       public DbSet<Color>Colors { get; set; }
       public DbSet<Image>Images { get; set; }
       public DbSet<Material>Materials { get; set; }
       public DbSet<Size>Sizes { get; set; }

    }
}
