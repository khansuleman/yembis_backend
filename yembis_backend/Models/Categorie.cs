using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yembis_backend.Models
{
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; }

        [Required] 
        public string TypeVoertuig { get; set; }
    }
}
