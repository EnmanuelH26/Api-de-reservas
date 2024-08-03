using API.RESERVAS.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.RESERVAS.Controllers
{
    [Route("api/Events")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _evr;
        public EventController(IEventRepository evr)
        {
            _evr = evr;
        }
        [HttpGet]
        public IActionResult GetEvento()
        {
            return Ok(_evr.ObtenerEventos());
        }

        [HttpGet("{Id:int}", Name = "GetOneEvento")]
        [ProducesResponseType(204)] 
        [ProducesResponseType(200)] 
        [ProducesResponseType(500)] 
         public IActionResult GetOneEvento(int Id)
        {
            if (Id == 0)
            {
                return BadRequest("The 0 is not a option.");
            }

            if (_evr.ObtenerEvento(Id) == null)
            {
                return BadRequest("The null is not a option.");
            }
            return Ok(_evr.ObtenerEvento(Id));
        }
    }
}
