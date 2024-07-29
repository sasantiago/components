using System.Text.Json.Serialization;

namespace components.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string? NombreMateria { get; set; }
        public string? IdCarreras { get; set; }
        public Carrera? Carrera { get; set; }
       

        

    }
}