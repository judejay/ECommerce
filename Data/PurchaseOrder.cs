using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easygroceries.Data
{
    public class PurchaseOrder 
    {
        [Key]
        public int Id { get; set; }



        [Column(TypeName =" decimal(8,2)")]
        public decimal TotalPrice { get; set; }

        public int CustomerId { get; set; }

        //public Membership MemberShip { get; set; }
     

        public Customer Customer { get; set; }
    }
}
