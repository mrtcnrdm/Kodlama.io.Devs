using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class ProgramingLanguage : Entity
    {
        public string Name { get; set; }
        public virtual List<ProgramingLanguageTecnology> ProgramingLanguageTecnologies { get; set; }

        public ProgramingLanguage(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public ProgramingLanguage()
        {

        }
    }
}
