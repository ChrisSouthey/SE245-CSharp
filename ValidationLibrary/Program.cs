using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLibrary
{
    class ValidationLibrary
    {
        public static bool IsValidEmail(string temp)
        {
            bool blnResults = true;

            int atLocation = temp.IndexOf("@");
            int NextatLocation = temp.IndexOf("@", atLocation);

            int periodLocation = temp.LastIndexOf(".");

            if (temp.Length < 8)
            {
                blnResults = false;
            }
            else if (atLocation < 2)
            {
                blnResults = false;
            }
            else if (periodLocation + 2 > (temp.Length))
            {
                blnResults = false;
            }

            return blnResults;
        }
    }
}
