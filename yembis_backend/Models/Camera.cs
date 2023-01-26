using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yembis_backend.Models
{
    public class Camera
    {

        [Key]
        public int CameraID { get; set; }

        [Required]
        
        public string MacAddress { get; set; }


    }
}
