using FluentValidation;

namespace Application.Features.ProgramingLanguageTecnologies.Commands.CreateProgramingLanguageTecnology
{
    public class CreateProgramingLanguageTecnologyCommandValidator : AbstractValidator<DeleteProgramingLanguageTecnologyCommand>
    {
        public CreateProgramingLanguageTecnologyCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).MinimumLength(2);
        }
    }
}
