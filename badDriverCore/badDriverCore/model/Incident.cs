using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverCore.model
{
    public class Incident
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<Photo> Photos { get; set; }
        public Incident() { }
    }
}
