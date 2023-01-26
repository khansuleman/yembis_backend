using System.ComponentModel.DataAnnotations;

namespace yembis_backend.Models
{
    public class Type
    {
        [Key]
        public int TypeID { get; set; }

        [Required]
        public string TypeVoertuig { get; set; } 
    }
}
