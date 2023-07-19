using CE.ApiDotnet7.Application.DTOs;

namespace CE.ApiDotnet7.Application.Services.Interfaces
{
    public interface ICarService
    {
        Task<ResultService<CarDTO>> CreateAsync(CarDTO carDTO);
        Task<ResultService<CarDTO>> GetByIdAsync(int id);
        Task<ResultService<ICollection<CarDTO>>> GetAsync();
        Task<ResultService> UpdateAsync(CarDTO carDTO);
        Task<ResultService> RemoveAsync(int id);
    }
}
