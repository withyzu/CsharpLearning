// Ignore Spelling: App

using DemoCRUD.SharedLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoCRUD.Data;
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options) {
    }

    public DbSet<Product> Products { get; set; }
  
}
