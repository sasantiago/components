using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using components.Models;

namespace components.Interfaces
{
    public interface ICarreraServices
    {
         Task Add(Carrera carrera);
        Task<IEnumerable<Carrera>> GetAll();
        Task<Carrera> GetById(int id);
        Task Update(int id, Carrera carrera);
        Task Delete(int id);
    }
}