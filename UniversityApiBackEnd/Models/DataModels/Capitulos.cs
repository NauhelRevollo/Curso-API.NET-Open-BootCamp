using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackEnd.Models.DataModels
{
    public class Capitulos:BaseEntity
    {
        public int CursoId { get; set; }

        public virtual Cursos Curso { get; set; }=new Cursos();

        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

    }
}
