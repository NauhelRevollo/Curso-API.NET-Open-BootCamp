using Microsoft.EntityFrameworkCore;
using UniversityAPI.Models;

namespace UniversityAPI.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }

        //TODO

        public DbSet<Users>? Users { get; set; }
        public DbSet<Cursos>? Cursos { get; set; }
        public DbSet<Estudiante>? Estudiantes { get; set; }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Capitulos>? Capitulos { get; set; }
    }
}
