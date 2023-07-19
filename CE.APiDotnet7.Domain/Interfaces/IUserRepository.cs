using CE.ApiDotnet7.Domain.Entities;


namespace CE.ApiDotnet7.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<ICollection<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> CreateAsync(User user);
        Task EditAsync(User user);
        Task DeleteAsync(User user);
        Task<User> GetByEmailAsync(string email);
    }
}
