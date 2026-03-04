using System.ComponentModel.DataAnnotations;

namespace _06_NexaWorks_BackEnd.Models
{
    public class OS
    {
        [Key]
        public int Id { get; set; }
        public string NomOS { get; set; }
    }
}
