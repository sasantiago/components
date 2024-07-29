using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace components.Models
{
    public class ProfesorMateria
    {
        public int Id {get;set;}
        public int IdProfesor {get;set;}
        public Profesor? Profesor {get;set;}
        public int IdMateria {get;set;}
        public Materia? Materia {get;set;}
    }
}