using _06_NexaWorks_BackEnd.Data.Seeds;
using _06_NexaWorks_BackEnd.Models;

namespace _06_NexaWorks_BackEnd.Data
{
    public class DataSeeder
    {
        private readonly NexaWorksContext _context;

        public DataSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            new OsSeeder(_context).Seed();
            new StatutSeeder(_context).Seed();
            new ProduitSeeder(_context).Seed();
            new VersionProduitSeeder(_context).Seed();
            new VersionProduitOsSeeder(_context).Seed();
            new TicketSeeder(_context).Seed();
        }
    }
}