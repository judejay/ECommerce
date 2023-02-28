using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easygroceries.Data
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string CustomerFirstName { get; set; } = string.Empty;

        public string CustomerSecondName { get; set; } = string.Empty;
        
        public int? MembershipId { get; set; }
        public bool?  Active { get; set; }
        public string HouseNumberName { get; set; } = string.Empty;

        public string StreetName { get; set; } = string.Empty;

        public string Town { get; set; } = string.Empty;

        public string Postcode { get; set; } = string.Empty;


        public string Country { get; set; } = string.Empty;

        public virtual IList<PurchaseOrder> PurchaseOrders { get; set; }
        public string GetFullName()
        {
            return $"{this.CustomerFirstName} {this.CustomerSecondName}";
        }
    }
}
