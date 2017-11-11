using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverModel
{
    [Serializable]
    public class Driver
    {
        public int Id { get; set; }
        public string Label { get; set; }
        public string Model { get; set; }
        public string Supplier { get; set; }
        public string Color { get; set; }
        public int IncidentQuantity { get; set; }
        public List<Incident> Incidents { get; set; }

        public Driver() {
            this.Incidents = new List<Incident>();
        }
    }
}
