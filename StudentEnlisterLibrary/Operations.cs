using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnlisterLibrary
{
    public static class Operations
    {
        public static Student Enlist()
        {
            string ime;
            string prezime;
            string _gpa = null;

            bool a = true;
            bool b = true;
            bool c = true;

            Console.WriteLine("Student");

            do {
                Console.WriteLine("First name:");
                ime = Console.ReadLine();
                if (Validation.checkIfNull(ime) == false)
                {
                    a = false;
                    Console.WriteLine("You need to insert value.");
                }
                else
                {
                    a = true;
                }
            } while (!a);

            do { 
                Console.WriteLine("Last name:");
                prezime = Console.ReadLine();
                if (Validation.checkIfNull(prezime) == false)
                {
                    b = false;
                    Console.WriteLine("You need to insert value.");
                }
                else
                {
                    b = true;
                }
            } while (!b);

            do {
                Console.WriteLine("GPA:");
                var gg = Console.ReadLine();
                if (Validation.checkGPA(gg) == false)
                {
                    c = false;
                    Console.WriteLine("You need to insert numerical value");
                }
                else
                {
                    c = true;
                    _gpa = gg;
                }
            } while (!c);

            //student objekt
            Student student = new Student();
            student.name = ime;
            student.surname = prezime;
            student.gpa = _gpa;

            //id
            StudentIdGenerator StudentId = StudentIdGenerator.Instance();

            StudentId.CreateId();
            student.id = StudentId.Id;

            return student;
        }

        public static void Display()
        {
            StudentContainer a = StudentContainer.Instance();
            var lista = a.ListReturn();

            Console.WriteLine("Students in system");

            var redni = 0;

            foreach (var stud in lista)
            {                 
                redni++;
                //stud.id = redni;
                // Console.WriteLine("{0}. {1}, {2} - {3}", stud.id, stud.surname, stud.name, stud.gpa);
                Console.WriteLine("{0}. {1}, {2} - {3}", redni, stud.surname, stud.name, stud.gpa);
            }
         
        }

    }
}
