using Microsoft.EntityFrameworkCore;
using Pets.Api.Models;

namespace Pets.Api.Data
{
  public class PetsDataContext : DbContext
  {
    public PetsDataContext(DbContextOptions<PetsDataContext> options)
      : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
  }
}
