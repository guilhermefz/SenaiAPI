using AutoMapper;
using SenaiApi.Dtos;
using SenaiApi.Entidades;

namespace SenaiApi.Mappers
{
    public class EscolaMapper : Profile
    {
        public EscolaMapper() 
        {
            CreateMap<EscolaDto, Escola>().ReverseMap();
            //.ForMember(dest => dest.Nome, opt => opt.MapFrom(src => src.Nome)); Usado para Quando as propriedades tem nomes diferentes
            CreateMap<ExibirEscolaDto, Escola>().ReverseMap();
            CreateMap<EnderecoDto, Endereco>().ReverseMap();
            CreateMap<EnderecoDtoSalvar, Endereco>().ReverseMap();
        }
    }
}
