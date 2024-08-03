using System.ComponentModel.DataAnnotations;

namespace API.RESERVAS.Model.Dto
{
    public class CrearEventoDto
    {
        [Required]
        public string? nombre { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public string? Lugar { get; set; }
        [Required]
        public DateTime FechaEvento { get; set; }
    }
}
