using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Aplication.Features.Queries.GetAllProduct;
using ProductApp.Aplication.İnterfaces.Repositorys; 

namespace ProductApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Query = new GetAllProductQueryRequest(); 
            return Ok(await mediator.Send(Query));

        }
    }
}
