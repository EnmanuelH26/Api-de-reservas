using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.RESERVAS.Model
{
    public class Attendance
    {
        [Key]
        public int AttendanceId { get; set;}
        public int EventId { get; set; }
        [ForeignKey("EventId")]
        public Event Event { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        public DateTime Date { get; set; }
    }
}
