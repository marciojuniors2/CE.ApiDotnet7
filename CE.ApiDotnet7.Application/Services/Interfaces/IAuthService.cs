using CE.ApiDotnet7.Application.DTOs;

namespace CE.ApiDotnet7.Application.Services.Interfaces
{
    public interface IAuthService
    {
        Task<ResultService> AuthenticateAsync(UserAuthenticationDTO authenticationData);
    }
}
