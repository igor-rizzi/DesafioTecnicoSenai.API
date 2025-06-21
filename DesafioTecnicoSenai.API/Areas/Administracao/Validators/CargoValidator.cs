using DesafioTecnicoSenai.API.Areas.Administracao.Models;
using FluentValidation;

namespace DesafioTecnicoSenai.API.Areas.Administracao.Validators
{
    public class CargoValidator : AbstractValidator<CargoModel>
    {
        public CargoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome do cargo � obrigat�rio.")
                .MaximumLength(100).WithMessage("O nome do cargo deve ter no m�ximo 100 caracteres.");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("A descri��o do cargo � obrigat�ria.")
                .MaximumLength(255).WithMessage("A descri��o do cargo deve ter no m�ximo 255 caracteres.");
        }
    }
}