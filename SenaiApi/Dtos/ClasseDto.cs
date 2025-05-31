using SenaiApi.Entidades.Enums;
using SenaiApi.Entidades;

namespace SenaiApi.Dtos
{
    public class ClasseDto
    {
        public SerieEnum Serie { get; set; }

        public long EscolaId { get; set; }
        
        public long ProfessorId { get; set; }
        
    }
}
