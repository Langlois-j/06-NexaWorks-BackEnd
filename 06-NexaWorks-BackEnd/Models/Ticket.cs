using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06_NexaWorks_BackEnd.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Produit")]
        public int IdProduit { get; set; }

        [ForeignKey("VersionProduit")]
        public int IdVersionProduit { get; set; }

        [ForeignKey("OS")]
        public int IdOs { get; set; }

        [ForeignKey("Statut")]
        public int IdStatut { get; set; }

        public  DateOnly CreationDate { get; set; }

        public DateOnly? ResolutionDate { get; set; }

        public string DescriptionTexte { get; set; }

        public string? ResolutionTexte { get; set; }
        public Produit Produit { get; set; }
        public VersionProduit VersionProduit { get; set; }
        public OS OS { get; set; }
        public Statut Statut { get; set; }
    }
}
