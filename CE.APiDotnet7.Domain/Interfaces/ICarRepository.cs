using CE.ApiDotnet7.Domain.Entities;

namespace CE.ApiDotnet7.Domain.Interfaces
{
    public interface ICarRepository
    {
        Task<ICollection<Car>> GetAllAsync();
        Task<Car> GetByIdAsync(int id);
        Task<Car> CreateAsync(Car car);
        Task EditAsync(Car car);
        Task DeleteAsync(Car car);
    }
}
