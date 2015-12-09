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

                //operation validation
                var operationEnlist = Validation.checkEnlist(operation);
                var operationDisplay = Validation.checkDisplay(operation);
                
                //ako je enlist poziva se enlist metoda
                if (operationEnlist == true)
                {
                    //enlist
                    var newStudent = Operations.Enlist();

                    //spremanje u listu
                    studentContainer.StudentEnlist(newStudent);
                    
                    loop = true;
                    
                }

                //ako je display, poziva se display metoda
                else if (operationDisplay == true)
                {
                    //display
                    Operations.Display();                  
                }

                else
                {
                    loop = true;
                    Console.WriteLine("Please insert existing operation (ENLIST/DISPLAY)");
                }                              

            } while (loop);

            Console.ReadKey();

        }
    }
}
