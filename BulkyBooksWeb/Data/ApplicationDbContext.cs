using BulkyBooksWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBooksWeb.Data
{
    public sealed class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
