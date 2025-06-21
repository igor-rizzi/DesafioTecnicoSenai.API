using DesafioTecnicoSenai.API.Areas.Administracao.Models;
using FluentValidation;

namespace DesafioTecnicoSenai.API.Areas.Administracao.Validators
{
    public class FuncaoValidator : AbstractValidator<FuncaoModel>
    {
        public FuncaoValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O nome da fun��o � obrigat�rio.")
                .MaximumLength(100).WithMessage("O nome da fun��o deve ter no m�ximo 100 caracteres.");

            RuleFor(x => x.Descricao)
                .NotEmpty().WithMessage("A descri��o da fun��o � obrigat�ria.")
                .MaximumLength(255).WithMessage("A descri��o da fun��o deve ter no m�ximo 255 caracteres.");
        }
    }
}