using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    public static class Validation
    {
        public static bool checkEnlist(string enlist)
        {
            if (String.Compare(enlist, "enlist", true) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkDisplay(string display)
        {
            if (String.Compare(display, "display", true) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool checkIfNull(string input)
        {
            if (input == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
                
        public static bool checkGPA(string gpa)
        {
            float value;

            if (float.TryParse(gpa, out value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
