using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backSimulatorForBadDriver
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> values = new List<KeyValuePair<string, string>>();
            values.Add(new KeyValuePair<string, string>("##user", "bacana"));

            badDriverCore.utils.Email.sendEmail(@"C:\Users\oscar.l.casagrande\Source\Repos\baddriver\badDriverCore\badDriverWebMockup\emailTemplate\welcome.html",
                "oscar.casagrande@gmail.com",
                "oscar.casagrande@gmail.com",
                "teste",
                "teste",
                true,
                values);
        }
    }
}
