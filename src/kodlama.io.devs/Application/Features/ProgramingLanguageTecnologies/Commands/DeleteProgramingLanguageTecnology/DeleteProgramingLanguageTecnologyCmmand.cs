using Application.Features.ProgramingLanguageTecnologies.Dtos;
using Application.Features.ProgramingLanguageTecnologies.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

namespace Application.Features.ProgramingLanguageTecnologies.Commands.DeleteProgramingLanguageTecnology
{
    public class DeleteProgramingLanguageTecnologyCommand:IRequest<DeleteProgramingLanguageTecnologyDTO>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public class DeleteProgramingLanguageTecnologyCommandHandler : IRequestHandler<DeleteProgramingLanguageTecnologyCommand, DeleteProgramingLanguageTecnologyDTO>
        {
            private readonly IProgramingLanguageTecnologyRepository _programingLanguageTecnologyRepository;
            private readonly IMapper _mapper;
            private readonly ProgramingLanguageTecnologyBusinessRules _programingLanguageTecnologyBusinessRules;

            public DeleteProgramingLanguageTecnologyCommandHandler(IProgramingLanguageTecnologyRepository programingLanguageTecnologyRepository, IMapper mapper, ProgramingLanguageTecnologyBusinessRules programingLanguageTecnologyBusinessRules)
            {
                _programingLanguageTecnologyRepository = programingLanguageTecnologyRepository;
                _mapper = mapper;
                _programingLanguageTecnologyBusinessRules = programingLanguageTecnologyBusinessRules;
            }

            public async Task<DeleteProgramingLanguageTecnologyDTO> Handle(DeleteProgramingLanguageTecnologyCommand request, CancellationToken cancellationToken)
            {
                await _programingLanguageTecnologyBusinessRules.ProgramingLanguageTecnologyNameCanNotBeDuplicatedWhenInserted(request.Name);

                var mappedProgramingLanguageTecnology = _mapper.Map<ProgramingLanguageTecnology>(request);
                var deletedProgramingLanguageTecnoology = await _programingLanguageTecnologyRepository.AddAsync(mappedProgramingLanguageTecnology);
                var deletedProgramingLanguageTecnologyDTO = _mapper.Map<DeleteProgramingLanguageTecnologyDTO>(deletedProgramingLanguageTecnoology);

                return deletedProgramingLanguageTecnologyDTO;
            }
        }
    }
}
