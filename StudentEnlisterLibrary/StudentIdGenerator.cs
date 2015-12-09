using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    class StudentIdGenerator //SINGLETON
    {
        private static StudentIdGenerator _instance;

        public int Id;

        public void CreateId()
        {
            StudentContainer a = StudentContainer.Instance();
            var lista = a.ListReturn();

            if (lista != null)
            {
                
                var count = 0;
                                
                foreach(var stud in lista)
                {
                    count++;   
                }
                                
                Id = count+1;
            }
                           
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
