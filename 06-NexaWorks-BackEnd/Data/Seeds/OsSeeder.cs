using _06_NexaWorks_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace _06_NexaWorks_BackEnd.Data.Seeds
{
    public class OsSeeder
    {
        private readonly NexaWorksContext _context;

        public OsSeeder(NexaWorksContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.OS.Any())
            {
                _context.OS.AddRange(
                         new OS { NomOS = "Windows" },
                         new OS { NomOS = "Linux" },
                         new OS { NomOS = "MacOS" },
                         new OS { NomOS = "Android" },
                         new OS { NomOS = "iOS" },
                         new OS { NomOS = "Windows Mobile" }
                     );
                _context.SaveChanges();
            }
        }
    }
}
