using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNearestThousand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FindNearestThousand(5);

            }
            catch (Exception ex)
            {
                PrintErrorDetails(ex);
            }
            

            

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
            try
            {
                SwitchCaseLearning();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            int nearestThousand = (int)Math.Round(number / 1000.0) * 1000;
                return nearestThousand;

        }

        public static void SwitchCaseLearning()
        {
            try
            {
                int j = 1;
                int k = 0;
                int i = Convert.ToInt32(j / k);
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }

        public static void PrintErrorDetails(Exception ex)
        {


            var st = new System.Diagnostics.StackTrace(ex, true);

            // Get all frames in the call sequence
            var frames = st.GetFrames();

            foreach (var frame in frames)
            {
                var method = frame.GetMethod();
                Console.WriteLine($"Method: {method.DeclaringType.Name}.{method.Name}");
                Console.WriteLine($"Location: {frame.GetFileName()} Line: {frame.GetFileLineNumber()}");
                Console.WriteLine("-----------------------------------");
            }

        }
    }
}
