using TastShopt.Models.DTO;

namespace TastShopt.Repository.IRepository
{
    public interface IUserRepo
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);
    }
}
