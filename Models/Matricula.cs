using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace components.Models
{
    public class Matricula
    {
        
        public int Id { get; set; }
        public int IdMateiras { get; set; }
        public Materia? Materia { get; set; }
        public string? Estado { get; set; }
        public string? Semestre {get;set;}
        public int IdEstudiante { get; set; }
        public Estudiante? Estudiante { get; set; }
        public int IdProfesor {get; set;} 
         public Profesor? Profesor { get; set; }   
    }
}