using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    public abstract class Person
    {
        //student properties
        public string name { get; set; }
        public string surname { get; set; }
        public string gpa { get; set; }
        public int id { get; set; }
    }
}
