using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverModel
{
    public class Incident
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<Photo> Photos { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DriverId { get; set; }

        public Incident()
        {
            this.Photos = new List<Photo>();
        }
    }
}
