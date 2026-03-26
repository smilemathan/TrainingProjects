using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LoopingTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            //If Condtion Tutorial
            Console.WriteLine("Enter Your Age");
            Boolean isValidAge =int.TryParse(Console.ReadLine(),out int personAge);
            if (isValidAge)
            {   
                Console.WriteLine ("You entered age is :" + personAge);

                if(personAge<18)
                {
                    Console.WriteLine("You are not eligible to vote");
                }
                else if (personAge == 18)
                {
                    Console.WriteLine("Congratulations! You are eligible to vote for the first time");
                }
                else if (personAge > 18 && personAge < 100)
                {
                    Console.WriteLine("You are eligible to vote");
                }
                else
                {
                    Console.WriteLine("You are eligible to vote");
                }
            }
            else
            {
                Console.WriteLine("You entered invalid age");
            }

            Console.ReadLine();


        }
    }
}
