using System.Text.Json.Serialization;

namespace components.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        public string? NombreCarrera { get; set; }
        public int IdUniversidades { get; set; }
           public ICollection <Universidad>universidades { get; set; }
        
    }
}