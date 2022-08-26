using GestionEchecs.Command;
using GestionEchecs.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestionEchecs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JoueurController : ControllerBase
    {
        private readonly JoueurService _joueurService;

        public JoueurController(JoueurService joueurService)
        {
            _joueurService = joueurService;
        }

        [HttpPost]
        public IActionResult Ajouter(AjouterJoueurCommand cmd) 
        {
            _joueurService.AjouterJoueur(cmd);
            return Ok();
        }

    }
}
