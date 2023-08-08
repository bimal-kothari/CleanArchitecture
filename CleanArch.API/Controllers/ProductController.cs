using CleanArch.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers
{
    [Route("api/[controller]")]
    public class ProductController:Controller
    {
        //Unit of work to give access to the repositories
        private readonly IProductRepository _repository;
        private readonly ILogger _logger;

        public ProductController(IProductRepository repository, ILogger logger)
        {
            // Inject Unit Of Work to the contructor of the product controller
            _repository = repository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            //var data = await _repository.GetAllAsync();
            _logger.LogInformation("Product - GetAll called");
            return Ok("Success");
        }
    }
}
