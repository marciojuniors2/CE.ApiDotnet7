using AutoMapper;
using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Application.DTOs.Validations;
using CE.ApiDotnet7.Application.Services.Interfaces;
using CE.ApiDotnet7.Domain.Entities;
using CE.ApiDotnet7.Domain.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace CE.ApiDotnet7.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        public async Task<ResultService<UserDTO>> CreateAsync(UserDTO UserDTO)
        {
            if (UserDTO == null)
                return ResultService.Fail<UserDTO>("Objeto deve ser informado!");

            var result = new UserDtoValidator().Validate(UserDTO);
            if (!result.IsValid)
                return ResultService.RequestError<UserDTO>("Problemas de validação", result);

            var user = _mapper.Map<User>(UserDTO);
            var data = await _userRepository.CreateAsync(user);
            return ResultService.Ok<UserDTO>(_mapper.Map<UserDTO>(data));
        }

        public async Task<ResultService<ICollection<UserDTO>>> GetAsync()
        {
            var users = await _userRepository.GetAllAsync();
            return ResultService.Ok<ICollection<UserDTO>>(_mapper.Map<ICollection<UserDTO>>(users));
        }

        public async Task<ResultService<UserDTO>> GetByIdAsync(int id)
        {
            var car = await _userRepository.GetByIdAsync(id);
            if (car == null)
                return ResultService.Fail<UserDTO>("Produto não encontrado");

            return ResultService.Ok(_mapper.Map<UserDTO>(car));
        }

        public async Task<ResultService> RemoveAsync(int id)
        {
            var car = await _userRepository.GetByIdAsync(id);
            if (car == null)
                return ResultService.Fail("Produto não encontrada!");

            await _userRepository.DeleteAsync(car);
            return ResultService.Ok($"Produto do id:{id} deletada");
        }

        public async Task<ResultService> UpdateAsync(UserDTO userDTO)
        {
            if (userDTO == null)
                return ResultService.Fail<UserDTO>("Objeto deve ser informado");

            var validation = new UserDtoValidator().Validate(userDTO);
            if (!validation.IsValid)
                return ResultService.RequestError<UserDTO>("Problema de validacao!", validation);

            var user = await _userRepository.GetByIdAsync(userDTO.Id);
            if (user == null)
                return ResultService.Fail("Pessoa não encontrada!");

            user = _mapper.Map<UserDTO, User>(userDTO, user);
            await _userRepository.EditAsync(user);
            return ResultService.Ok("Produto editada");
        }

        public async Task<ResultService<UserDTO>> AuthenticateAsync(UserAuthenticationDTO authenticationData)
        {
            if (string.IsNullOrEmpty(authenticationData.Email))
                return ResultService.Fail<UserDTO>("Email deve ser informado");

            if (authenticationData.Password <= 0)
                return ResultService.Fail<UserDTO>("Senha inválida");

            var user = await _userRepository.GetByEmailAsync(authenticationData.Email);

            if (user == null || !VerifyPassword(authenticationData.Password, user.Password))
            {
                return ResultService.Fail<UserDTO>("Credenciais inválidas");
            }

            var userDTO = _mapper.Map<UserDTO>(user);
            return ResultService.Ok(userDTO);
        }

        private bool VerifyPassword(int password, int hashedPassword)
        {
            return password == hashedPassword;
        }

    }
}
