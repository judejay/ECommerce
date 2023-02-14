using easygroceries.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace easygroceries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;

        public PurchaseOrderController(IUnitOfWork unitOfWork, ILogger<PurchaseOrderController> logger)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> GetPurchaseOrders() 
        {
            try
            {
                var purchaseOrders = await _unitOfWork.PurchaseOrders.GetAllAsync();
                return Ok(purchaseOrders);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(PurchaseOrderController)}");
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
