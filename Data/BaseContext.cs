using Microsoft.EntityFrameworkCore;
using components.Models;
// using dashboard.Models;

namespace componets.Data;

public class BaseContext : DbContext
{
    public BaseContext(DbContextOptions<BaseContext> options) : base(options) { }
    
    //conexicón con modelos
    public DbSet<Estudiante> Estudiantes { get; set; }
    public DbSet<Universidad> Universidades { get; set; }
    public DbSet<Carrera> Carreras { get; set; }
    public DbSet<Materia> Materias { get; set; }
    // public DbSet<Profesor> Profesores { get; set; }
    // public DbSet<Inscripcion> Inscripciones { get; set; }.

} 