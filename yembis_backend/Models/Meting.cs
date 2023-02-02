using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace yembis_backend.Models
{
    public class Meting
    {
        [Key]
      
        public int MetingID { get; set; }
       
        public int CameraID { get; set; }
      
        public int CategorieID { get; set; }

        public int LocationID { get; set; } 
      
        public DateTime DatumTijd { get; set; }
      
        public int Snelheid { get; set; }
    
        [JsonIgnore]
        public Boolean Overschreden { get; set; }
        [JsonIgnore]
        public Categorie? Categorie { get; set; }
        [JsonIgnore]
        public Camera? Camera { get; set; }


    }
}
