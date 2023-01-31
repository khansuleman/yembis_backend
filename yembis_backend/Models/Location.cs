using System.ComponentModel.DataAnnotations;

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

        public DateOnly BeginPeriode { get; set; }
        public DateOnly EindPeriode { get; set; }
        public Boolean Current { get; set; }

        public Camera Camera { get; set; }
    }
}
