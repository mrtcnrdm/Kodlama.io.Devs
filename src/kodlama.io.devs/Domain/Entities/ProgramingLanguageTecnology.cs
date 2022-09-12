using Core.Persistence.Repositories;

namespace Domain.Entities
{
    public class ProgramingLanguageTecnology : Entity
    {
        public int ProgramingLanguageId { get; set; }
        public string Name { get; set; }

        public virtual ProgramingLanguage ProgramingLanguage { get; set; }

        public ProgramingLanguageTecnology()
        {

        }

        public ProgramingLanguageTecnology(int id, int programingLanguageId, string name)
        {
            Id = id;
            ProgramingLanguageId = programingLanguageId;
            Name = name;
        }
    }
}
