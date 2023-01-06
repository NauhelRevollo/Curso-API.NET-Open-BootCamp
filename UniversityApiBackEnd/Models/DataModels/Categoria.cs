using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackEnd.Models.DataModels
{
    public class Categoria:BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        public ICollection<Cursos> Cursos { get; set; } = new List<Cursos>();
    }
}
