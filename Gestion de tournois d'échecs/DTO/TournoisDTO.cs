using TournoiEchec.DAL.Entities;

namespace GestionEchecs.DTO
{
    public class TournoisDTO
    {
        public  Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int NbJoueurInscrit { get; set; }
        public int? NbMin { get; set; }
        public int? NbMax { get; set; }
        public Categorie Categorie{ get; set; }
        public int? EloMin { get; set; }
        public int? EloMax { get; set; }
        public Status Status{ get; set; }
        public DateTime DateFin { get; set; }
        public int? RondeCourant { get; set; }
    }
}
