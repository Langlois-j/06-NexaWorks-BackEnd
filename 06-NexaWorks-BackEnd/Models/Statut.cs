using System.ComponentModel.DataAnnotations;

namespace _06_NexaWorks_BackEnd.Models
{
    public class Statut
    {
        [Key]
        public int Id { get; set; }
        public string NomStatut { get; set; }
    }
}
