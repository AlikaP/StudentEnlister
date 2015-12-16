using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    public abstract class Person
    {
        //person properties
        public string Name { get; set; }
        public string Surname { get; set; }
        private int Id { get; set; }

        public Person()
        {
            StudentIdGenerator studentId = StudentIdGenerator.Instance();

            Id = studentId.CreateId();
        }     

    }
}
