using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pets.Api.Data;
using Pets.Api.Models;

namespace Pets.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    private readonly PetsDataContext _context;

    public ProductController(PetsDataContext context)
    {
      this._context = context;
    }

    public ActionResult<List<Product>> GetAll()
    {
      return this._context.Products.ToList();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(long id)
    {
      var product = await this._context.Products.FindAsync(id);

      if (product == null)
      {
        return this.NotFound();
      }

      return product;
    }

    [HttpPost]
    public async Task<ActionResult<Product>> Create(Product product)
    {
      this._context.Add(product);
      await this._context.SaveChangesAsync();

      return this.CreatedAtAction(nameof(this.GetById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update(long id, Product product)
    {
      if (id != product.Id)
      {
        return this.BadRequest();
      }

      var dbProduct = await this._context.Products.FindAsync(id);

      if (dbProduct == null)
      {
        return this.NotFound();
      }

      this._context.Entry(product).State = EntityState.Modified;
      await this._context.SaveChangesAsync();

      return this.NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(long id)
    {
      var product = await this._context.Products.FindAsync(id);

      if (product == null)
      {
        return this.NotFound();
      }

      this._context.Products.Remove(product);
      await this._context.SaveChangesAsync();

      return this.NoContent();
    }
  }
}
