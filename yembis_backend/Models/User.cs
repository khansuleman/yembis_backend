using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yembis_backend.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }   
        public string Password { get; set; }
        [NotMapped]
        
        public string Token { get; set; }   
    }
}
