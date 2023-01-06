using Microsoft.EntityFrameworkCore;
using UniversityApiBackEnd.Models.DataModels;

namespace UniversityApiBackEnd.DataAccess
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options):base (options) { }

        //TODO

        public DbSet<Users>? Users { get; set; }
        public DbSet<Cursos>? Cursos { get; set; }
    }
}
