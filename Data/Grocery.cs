using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace easygroceries.Data
{
    public class Grocery 
    {

        [Key]
        public int GroceryId { get; set; }
        [Required]
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Slug { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }

        public string Name { get; set; } = string.Empty;
       // public PurchaseOrder Purchase { get; set; }
       // public string Image { get; set; } = "noimage.png";

        //[NotMapped]
        //[FileExtension]
        //public IFormFile ImageUpload { get; set; }


    }
}
