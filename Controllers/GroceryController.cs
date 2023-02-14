using easygroceries.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace easygroceries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public GroceryController(IUnitOfWork unitOfWork, ILogger<GroceryController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetGroceries()
        {
            try
            {
                var groceries = await _unitOfWork.Groceries.GetAllAsync();
                return Ok(groceries);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetGroceries)}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
