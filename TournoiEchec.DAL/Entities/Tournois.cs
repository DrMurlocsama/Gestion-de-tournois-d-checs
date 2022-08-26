using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoiEchec.DAL.Entities
{
    public class Tournois
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } = string.Empty;
        public string? Location { get; set; }
        public int? NbJoueurMin { get; set; }
        public int? NbJoueurMax { get; set; }
        public int? EloMax { get; set; }
        public int? Elomin { get; set; }
        public Status Status { get; set; }
        public Categorie Categorie { get; set; }
        public DateTime Création { get; set; }
        public DateTime FinInscription { get; set; }
        public DateTime MiseAJour { get; set; }
        public bool WomenOnly { get; set; }
        public int? RondeCourant { get; set; }



    }
}
