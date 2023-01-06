using System.ComponentModel.DataAnnotations;

namespace UniversityAPI.Models
{
    public enum Nivel
    {
        Basico,
        Medio,
        Avanzado
    }
    public class Cursos : BaseEntity

    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;        
        public string DescripcionCorta { get; set; } = string.Empty;
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;
        public Nivel Nivel { get; set; } = Nivel.Basico;

        // [Required]
        public Capitulos Capitulo { get; set; } = new Capitulos();

        //  [Required]
        public ICollection<Categoria> Categorias { get; set; } = new List<Categoria>();

        //[Required]
        public ICollection<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

    }
}
