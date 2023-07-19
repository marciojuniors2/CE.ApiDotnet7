using AutoMapper;
using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Application.DTOs.Validations;
using CE.ApiDotnet7.Application.Services.Interfaces;
using CE.ApiDotnet7.Domain.Entities;
using CE.ApiDotnet7.Domain.Interfaces;

namespace CE.ApiDotnet7.Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IMapper _mapper;

        public CarService(ICarRepository carRepository, IMapper mapper) 
        {
            _carRepository = carRepository;
            _mapper = mapper;
        }

        public async Task<ResultService<CarDTO>> CreateAsync(CarDTO carDTO)
        {
            if (carDTO == null)
                return ResultService.Fail<CarDTO>("Objeto deve ser informado!");

            var result = new CarDtoValidator().Validate(carDTO);
            if (!result.IsValid)
                return ResultService.RequestError<CarDTO>("Problemas de validação", result);
                
            var car = _mapper.Map<Car>(carDTO);
            var data = await _carRepository.CreateAsync(car);
            return ResultService.Ok<CarDTO>(_mapper.Map<CarDTO>(data));

        }

        public async Task<ResultService<ICollection<CarDTO>>> GetAsync()
        {
            var cars = await _carRepository.GetAllAsync();
            return ResultService.Ok<ICollection<CarDTO>>(_mapper.Map<ICollection<CarDTO>>(cars));
        }

       public async Task<ResultService<CarDTO>> GetByIdAsync(int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car == null)
                return ResultService.Fail<CarDTO>("Car não encontrado");

            return ResultService.Ok(_mapper.Map<CarDTO>(car));
        }

        public async Task<ResultService> RemoveAsync(int id)
        {
            var car = await _carRepository.GetByIdAsync(id);
            if (car == null)
                return ResultService.Fail("Car não encontrada!");

            await _carRepository.DeleteAsync(car);
            return ResultService.Ok($"Car do id:{id} deletada");
        }

        public async Task<ResultService> UpdateAsync(CarDTO carDTO)
        {
             if (carDTO == null)
                return ResultService.Fail<CarDTO>("Objeto deve ser informado");

            var validation = new CarDtoValidator().Validate(carDTO);
            if (!validation.IsValid)
                return ResultService.RequestError<CarDTO>("Problema de validacao!", validation);

            var car = await _carRepository.GetByIdAsync(carDTO.Id);
            if (car == null)
                return ResultService.Fail("Car não encontrada!");

            car = _mapper.Map<CarDTO, Car>(carDTO, car);
            await _carRepository.EditAsync(car);
            return ResultService.Ok("Carro editado!");
        }
    }
}
