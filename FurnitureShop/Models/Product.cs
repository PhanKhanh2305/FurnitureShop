using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureShop.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(200)]
        public string? ProductName { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        [Required]
        [Column(TypeName ="decimal(8,3)")]
        public decimal? ProductPrice { get; set; }
        [Required]
        [StringLength(300)]
        public string? ProductPhoto { get; set; }
        public Category? Category { get; set; }
    }
}
