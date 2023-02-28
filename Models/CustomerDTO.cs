using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using easygroceries.Data;

namespace easygroceries.Models
{
    public class CustomerDTO
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter a value")]
        [StringLength(100)]
        public string CustomerFirstName { get; set; } = string.Empty;
        
        //[Required(ErrorMessage = "Please enter a value")]
        //[StringLength(100)]
        //public string CustomerSecondName { get; set; } = string.Empty;
        //[Display(Name = "Full Name")]
        ////public string FullName { get; set; }
       // public int MembershipId { get; set; }
       // public bool Active { get; set; }
       // public string HouseNumberName { get; set; } = string.Empty;

       // public string StreetName { get; set; } = string.Empty;

       // public string Town { get; set; } = string.Empty;

      //  public string Postcode { get; set; } = string.Empty;


       // public string Country { get; set; } = string.Empty;

       // public virtual IList<PurchaseOrder> PurchaseOrders { get; set; }
        //public string GetFullName()
        //{
        //    return $"{this.CustomerFirstName} {this.CustomerSecondName}";
        //}
       // public virtual IList<PurchaseOrderDTO> PurchaseOrdersDTO { get; set; }

     

    }
}
