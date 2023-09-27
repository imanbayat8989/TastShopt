using TastShopt.Models.DTO;
using TastShopt.Models;
using AutoMapper;

namespace TastShopt
{
    public class MappingConfig: Profile
    {
        public MappingConfig()
        {
            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();

            CreateMap<Product, ProductCreateDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();


            CreateMap<ApplicationUser, UserDTO>().ReverseMap();
        }
    }
}
