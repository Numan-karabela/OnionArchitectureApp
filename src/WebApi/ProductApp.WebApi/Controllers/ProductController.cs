using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Aplication.İnterfaces.Repositorys; 

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductResository _productResository;

        public ProductController(IProductResository productResository)
        {
            _productResository = productResository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var entity =await _productResository.GettAllAsync();
            return Ok(entity);

        }
    }
}
