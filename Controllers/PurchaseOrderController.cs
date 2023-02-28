using AutoMapper;
using easygroceries.Data;
using easygroceries.IRepository;
using easygroceries.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using easygroceries.Repository;

namespace easygroceries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrderController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public PurchaseOrderController(IUnitOfWork unitOfWork, ILogger<PurchaseOrderController> logger, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetPurchaseOrders()
        {
            try
            {
                var purchaseOrders = await _unitOfWork.PurchaseOrders
                   // .includes( p => p.Customer)
                    .GetAllAsync();
                var results = _mapper.Map<List<PurchaseOrderDTO>>(purchaseOrders);

                return Ok(results);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(PurchaseOrderController)}");
                return StatusCode(500, "Internal Server Error");
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PostPurchaseOrder([FromBody] PurchaseOrderDTO purchaseOrderDTO)
        {
            _logger.LogInformation($"Sending pruchase Order");
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
	
            try 
            {
                var purchaseOrder = _mapper.Map<PurchaseOrder>(purchaseOrderDTO);
               await _unitOfWork.PurchaseOrders.Insert(purchaseOrder);
               await _unitOfWork.Save();
               return Ok(purchaseOrder);
            }
	      catch (Exception ex)
	        {

                _logger.LogError(ex, $"Something went wrong in the {nameof(PostPurchaseOrder)}");
                return StatusCode(500, "Internal Server Error. Please try again later");

            }    

        }
    }
}
