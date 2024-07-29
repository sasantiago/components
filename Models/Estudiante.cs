using System.Text.Json.Serialization;

namespace components.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Correo { get; set; }
        public string? Celular { get; set; }

        // [JsonIgnore]
        // public List<Matricula>? Matriculas { get; set; }
    }
}