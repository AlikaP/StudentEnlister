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

        private List<Student> studentList = new List<Student>();

        //dodavanje studenta u listu
        public void StudentEnlist(Student newStudent)
        {
            if (newStudent != null)
            {
                studentList.Add(newStudent);
            }
        }

        //sortirana lista
        public List<Student> GetStudentList()
        {
            // list of students sorted alphabetically (sorted by last name - ascending)
            List<Student> sortedList = studentList.OrderBy(o => o.Surname).ToList();

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
