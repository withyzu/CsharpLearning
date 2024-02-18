// Ignore Spelling: App

using Microsoft.EntityFrameworkCore;
using SharedLibrary.Models;

namespace DemoCRUD.Data;
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options) {
    }

    public DbSet<Product> Products { get; set; }
  
}
