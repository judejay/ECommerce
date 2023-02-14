using AutoMapper;
using easygroceries.Data;
using easygroceries.Models;

namespace easygroceries.Configurations
{
    public class MapperInitilizer : Profile
    {
        public MapperInitilizer()
        {
            CreateMap<Customer, CustomerDTO>()
                .ReverseMap();
            CreateMap<PurchaseOrder, PurchaseOrderDTO>().ReverseMap();
            CreateMap<Grocery, GroceryDTO>().ReverseMap();

        }
    }
   
    
       
   
}
