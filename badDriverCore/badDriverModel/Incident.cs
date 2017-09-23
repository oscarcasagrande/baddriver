using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverModel
{
    public class Incident
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<Photo> Photos { get; set; }
        public int Id { get; set; }
        public Incident() { }
        public int UserId { get; set; }
    }
}
