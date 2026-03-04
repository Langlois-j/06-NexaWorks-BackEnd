using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _06_NexaWorks_BackEnd.Models
{
    public class VersionProduitOS
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("VersionProduit")]
        public int IdVersionProduit { get; set; }

        [ForeignKey("OS")]
        public int IdOs { get; set; }

        public VersionProduit VersionProduit { get; set; }
        public OS OS { get; set; }
    }
}
