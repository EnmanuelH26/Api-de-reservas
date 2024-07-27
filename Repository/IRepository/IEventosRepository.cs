using API.RESERVAS.Model;

namespace API.RESERVAS.Repository.IRepository
{
    public interface IEventosRepository
    {
        ICollection<Eventos> ObtenerEventos();
    }
}
