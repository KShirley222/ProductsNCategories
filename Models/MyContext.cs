using Microsoft.EntityFrameworkCore;

namespace ProductsandCats.Models
{
    public class MyContext : DbContext
    {
        public MyContext (DbContextOptions options) : base(options) {}
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Asscotiation> Asscotiations { get; set; }

        
    }
}