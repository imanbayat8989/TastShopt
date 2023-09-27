using System.ComponentModel.DataAnnotations;

namespace TastShopt.Models.DTO
{
    public class ProductUpdateDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public string ImageUrl { get; set; }

    }
}
