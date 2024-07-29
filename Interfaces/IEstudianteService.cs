using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using components.Models;

namespace components.Interfaces
{
    public interface IEstudianteService
    {
        Task Add(Estudiante estudiante);
        Task<IEnumerable<Estudiante>> GetAll();
        Task<Estudiante> GetById(int id);
        Task Update(int id, Estudiante estudiante);
        Task Delete(int id);

    }
}