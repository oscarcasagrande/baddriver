using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverCore.model
{
    public class Incident
    {
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public List<Photo> Photos { get; set; }
        public Incident() { }
    }
}
