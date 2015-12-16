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
           
            do
            {

                //nudi se naredba
                Console.WriteLine("Operation:");
                operation = Console.ReadLine();
                                
                //enlist
                if (operation.Equals(Operations.enlist , StringComparison.CurrentCultureIgnoreCase))
                {                    
                    string name;
                    string surname;
                    string gpa = null;                   

                    Console.WriteLine("Student");

                    do
                    {
                        Console.WriteLine("First name:");
                        name = Console.ReadLine();
                        if (String.IsNullOrEmpty(name))
                        {
                            Console.WriteLine("You need to insert value.");
                        }
                        else
                        {
                            break;
                        }
                    } while (true);

                    do
                    {
                        Console.WriteLine("Last name:");
                        surname = Console.ReadLine();
                        if (String.IsNullOrEmpty(surname))
                        {
                            Console.WriteLine("You need to insert value.");
                        }
                        else
                        {
                            break;
                        }
                    } while (true);

                    do
                    {
                        Console.WriteLine("GPA:");
                        var gpaTest = Console.ReadLine();
                        if (!Validation.CheckGPA(gpaTest))
                        {
                            Console.WriteLine("You need to insert numerical value");
                        }
                        else
                        {
                            gpa = gpaTest;
                            break;
                        }
                    } while (true);

                    //student objekt
                    Student student = new Student();
                    student.Name = name;
                    student.Surname = surname;
                    student.GPA = gpa;
                                 
                    //spremanje u listu
                    studentContainer.StudentEnlist(student);
                    
                }

                //display
                else if (operation.Equals(Operations.display, StringComparison.CurrentCultureIgnoreCase))
                {                                   
                    StudentContainer container = StudentContainer.Instance();
                    var list = container.GetStudentList();

                    Console.WriteLine("Students in system");

                    var order = 0;

                    foreach (var student in list)
                    {
                        order++;
                        Console.WriteLine("{0}. {1}, {2} - {3}", order, student.Surname, student.Name, student.GPA);
                    }

                    break;
                }

                else
                {
                    Console.WriteLine("Please insert existing operation (enlist/display)");
                }                              

            } while (true);

            Console.ReadKey();

        }
    }
}
