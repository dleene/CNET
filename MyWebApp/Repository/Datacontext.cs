using Microsoft.EntityFrameworkCore;
using MyWebApp.Models;

namespace MyWebApp.Repository
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<DbContext> options) : base(options)
        {

        }
        public DbSet<BrandModel> Brands { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }


    }
}
