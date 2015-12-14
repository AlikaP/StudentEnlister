using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    public class StudentIdGenerator //SINGLETON
    {
        private static StudentIdGenerator _instance;

        private int previousId = 0;

        private StudentIdGenerator()
        {
            // ...
        }
        
        public int CreateId()
        {
            previousId++;  
            return previousId;                
        }
                
        public static StudentIdGenerator Instance()
        {
            if (_instance == null)
            {
                _instance = new StudentIdGenerator();
            }

            return _instance;
        }
    }
}
