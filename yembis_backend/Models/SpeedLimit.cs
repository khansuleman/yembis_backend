using Microsoft.EntityFrameworkCore;
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
       
        public Categorie Categorie { get; set; }
        
        public Location Location { get; set; }

    }
}
