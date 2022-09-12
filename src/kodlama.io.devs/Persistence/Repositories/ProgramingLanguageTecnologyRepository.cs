using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    internal class ProgramingLanguageTecnologyRepository : EfRepositoryBase<ProgramingLanguageTecnology, BaseDbContext>, IProgramingLanguageTecnologyRepository
    {
        public ProgramingLanguageTecnologyRepository(BaseDbContext context) : base(context)
        {

        }
    }
}

