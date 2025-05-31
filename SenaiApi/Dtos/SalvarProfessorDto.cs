using System.ComponentModel.DataAnnotations;

namespace SenaiApi.Dtos
{
    public class SalvarProfessorDto
    {
        [Required]
        [MaxLength(60)]
        public string Nome { get; set; }
        public long EscolaId { get; set; }
        
    }
}
