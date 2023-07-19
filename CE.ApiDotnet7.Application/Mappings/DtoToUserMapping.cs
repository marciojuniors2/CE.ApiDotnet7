using AutoMapper;
using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Domain.Entities;


namespace CE.ApiDotnet7.Application.Mappings
{
    public class DtoToUserMapping : Profile
    {
        public DtoToUserMapping() 
        {
            CreateMap<UserDTO, User>();
        }
    }
}
