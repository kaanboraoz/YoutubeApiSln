using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using YoutubeApi.Application.Features.Products.Queries.GetAllProducts;
using YoutubeApi.Persistance.UnitOfWorks;

namespace YoutubeApi.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);

            /*
                unitOfWork.GetReadRepository<Brand>().GetAllAsync(); 
            */
        }
    }
}
