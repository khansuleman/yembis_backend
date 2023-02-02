using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yembis_backend.Models
{
    
    public class SpeedLimit
    {
        [Key]
      public int LimitID { get; set; }

        public int CategorieID { get; set; }
       
        
        public int LocationID { get; set; }
        public int Snelheidslimiet { get; set; }

        [JsonIgnore]
        public Categorie Categorie { get; set; }
        [JsonIgnore]
        public Location Location { get; set; }

    }
}
