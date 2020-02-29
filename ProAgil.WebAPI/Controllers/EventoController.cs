using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.WebAPI.Data;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;
        private readonly DataContext _context;

        public EventoController(ILogger<EventoController> logger, DataContext context)
        {
            _logger = logger;
            _context =  context;

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results = _context.Eventos.ToList();   
                return Ok(results);
            }
            catch (System.Exception)
            {
                
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }
          
        }

        
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            yield return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

    }
}