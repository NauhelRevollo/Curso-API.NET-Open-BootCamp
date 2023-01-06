namespace UniversityAPI.Models
{
    public class Categoria : BaseEntity
    {
        //[Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;

        // [Required]
        public ICollection<Cursos> Cursos { get; set; } = new List<Cursos>();
    }
}
