using API.RESERVAS.Model;

namespace API.RESERVAS.Repository.IRepository
{
    public interface IEventRepository
    {
        //Obtener todos los eventos
        ICollection<Event> ObtenerEventos();
        //Obtener un solo evento
        Event ObtenerEvento(int Id);

        bool CreateEvent(Event events);
        bool reserve(int id);
    }
}
