using API.RESERVAS.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.RESERVAS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private readonly IEventosRepository _evr;
        public EventosController(IEventosRepository evr)
        {
            _evr = evr;
        }
        [HttpGet]
        public IActionResult GetEvento()
        {
            return Ok(_evr.ObtenerEventos());
        }
    }
}
