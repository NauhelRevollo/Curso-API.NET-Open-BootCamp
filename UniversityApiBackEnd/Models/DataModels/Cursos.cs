using Microsoft.Build.Framework;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace UniversityApiBackEnd.Models.DataModels
{

    public enum Nivel
    {
        Basico,
        Medio,
        Avanzado
    }
    public class Cursos:BaseEntity
    {
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; } = string.Empty;
        public string Objetivos { get; set; } = string.Empty;
        public string Requisitos { get; set; } = string.Empty;        
        public Nivel Nivel { get; set; } = Nivel.Basico;
    }
}
