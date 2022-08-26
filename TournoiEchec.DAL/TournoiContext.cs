using Microsoft.EntityFrameworkCore;
using TournoiEchec.DAL.Entities;

namespace TournoiEchec.DAL
{
    public class TournoiContext : DbContext
    {
        public DbSet<Joueur> Joueurs { get; set; }
        public DbSet<Tournois> Tournois { get; set; }

        public TournoiContext(DbContextOptions options):base(options)
        {

        }
    }
}