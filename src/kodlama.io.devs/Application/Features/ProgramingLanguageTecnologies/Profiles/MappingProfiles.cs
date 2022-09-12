using Application.Features.ProgramingLanguages.Commands.CreateProgramingLanguage;
using Application.Features.ProgramingLanguages.Commands.DeleteProgramingLanguage;
using Application.Features.ProgramingLanguages.Commands.UpdateProgramingLanguage;
using Application.Features.ProgramingLanguages.Dtos;
using Application.Features.ProgramingLanguages.Models;
using Application.Features.ProgramingLanguageTecnologies.Commands.CreateProgramingLanguageTecnology;
using Application.Features.ProgramingLanguageTecnologies.Commands.DeleteProgramingLanguageTecnology;
using Application.Features.ProgramingLanguageTecnologies.Commands.UpdateProgramingLanguageTecnology;
using Application.Features.ProgramingLanguageTecnologies.Dtos;
using Application.Features.ProgramingLanguageTecnologies.Models;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;

namespace Application.Features.ProgramingLanguageTecnologies.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProgramingLanguageTecnology, DeleteProgramingLanguageTecnologyDTO>().ReverseMap();
            CreateMap<ProgramingLanguageTecnology, Commands.CreateProgramingLanguageTecnology.DeleteProgramingLanguageTecnologyCommand>().ReverseMap();
            CreateMap<IPaginate<ProgramingLanguageTecnology>, ProgramingLanguageTecnologyListModel>().ReverseMap();
            CreateMap<ProgramingLanguageTecnology, ProgramingLanguageTecnologyListDTO>().ReverseMap();
            CreateMap<ProgramingLanguageTecnology, ProgramingLanguageTecnologyGetByIdDTO>().ReverseMap();
            CreateMap<ProgramingLanguageTecnology, UpdatedProgramingLanguageTecnologyDTO>().ReverseMap();
            CreateMap<ProgramingLanguageTecnology, UpdateProgramingLanguageTecnologyCommand>().ReverseMap();
            CreateMap<ProgramingLanguageTecnology, DeleteProgramingLanguageTecnologyDTO>().ReverseMap();
            CreateMap<ProgramingLanguageTecnology, Commands.DeleteProgramingLanguageTecnology.DeleteProgramingLanguageTecnologyCommand>().ReverseMap();
        }

    }
}
