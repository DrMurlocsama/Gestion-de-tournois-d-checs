using GestionEchecs.Command;
using GestionEchecs.DTO;
using GestionEchecs.Exeption;
using System.ComponentModel.DataAnnotations;
using TournoiEchec.DAL;
using TournoiEchec.DAL.Entities;

namespace GestionEchecs.Service
{
    public class TournoisService
    {
        public readonly TournoiContext _context;

        public TournoisService(TournoiContext context)
        {
            _context = context;
        }
        public void CreeTournoi(CreeUnTournoi cmd)
        {
            if (_context.Tournois.Any(t => t.Name.ToLower() == cmd.Name.ToLower()))
            {
                throw new CreeTournoiExeptions("Nom déja existant");
            }
            if(_context.Tournois.Any(t => t.Location.ToLower() == cmd.Location.ToLower()))
            {
                throw new CreeTournoiExeptions("Nom Localitaion déja existant");
            }
            if (cmd.NbJoueurMin >= cmd.NbJoueurMax)
            {
                throw new CreeTournoiExeptions("Erreur veuillez entrer le nombre de joueur entre 2 et 32 !");
            }
            if (cmd.Elomin >= cmd.EloMax)
            {
                throw new CreeTournoiExeptions("Erreur l'elo veuillez choisir un Elo entre 0 et 3000 !");
            }
            if (cmd.Status == Status.EnCour)
            {
                throw new Exception("Vous ne pouvez pas supprimer une partie en cours de jeux");
            }
            
            Tournois tournois = new Tournois
            {
                Name = cmd.Name,
                Location = cmd.Location,
                Status = cmd.Status,
                Categorie = cmd.Categorie,
                WomenOnly = cmd.WomenOnly,
                Création = cmd.Création,
                FinInscription = cmd.FinInscription,
                MiseAJour = cmd.MiseAJour,
                EloMax = cmd.EloMax ?? 3000,
                Elomin = cmd.Elomin ?? 0,
                NbJoueurMin = cmd.NbJoueurMin ?? 2,
                NbJoueurMax = cmd.NbJoueurMax ?? 32,
                RondeCourant = cmd.RondeCourant ?? 0,
            };
            tournois.FinInscription = DateTime.Now.AddDays((double)tournois.NbJoueurMin);
            tournois.Status = Status.Attende;
            tournois.Création = DateTime.Now;
            tournois.MiseAJour = tournois.Création;

            _context.Tournois.Add(tournois);
            _context.SaveChanges();
        }
        public void SupprimerTournoi(Guid id)
        {
            Tournois? tournois = _context.Tournois.FirstOrDefault(x => x.Id == id);
            if (tournois == null)
            {
                throw new KeyNotFoundException();
            }
            _context.Tournois.Remove(tournois);
            _context.SaveChanges();
        }
         public IEnumerable<TournoisDTO> get()
        {
            IEnumerable<TournoisDTO> results = _context.Tournois.Select(Tournois => new TournoisDTO
            {
                Id = Tournois.Id,
                Name = Tournois.Name,
                Location = Tournois.Location,
                //NbJoueurInscrit = Tournois.,
                NbMin = Tournois.NbJoueurMin,
                NbMax = Tournois.NbJoueurMax,
                Categorie = Tournois.Categorie,
                EloMin = Tournois.Elomin,
                EloMax = Tournois.EloMax,
                Status = Tournois.Status,
                DateFin = Tournois.FinInscription,
                RondeCourant = Tournois.RondeCourant,

            });
            return results;
        }
    }
}

