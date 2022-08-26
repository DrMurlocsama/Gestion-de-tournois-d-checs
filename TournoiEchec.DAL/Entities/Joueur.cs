using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournoiEchec.DAL.Entities
{
    public class Joueur
    {
        public Guid Id { get; set; }
        public string Pseudo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime DateNaiss { get; set; }
        public int? Elo { get; set; }
        public string Role { get; set; } = string.Empty;
        public Genre Genre { get; set; }
    }
}
