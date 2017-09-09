using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace badDriverCore.utils
{
    public static class Security
    {
        public static string NewPassword()
        {
            string result = string.Empty;

            result = Guid.NewGuid().ToString("d").Substring(1, 8);

            return result;
        }
    }
}
