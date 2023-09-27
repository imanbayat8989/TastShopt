using System.ComponentModel.DataAnnotations;

namespace TastShopt.Models.DTO
{
    public class ProductCreateDTO
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public string ImageUrl { get; set; }
    }
}
