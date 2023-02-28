using easygroceries.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easygroceries.Models
{
    public class CartItemDTO
    {
        [Key]
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        // public string ProductName { get; set; }
        //public int Quantity { get; set; }
        //[Column(TypeName = " decimal(8,2)")]
        [Column(TypeName = " decimal(8,2)")]

        public decimal Price { get; set; }

        public Cart Cart { get; set; }
    }
}
