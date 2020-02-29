using System;
using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<Evento> Get()
        {
          return _context.Eventos.ToList();
        }

        
        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            yield return new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular e .NET Core",
                    Local = "Niterói",
                    Lote = "1º Lote",
                    QtdPessoas = 25,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")

                },  new Evento() {
                    EventoId = 2,
                    Tema = "Angular e suas novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 35,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")

                }
            }.FirstOrDefault(x => x.EventoId == id);
        }

    }
}