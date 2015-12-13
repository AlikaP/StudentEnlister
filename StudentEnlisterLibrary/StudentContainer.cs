using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    public class StudentContainer
    {
        private static StudentContainer _instance;

        List<Student> StudentList = new List<Student>();

        //dodavanje studenta u listu
        public void StudentEnlist(Student newStudent)
        {
            if (newStudent != null)
            {
                StudentList.Add(newStudent);
            }
        }

        //sortirana lista
        public List<Student> ListReturn()
        {
            // list of students sorted alphabetically (sorted by last name - ascending)
            List<Student> sortedList = StudentList.OrderBy(o => o.Surname).ToList();

            return sortedList;
        }
        
        public static StudentContainer Instance()
        {            
            if (_instance == null)
            {
                _instance = new StudentContainer();
            }

            return _instance;
        }
    }
}
