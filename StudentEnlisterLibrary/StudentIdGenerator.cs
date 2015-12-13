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

        public int id = 0;

        protected StudentIdGenerator()
        {
            // ...
        }
        
        public int CreateId()
        {
            id++;
            return id;                
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
