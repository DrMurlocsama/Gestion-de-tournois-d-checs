using GestionEchecs.Command;
using GestionEchecs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionEchecs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TournoiController : ControllerBase
    {
        private readonly TournoisService _tournoisService;

        public TournoiController(TournoisService tournoisService)
        {
            _tournoisService = tournoisService;
        }

        [HttpPost]
        public IActionResult Cree(CreeUnTournoi cmd)
        {
            _tournoisService.CreeTournoi(cmd);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Supprimer([FromRoute] Guid id)
        {
            try
            {
                _tournoisService.SupprimerTournoi(id);
                return NoContent();
            }
            catch (KeyNotFoundException)
            {

                return NotFound();
            }
            
        }
        [HttpGet]
        public IActionResult Get()
        {
            
            return Ok(_tournoisService.get());
        }
    }
}
