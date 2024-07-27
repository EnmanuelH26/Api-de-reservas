using API.RESERVAS.Data;
using API.RESERVAS.Model;
using API.RESERVAS.Repository.IRepository;

namespace API.RESERVAS.Repository
{
    public class EventosRepository : IEventosRepository
    {
        private readonly EventoDbContext _db;


        public EventosRepository(EventoDbContext db)
        {
            _db = db;
        }

        public ICollection<Eventos> ObtenerEventos()
        {
            return _db.Eventos.OrderBy(e => e.Id).ToList();
        }
    }
}
