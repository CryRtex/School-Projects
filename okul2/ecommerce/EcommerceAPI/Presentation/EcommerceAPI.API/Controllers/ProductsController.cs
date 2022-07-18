using EcommerceAPI.Application.Abstrations;
using EcommerceAPI.Application.Repositories;
using EcommerceAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    readonly private IProductWriteRepository _productWriteRepository;
    readonly private IProductReadRepository _productReadRepository;

    public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
    {
      _productWriteRepository = productWriteRepository;
      _productReadRepository = productReadRepository;
    }
    [HttpGet]
    public async Task get()
    {
      await _productWriteRepository.AddAsync(new() { Name = "C Product", Price = 1.500F, Stock = 10, CreatedDate = DateTime.UtcNow });
      await _productWriteRepository.SaveAsync(); 
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> get (string id)
    {
      Product product = await _productReadRepository.GetByIdAsync(id);
      return Ok(product); 
    }
  }
}
