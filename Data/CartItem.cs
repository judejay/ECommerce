using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easygroceries.Data
{
    public class CartItem
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
      //  public decimal Subtotal { get; set; }
        //public CartItem() { }

        //public CartItem(int productId, string productName, int quantity, decimal price)
        //{
        //    ProductId = productId;
        //    ProductName = productName;
        //    Quantity = quantity;
        //    Price = price;
        //    Subtotal = quantity * price;
        //}
    }

}
