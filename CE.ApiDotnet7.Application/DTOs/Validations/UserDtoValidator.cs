using FluentValidation;


namespace CE.ApiDotnet7.Application.DTOs.Validations
{
    public class UserDtoValidator : AbstractValidator<UserDTO>
    {
        public UserDtoValidator() 
        {

            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Nome deve ser informado!");

            RuleFor(x => x.Email)
                .NotEmpty()
                .NotNull()
                .WithMessage("Eamil deve ser informado!");

            RuleFor(x => x.Password)
                .NotEmpty()
                .NotNull()
                .WithMessage("Senha deve ser informada!");
        }

    }
}
