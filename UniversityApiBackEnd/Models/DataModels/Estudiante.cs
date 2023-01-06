using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityApiBackEnd.Models.DataModels
{
    public class Estudiante:BaseEntity
    {
       // [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

       // [Required, StringLength(50)]
        public string Apellido { get; set; } = string.Empty;

       // [Required, StringLength(50)]
        public int DayOfBirth { get; set; }

        //[Required]
        public ICollection<Cursos> Cursos { get; set; } = new List<Cursos>();

    }
}
