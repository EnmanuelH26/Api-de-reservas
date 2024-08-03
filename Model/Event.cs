using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.RESERVAS.Model
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Capacity { get; set; }

        public string Place { get; set; }
        public int HostId { get; set; }
        [ForeignKey("HostId")]
        public User user { get; set; }
    }
}
