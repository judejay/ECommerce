using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easygroceries.Data
{
    public class Cart
    {
        [Key]
        public int CartId { get; set; }
        //public CartItem CartItem { get; set; }
        public ICollection<CartItem> CartItems { get; set; }
        [Column(TypeName = " decimal(8,2)")]
public  decimal Total { get; set; }
    }
}
