using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEnlisterLibrary;

namespace StudentEnlister
{
    class Program
    {
        static void Main(string[] args)
        {            
            //lista studenata
            StudentContainer studentContainer = StudentContainer.Instance();  
                                    
            string operation;
            bool loop;
           
            do
            {
                loop = false;                             
               
                //nudi se naredba
                Console.WriteLine("Operation:");
                operation = Console.ReadLine();
                                
                //enlist
                if (operation.Equals(Operations.enlist , StringComparison.CurrentCultureIgnoreCase))
                {                    
                    string name;
                    string surname;
                    string gpa = null;

                    bool nameLoop = true;
                    bool surnameLoop = true;
                    bool gpaLoop = true;

                    Console.WriteLine("Student");

                    do
                    {
                        Console.WriteLine("First name:");
                        name = Console.ReadLine();
                        if (String.IsNullOrEmpty(name))
                        {
                            nameLoop = false;
                            Console.WriteLine("You need to insert value.");
                        }
                        else
                        {
                            nameLoop = true;
                        }
                    } while (!nameLoop);

                    do
                    {
                        Console.WriteLine("Last name:");
                        surname = Console.ReadLine();
                        if (String.IsNullOrEmpty(surname))
                        {
                            surnameLoop = false;
                            Console.WriteLine("You need to insert value.");
                        }
                        else
                        {
                            surnameLoop = true;
                        }
                    } while (!surnameLoop);

                    do
                    {
                        Console.WriteLine("GPA:");
                        var gpaTest = Console.ReadLine();
                        if (!Validation.CheckGPA(gpaTest))
                        {
                            gpaLoop = false;
                            Console.WriteLine("You need to insert numerical value");
                        }
                        else
                        {
                            gpaLoop = true;
                            gpa = gpaTest;
                        }
                    } while (!gpaLoop);

                    //student objekt
                    Student student = new Student();
                    student.Name = name;
                    student.Surname = surname;
                    student.GPA = gpa;

                    //id
                    StudentIdGenerator studentId = StudentIdGenerator.Instance();

                    student.Id = studentId.CreateId();
                                 
                    //spremanje u listu
                    studentContainer.StudentEnlist(student);
                    
                    loop = true;
                    
                }

                //display
                else if (operation.Equals(Operations.display, StringComparison.CurrentCultureIgnoreCase))
                {                                   
                    StudentContainer container = StudentContainer.Instance();
                    var list = container.GetSortedList();

                    Console.WriteLine("Students in system");

                    var order = 0;

                    foreach (var student in list)
                    {
                        order++;
                        //stud.Id = redni;
                        //Console.WriteLine("{0}. {1}, {2} - {3}", stud.Id, stud.Surname, stud.Name, stud.GPA);
                        Console.WriteLine("{0}. {1}, {2} - {3}", order, student.Surname, student.Name, student.GPA);
                    }
                }

                else
                {
                    loop = true;
                    
                    Console.WriteLine("Please insert existing operation (enlist/display)");
                }                              

            } while (loop);

            Console.ReadKey();

        }
    }
}
