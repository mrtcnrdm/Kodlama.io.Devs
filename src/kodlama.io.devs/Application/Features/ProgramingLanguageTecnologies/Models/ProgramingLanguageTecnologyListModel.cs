using Application.Features.ProgramingLanguageTecnologies.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.ProgramingLanguageTecnologies.Models
{
    public class ProgramingLanguageTecnologyListModel : BasePageableModel
    {
        public IList<ProgramingLanguageTecnologyListDTO> Items { get; set; }
    }
}
