using easygroceries.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace easygroceries.Models
{
    public class PurchaseOrderDTO
    {
       
            [Key]
            public int PurchaseOrderId { get; set; }

            public Cart Cart { get; set; }
        public decimal TotalPrice { get; set; }

            [ForeignKey(nameof(CustomerId))]
            public int CustomerId { get; set; }
            public CustomerDTO CustomerDTO { get; set; }
    }
}
