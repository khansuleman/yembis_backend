using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace yembis_backend.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public int CameraID { get; set; }

        public string Gemeente { get; set; }
        public string Straat { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public Boolean Vrachtwagenvrijzone { get; set; }

        public DateTime BeginPeriode { get; set; }
        public DateTime EindPeriode { get; set; }
        public Boolean Current { get; set; }


        [JsonIgnore]
        public Camera? Camera { get; set; }
    }
}
