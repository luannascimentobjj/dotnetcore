using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAgil.Domain;
using ProAgil.Repository;
using System.Threading.Tasks;

namespace ProAgil.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IProAgilRepository _proAgilRepository;
        public EventoController(IProAgilRepository proAgilRepository)
        {
            _proAgilRepository = proAgilRepository;

        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _proAgilRepository.GetAllEventosAsync(true);
                return Ok(results);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }

        }



        [HttpGet("{EventoId}")]
        public async Task<IActionResult> Get(int EventoId)
        {
            try
            {
                var results = await _proAgilRepository.GetEventoAsyncById(EventoId, true);
                return Ok(results);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }

        }
        [HttpGet("getByTema/{tema}")]
        public async Task<IActionResult> Get(string Tema)
        {
            try
            {
                var results = await _proAgilRepository.GetAllEventosAsyncByTema(Tema, true);
                return Ok(results);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }

        }

        [HttpPost]
        public async Task<IActionResult> Post(Evento evento)
        {
            try
            {
                _proAgilRepository.Add(evento);
                if (await _proAgilRepository.SaveChangesAsync())
                {
                    return Created($"/api/evento/{evento.Id}", evento);
                }
                
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }
            return BadRequest();

        }

        [HttpPut]
        public async Task<IActionResult> Put(int EventoId, Evento eventoDomain)
        {
            try
            {
                var evento = await _proAgilRepository.GetEventoAsyncById(EventoId, false);
                if (evento == null) return NotFound();

                _proAgilRepository.Update(eventoDomain);

                if (await _proAgilRepository.SaveChangesAsync())
                {
                    return Created($"/api/evento/{eventoDomain.Id}", eventoDomain);
                }

            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }
            return BadRequest();

        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int EventoId)
        {
            try
            {
                var evento = await _proAgilRepository.GetEventoAsyncById(EventoId, false);
                if (evento == null) return NotFound();

                _proAgilRepository.Delete(evento);

                if (await _proAgilRepository.SaveChangesAsync())
                {
                    return Ok();
                }

            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }
            return BadRequest();

        }
    }
}
