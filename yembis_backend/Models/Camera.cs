using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace yembis_backend.Models
{
    public class Camera
    {

        [Key]
        public int CameraID { get; set; }


      
        public string MacAddress { get; set; }


    }
}
