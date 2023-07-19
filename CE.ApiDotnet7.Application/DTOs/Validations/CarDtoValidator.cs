using FluentValidation;
using System;


namespace CE.ApiDotnet7.Application.DTOs.Validations
{
    public class CarDtoValidator : AbstractValidator<CarDTO>
    {
        public CarDtoValidator() 
        {
            RuleFor(x => x.Name)
              .NotEmpty()
              .NotNull()
             .WithMessage("Name deve ser informado!");

            RuleFor(x => x.Brand)
                .NotEmpty()
                .NotNull()
                .WithMessage("Brand deve ser informado!");

            RuleFor(x => x.Model)
                .NotEmpty()
                .NotNull()
                .WithMessage("Model deve ser informado!");

            RuleFor(x => x.Year)
                .GreaterThanOrEqualTo(1900)
                .WithMessage("Year deve ser maior que 1900");

            RuleFor(x => x.Price)
                .GreaterThanOrEqualTo(0)
                .WithMessage("Price deve ser maior que 0");

            RuleFor(x => x.Color)
                .NotEmpty()
                .NotNull()
                .WithMessage("Color deve ser informada!");

        }
    }
 }
