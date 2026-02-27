using System.ComponentModel.DataAnnotations;

namespace _06_NexaWorks_BackEnd.Models
{
    public class VersionProduit
    {
        [Key]
        public int Id { get; set; }
        public string NomVersion{ get; set; }
    }
}
