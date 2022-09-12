using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.ProgramingLanguageTecnologies.Rules
{
    public class ProgramingLanguageTecnologyBusinessRules
    {
        private readonly IProgramingLanguageTecnologyRepository _programingLanguageTecnologyRepository;

        public ProgramingLanguageTecnologyBusinessRules(IProgramingLanguageTecnologyRepository programingLanguageTecnologyRepository)
        {
            _programingLanguageTecnologyRepository = programingLanguageTecnologyRepository;
        }

        public async Task ProgramingLanguageTecnologyNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<ProgramingLanguageTecnology> result = await _programingLanguageTecnologyRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("Programing Language name exists.");
        }

        public void ProgramingLanguageTecnologyShoulExistWhenRequested(ProgramingLanguageTecnology programingLanguageTecnology)
        {
            if (programingLanguageTecnology == null) throw new BusinessException("Requested Programing Language does not exist.");
        }
    }
}
