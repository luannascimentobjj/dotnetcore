using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProAgil.Repository;
using ProAgil.Domain;

namespace ProAgil.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;
        private readonly ProAgilContext _context;

        public EventoController(ILogger<EventoController> logger, ProAgilContext context)
        {
            _logger = logger;
            _context =  context;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.Eventos.ToListAsync();   
                return Ok(results);
            }
            catch (System.Exception)
            {
                
               return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }
          
        }

        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var results = await _context.Eventos.FirstOrDefaultAsync(x => x.Id == id);    
                return Ok(results);
            }
              catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }
            
        }

    }
}