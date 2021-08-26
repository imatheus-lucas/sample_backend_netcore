using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using testef.Data;
using testef.Models;

namespace testef.Controllers
{
  [ApiController]
  [Route("v1/categories")]
  public class CategoryController : ControllerBase
  {
    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Category>>> Get([FromServices] DataContext context)
    {
      var categories = await context.Categories.ToListAsync();
      return categories;
    }

    [HttpPost]
    [Route("")]
    public async Task<ActionResult<Category>> Post([FromServices] DataContext context, [FromBody] Category model)
    {
      if (ModelState.IsValid)
      {
        context.Categories.Add(model);
        await context.SaveChangesAsync();
        return model;
      }
      else
      {
        return BadRequest(ModelState);
      }

    }
  }
}