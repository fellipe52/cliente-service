using Cliente.Domain.DTOs;
using FluentValidation;

namespace Cliente.Domain.Validators
{
    public class ClienteDTOValidator : AbstractValidator<ClienteDTO>
    {
        public ClienteDTOValidator()
        {
            RuleFor(x => x.Nome)
                .NotEmpty().WithMessage("O campo Nome é obrigatório.");

            RuleFor(x => x.Documento)
                .NotEmpty().WithMessage("O campo Documento é obrigatório.");
        }
    }
}