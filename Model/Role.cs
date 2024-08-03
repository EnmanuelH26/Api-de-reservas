using System.ComponentModel.DataAnnotations;

namespace API.RESERVAS.Model
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public enum RoleType
        {
            admin,
            organizer,
            user
        }
    }
}
