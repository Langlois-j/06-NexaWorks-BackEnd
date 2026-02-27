using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06_NexaWorks_BackEnd.Models
{
    public class VersionProduit
    {
        [Key]
        public int Id { get; set; }
        public string NomVersion{ get; set; }
        [ForeignKey("Produit")]
        public int IdProduit { get; set; }

        public Produit Produit { get; set; }
    }
}
