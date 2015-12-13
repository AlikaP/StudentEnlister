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

        public int Id = 0;

        protected StudentIdGenerator()
        {
            // ...
        }
        
        public int CreateId()
        {
            Id++;
            return Id;                
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
