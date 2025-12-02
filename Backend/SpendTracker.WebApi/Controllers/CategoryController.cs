using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpendTracker.Services.Interfaces;

namespace SpendTracker.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CategoryController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoriesAsync()
        {
            return Ok(
                await _service
                    .CategoryService
                    .GetAllCategoriesAsync(false)
            );
        }
    }
}
