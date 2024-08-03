using API.RESERVAS.Model;
using ApiPelicula.Model;
using Microsoft.EntityFrameworkCore;

namespace API.RESERVAS.Data
{
    public class EventoDbContext : DbContext
    {
        public EventoDbContext(DbContextOptions<EventoDbContext> options)
           : base(options) //metodo de la clase, hereda de base, sirve para recibir las entidades del db context
        {
        }
        public DbSet<Event> Event { get; set; }
        //public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Category_Event> Category_Event { get; set; }
        //public DbSet<Feedback> Feedback { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<User> User { get; set; }
    }
}
