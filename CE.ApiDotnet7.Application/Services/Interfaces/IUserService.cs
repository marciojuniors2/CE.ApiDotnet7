using CE.ApiDotnet7.Application.DTOs;

namespace CE.ApiDotnet7.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<ResultService<ICollection<UserDTO>>> GetAsync();
        Task<ResultService<UserDTO>> CreateAsync(UserDTO userDTO);
        Task<ResultService> UpdateAsync(UserDTO userDTO);
        Task<ResultService> RemoveAsync(int id);
        Task<ResultService<UserDTO>> GetByIdAsync(int id);
        Task<ResultService<UserDTO>> AuthenticateAsync(UserAuthenticationDTO authenticationData);

    }
}
