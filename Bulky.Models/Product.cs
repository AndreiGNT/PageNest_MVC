using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        public required string Description { get; set; }
        [Required]
        public required string ISBN { get; set; }
        [Required]
        public required string Author { get; set; }
        [Required]
        [Display(Name = "List Price")]
        [Range(1, 100)]
        public double ListPrice { get; set; }

        [Required]
        [Display(Name = "Price for 1 - 50")]
        [Range(1, 100)]
        public double Price { get; set; }

        [Required]
        [Display(Name = "Price for 51+")]
        [Range(1, 100)]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]
        [Range(1, 100)]
        public double Price100 { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public string ImageUrl { get; set; }
    }
}
