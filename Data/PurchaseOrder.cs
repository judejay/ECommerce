using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easygroceries.Data
{
    public class PurchaseOrder 
    {
        [Key]
        public int PurchaseOrderId { get; set; }



        [Column(TypeName =" decimal(8,2)")]
        public decimal GrandTotal { get; set; }


        //public Membership MemberShip { get; set; }
       // [ForeignKey(nameof(CartId))]
       // public int CartId { get; set; }
        public virtual Cart Cart { get; set; }
     //   [ForeignKey(nameof(CustomerId))]
       // public int CustomerId { get; set; }
        public  virtual Customer Customer { get; set; }
    }
}
