using _06_NexaWorks_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace _06_NexaWorks_BackEnd.Data.Seeds
{
    public class StatutSeeder
    {

        private readonly NexaWorksContext _context;

        public StatutSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Statuts.Any())
            {
                _context.Statuts.AddRange(
     new Statut { NomStatut = "En cours" },
     new Statut { NomStatut = "Résolu" });
                _context.SaveChanges();
            }
        }
    }
}
