using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using dockerize_aspNetCore_jwt_api.Models;
using dockerize_aspNetCore_jwt_api.Services;

namespace dockerize_aspNetCore_jwt_api.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
public class ProductsController(ProductService service) : ControllerBase
{
    [HttpGet]
    public IActionResult GetAll() => Ok(service.GetAll());

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var product = service.Get(id);
        return product == null ? NotFound() : Ok(product);
    }

    [HttpPost]
    public IActionResult Create(Product product) => Ok(service.Add(product));

    [HttpPut("{id}")]
    public IActionResult Update(int id, Product product)
    {
        return service.Update(id, product) ? NoContent() : NotFound();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        return service.Delete(id) ? NoContent() : NotFound();
    }
}
