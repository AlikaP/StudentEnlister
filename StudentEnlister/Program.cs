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
                if (string.Equals(operation, Operations.enlist , StringComparison.CurrentCultureIgnoreCase))
                {
                    
                    string ime;
                    string prezime;
                    string gpa = null;

                    bool imeLoop = true;
                    bool prezimeLoop = true;
                    bool gpaLoop = true;

                    Console.WriteLine("Student");

                    do
                    {
                        Console.WriteLine("First name:");
                        ime = Console.ReadLine();
                        if (String.IsNullOrEmpty(ime))
                        {
                            imeLoop = false;
                            Console.WriteLine("You need to insert value.");
                        }
                        else
                        {
                            imeLoop = true;
                        }
                    } while (!imeLoop);

                    do
                    {
                        Console.WriteLine("Last name:");
                        prezime = Console.ReadLine();
                        if (String.IsNullOrEmpty(prezime))
                        {
                            prezimeLoop = false;
                            Console.WriteLine("You need to insert value.");
                        }
                        else
                        {
                            prezimeLoop = true;
                        }
                    } while (!prezimeLoop);

                    do
                    {
                        Console.WriteLine("GPA:");
                        var gpaTest = Console.ReadLine();
                        if (!Validation.checkGPA(gpaTest))
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
                    student.Name = ime;
                    student.Surname = prezime;
                    student.GPA = gpa;

                    //id
                    StudentIdGenerator studentId = StudentIdGenerator.Instance();

                    studentId.CreateId();
                    student.Id = studentId.Id;
                                        
                    //spremanje u listu
                    studentContainer.StudentEnlist(student);
                    
                    loop = true;
                    
                }

                //display
                else if (string.Equals(operation, Operations.display, StringComparison.CurrentCultureIgnoreCase))
                {
                                   
                    StudentContainer container = StudentContainer.Instance();
                    var lista = container.ListReturn();

                    Console.WriteLine("Students in system");

                    var redni = 0;

                    foreach (var stud in lista)
                    {
                        redni++;
                        //stud.Id = redni;
                        //Console.WriteLine("{0}. {1}, {2} - {3}", stud.Id, stud.Surname, stud.Name, stud.GPA);
                        Console.WriteLine("{0}. {1}, {2} - {3}", redni, stud.Surname, stud.Name, stud.GPA);
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
