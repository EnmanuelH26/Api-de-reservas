using API.RESERVAS.Data;
using API.RESERVAS.Model;
using API.RESERVAS.Repository.IRepository;
using Microsoft.AspNetCore.Http.HttpResults;

namespace API.RESERVAS.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly EventoDbContext _db;


        public EventRepository(EventoDbContext db)
        {
            _db = db;
        }

        public bool CreateEvent(Event e)
        {
            return _db.Event.Add(e);
        }

        public Event ObtenerEvento(int Id)
        {
            return _db.Event.FirstOrDefault(e => e.EventId == Id);
        }

        public ICollection<Event> ObtenerEventos()
        {
            return _db.Event.OrderBy(e => e.EventId).ToList();
        }

        public bool reserve(int id)
        {
            throw new NotImplementedException();
        }
    }
}
