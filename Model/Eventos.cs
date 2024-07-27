using System.ComponentModel.DataAnnotations;

namespace API.RESERVAS.Model
{
    public class Eventos
    {
        [Key]
        public int? Id { get; set; }
        public string? nombre { get; set; }
        public string? Description { get; set; }
        public string? Lugar { get; set; }
        public DateTime FechaEvento { get; set; }
        public string Capacidad { get; set; }
    }
}
