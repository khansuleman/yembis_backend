using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace yembis_backend.Models
{
    public class Categorie
    {
        [Key]
        public int CategorieID { get; set; }

      
        public string TypeVoertuig { get; set; }
    }
}
