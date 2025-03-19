using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace backCCL.Models
{
    public class Product
    {
        [Key]
        [Column("id")] 
        public int Id { get; set; }

        [Required]
        [Column("product_name")]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [Column("quantity")]
        public int Quantity { get; set; }
    }
}
