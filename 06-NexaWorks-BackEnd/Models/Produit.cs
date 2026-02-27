using System.ComponentModel.DataAnnotations;

namespace _06_NexaWorks_BackEnd.Models
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public string NomProduit { get; set; }
    }
}
