using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNearestThousand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number :");
            bool isValidNumber = int.TryParse(Console.ReadLine(), out int userInput);
            if (isValidNumber)
            {
                userInput= FindNearestThousand(userInput);
                Console.WriteLine("The nearest thousand is :" + userInput);
            }

        }

        public static int FindNearestThousand(int number)
        {
            int nearestThousand = (int)Math.Round(number / 1000.0) * 1000;
                return nearestThousand;

        }
    }
}
