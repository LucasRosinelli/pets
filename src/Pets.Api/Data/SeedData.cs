using System.Linq;
using Pets.Api.Models;

namespace Pets.Api.Data
{
  public static class SeedData
  {
    public static void Initialize(PetsDataContext context)
    {
      if (!context.Products.Any())
      {
        context.Products.AddRange(
          new Product() { Name = "Squeaky bone", Price = 20.99M },
          new Product() { Name = "Knotted rope", Price = 12.99M }
        );

        context.SaveChanges();
      }
    }
  }
}
