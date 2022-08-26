using GestionEchecs.Command;
using System.ComponentModel.DataAnnotations;
using TournoiEchec.DAL;
using TournoiEchec.DAL.Entities;

namespace GestionEchecs.Service
{
    public class JoueurService
    {
        private readonly TournoiContext _context;

        public JoueurService(TournoiContext context)
        {
            _context = context;
        }

        public  void AjouterJoueur(AjouterJoueurCommand cmd)
        {
            // controler les regles metiers
            if (_context.Joueurs.Any(t => t.Pseudo.ToLower() == cmd.Pseudo.ToLower()))
            {
                throw new ValidationException("Pseudo déja existant");
            }
            if (_context.Joueurs.Any(t => t.Email.ToLower() == cmd.Email.ToLower()))
            {
                throw new ValidationException("Email déja existant");
            }
            Joueur newjoueur = new Joueur
            {
                Pseudo = cmd.Pseudo,
                Email = cmd.Email,
                Genre = cmd.Genre,
                DateNaiss = cmd.DateNaiss,
                Elo = cmd.Elo ?? 1200
            };
            _context.Joueurs.Add(newjoueur);
            _context.SaveChanges();
        }
    }
}
