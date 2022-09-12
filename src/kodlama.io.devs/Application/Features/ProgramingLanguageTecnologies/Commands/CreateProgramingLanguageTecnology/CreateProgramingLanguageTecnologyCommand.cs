using Application.Features.ProgramingLanguages.Commands.CreateProgramingLanguage;
using Application.Features.ProgramingLanguages.Dtos;
using Application.Features.ProgramingLanguages.Rules;
using Application.Features.ProgramingLanguageTecnologies.Dtos;
using Application.Features.ProgramingLanguageTecnologies.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.ProgramingLanguageTecnologies.Commands.CreateProgramingLanguageTecnology
{
    public class CreateProgramingLanguageTecnologyCommand : IRequest<CreatedProgramingLanguageTecnologyDTO>
    {
        public int ProgramingLanguageId { get; set; }
        public string Name { get; set; }

        
    }
}
