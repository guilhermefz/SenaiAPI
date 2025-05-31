using AutoMapper;
using SenaiApi.Dtos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class ProfessorMapper : Profile
    {
        public ProfessorMapper() 
        {
            CreateMap<Professor, SalvarProfessorDto>().ReverseMap();
            CreateMap<Professor, ProfessorDto>().ReverseMap();
        }
        
    }
}
