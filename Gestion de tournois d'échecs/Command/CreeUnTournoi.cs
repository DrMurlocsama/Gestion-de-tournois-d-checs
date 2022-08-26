using System.ComponentModel.DataAnnotations;
using TournoiEchec.DAL.Entities;

namespace GestionEchecs.Command
{
    public class CreeUnTournoi
    {
        [Required]
        public string? Name { get; set; } = string.Empty;
        [Required]
        public string? Location { get; set; }
        [Range(2 , 32)]
        public int? NbJoueurMin { get; set; }
        [Range(2, 32)]
        public int? NbJoueurMax { get; set; }
        [Range(0, 3000)]
        public int? EloMax { get; set; }
        [Range(0, 3000)]
        public int? Elomin { get; set; }
        public Status Status { get; set; }
        [Required]
        public Categorie Categorie { get; set; }
        public DateTime Création { get; set; }
        public DateTime FinInscription { get; set; }
        public DateTime MiseAJour { get; set; }
        public bool WomenOnly { get; set; }
        public int? RondeCourant { get; set; }

    }
}
