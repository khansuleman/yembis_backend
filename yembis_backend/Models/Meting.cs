using System.ComponentModel.DataAnnotations;

namespace yembis_backend.Models
{
    public class Meting
    {
        [Key]
        public int MetingID { get; set; }
        public int CameraID { get; set; }
        public int TypeID { get; set; }
        [Required]
        public DateTime DatumTijd { get; set; }
        [Required]
        public int Snelheid { get; set; }
        [Required]
        public Boolean Overschreden { get; set; }

        public Type Type { get; set; }
        public Camera Camera { get; set; }
    }
}
