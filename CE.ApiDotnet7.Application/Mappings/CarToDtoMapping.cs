using AutoMapper;
using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Domain.Entities;

namespace CE.ApiDotnet7.Application.Mappings
{
    public class CarToDtoMapping : Profile
    {
        public CarToDtoMapping()
        {
            CreateMap<Car, CarDTO>();

        }

    }
}
