using API.RESERVAS.Model;
using Microsoft.EntityFrameworkCore;

namespace API.RESERVAS.Data
{
    public class EventoDbContext : DbContext
    {
        public EventoDbContext(DbContextOptions<EventoDbContext> options)
           : base(options) //metodo de la clase, hereda de base, sirve para recibir las entidades del db context
        {
        }
        public DbSet<Eventos> Eventos { get; set; }
    }
}
