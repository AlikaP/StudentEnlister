using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    public class Validation
    {                            
        public static bool CheckGPA(string gpa)
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
