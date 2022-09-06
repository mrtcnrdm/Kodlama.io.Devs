using Application.Features.ProgramingLanguages.Dtos;
using Core.Persistence.Paging;

namespace Application.Features.ProgramingLanguages.Models
{
    public class ProgramingLanguageListModel: BasePageableModel
    {
        public IList<ProgramingLanguageListDTO> Items { get; set; }
    }
}
