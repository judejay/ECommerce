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

            public virtual CartDTO CartDTO { get; set; }
        [Column(TypeName = " decimal(8,2)")]

        public decimal GrandTotal { get; set; }

         
       // [ForeignKey(nameof(CartId))]
       // public int CartId { get; set; }  
      //  [ForeignKey(nameof(CustomerId))]
          // public int CustomerId { get; set; }
        public virtual CustomerDTO CustomerDTO { get; set; }
    }
}
