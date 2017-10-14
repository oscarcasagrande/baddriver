using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverModel
{
    public class Photo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int IncidentId { get; set; }

        public Photo() { }
    }
}
