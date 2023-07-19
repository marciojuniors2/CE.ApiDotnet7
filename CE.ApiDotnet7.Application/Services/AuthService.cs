using CE.ApiDotnet7.Application.DTOs;
using CE.ApiDotnet7.Application.Services.Interfaces;
using CE.ApiDotnet7.Domain.Interfaces;
using System.Threading.Tasks;

namespace CE.ApiDotnet7.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ResultService> AuthenticateAsync(UserAuthenticationDTO authenticationData)
        {
            if (string.IsNullOrEmpty(authenticationData.Email))
                return ResultService.Fail("Email deve ser informado");

            if (authenticationData.Password <= 0)
                return ResultService.Fail("Senha inválida");

            var user = await _userRepository.GetByEmailAsync(authenticationData.Email);

            if (user == null || !VerifyPassword(authenticationData.Password, user.Password))
            {
                return ResultService.Fail("Credenciais inválidas");
            }

            return ResultService.Ok(user);
        }

        private bool VerifyPassword(int password, int hashedPassword)
        {
            return password == hashedPassword;
        }
    }
}
