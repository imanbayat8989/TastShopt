using System.ComponentModel.DataAnnotations;

namespace TastShopt.Models.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public string ImageUrl { get; set; }
    }
}
