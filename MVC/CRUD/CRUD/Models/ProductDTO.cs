using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    // The ProductDTO class is declared within the CRUD.Models namespace. This helps organize the code and avoid naming conflicts with other classes.
    public class ProductDTO
    {
        [Required , MaxLength(100)]
        public string Name { get; set; } = "";
        [Required , MaxLength(100)]
        public string Brand { get; set; } = "";
        [Required , MaxLength(100)]
        public string Category { get; set; } = "";
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Description { get; set; } = "";
        public IFormFile? ImageFile { get; set; }
    }
}
