using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Activity_Chris
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

        public static bool IsAFutureDate(DateTime temp)
        {
            bool blnResults;

            if (temp <= DateTime.Now)
            {
                blnResults = false;
            }
            else
            {
                blnResults = true;
            }

            return blnResults;
        }

        public static bool IsMinumumAmount(int temp, int min)
        {
            bool blnResults;

            if (temp >= min)
            {
                blnResults = true;
            }
            else
            {
                blnResults = false;
            }

            return blnResults;
        }

        public static bool IsMinumumAmount(double temp, double min)
        {
            bool blnResults;

            if (temp >= min)
            {
                blnResults = true;
            }
            else
            {
                blnResults = false;
            }

            return blnResults;
        }
    }
}
