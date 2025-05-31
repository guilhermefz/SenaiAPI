using System.ComponentModel.DataAnnotations;

namespace SenaiApi.Dtos
{
    public class ProfessorDto
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public long EscolaId { get; set; }
        public long Id { get; set; }
    }
}
