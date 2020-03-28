using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAgil.Repository;

namespace ProAgil.WebAPI.Controllers

{   [ApiController]
    [Route("api/[controller]")]
    public class PalestranteController : ControllerBase
    {
        private readonly IProAgilRepository _proAgilRepository;

        public PalestranteController(IProAgilRepository proAgilRepository )
        {
            _proAgilRepository = proAgilRepository;
        }

        
        [HttpGet("getByName/{name}")]
        public async Task<IActionResult> Get(string Name)
        {
            try
            {
                var results = await _proAgilRepository.GetAllPalestrantesAsyncByName(Name, true);
                return Ok(results);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }

        }

        [HttpGet("{PalestranteId}")]
        public async Task<IActionResult> Get(int PalestranteId)
        {
            try
            {
                var results = await _proAgilRepository.GetPalestranteAsyncById(PalestranteId, true);
                return Ok(results);
            }
            catch (System.Exception)
            {

                return this.StatusCode(StatusCodes.Status500InternalServerError, "Falha no banco de dados");
            }

        }
    }
}