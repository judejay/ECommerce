using AutoMapper;
using easygroceries.IRepository;
using easygroceries.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace easygroceries.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger _logger;
        private readonly IMapper _mapper;

        public CustomerController(IUnitOfWork unitOfWork, ILogger<CustomerController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetCustomers() 
        {
            try
            {
                var customers= await _unitOfWork.Customers.GetAllAsync();
                var results = _mapper.Map<List<CustomerDTO>>(customers);
                return Ok(results);
            }
            catch (Exception ex)
            {

                _logger.LogError(ex, $"Something went wrong in the {nameof(GetCustomers)}");
                return StatusCode(500, "Internal Server Error");
            }
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            try
            {
                var customer = await _unitOfWork.Customers.GetAsync(q => q.CustomerId == id, new List<string> { "PurchaseOrders"});
                var result = _mapper.Map<CustomerDTO>(customer);
                return Ok(result);


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in {nameof(GetCustomerById)}");
                return StatusCode(500, "Internal Server Error");
                    }
        }
    }
}
