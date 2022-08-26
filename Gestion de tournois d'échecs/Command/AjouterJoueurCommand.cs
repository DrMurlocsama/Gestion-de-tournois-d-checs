using System.ComponentModel.DataAnnotations;
using TournoiEchec.DAL.Entities;

namespace GestionEchecs.Command
{
    public class AjouterJoueurCommand
    {

        [Required]
        public string Pseudo { get; set; } = string.Empty;
        [Required]
        public string Email { get; set; } = "";
        [Range(0, 3000)]
        public int? Elo { get; set; }
        [Required]
        public Genre Genre { get; set; }
        [Required]
        public DateTime DateNaiss { get; set; }
    }
}
