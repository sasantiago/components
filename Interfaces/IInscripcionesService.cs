using components.Models;

namespace components.Interfaces
{
    public interface IInscripcionesService
    {
        Task Add(Matricula inscripcion);
        Task<IEnumerable<Matricula>> GetAll();
        Task<Matricula> GetById(int id);
        Task Update(int id, Matricula inscripcion);
        Task Delete(int id);
    }
}