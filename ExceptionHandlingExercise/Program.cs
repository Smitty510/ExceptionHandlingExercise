using System;
using System.Collections.Generic;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers
            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------

            char[] arr = { 'A', 'B', 'C', '1', '2', '3', '4', '5', '6' }; //this is a character array
            List<int> numbers = new List<int>(); //this is a number list
            string str = string.Empty;

            //TODO START HERE:

            // Make a foreach loop to iterate through your character array
            Console.WriteLine("Exception Messages: ");
            Console.WriteLine();
            foreach (var item in arr)
            {


                // Now create a try catch

                try
                {
                    str = item.ToString(); //parsing character to a string
                    int num = int.Parse(str); //parsing string to an int
                    numbers.Add(num); //adding number to the list
                }
                catch (Exception)
                {
                    Console.WriteLine($"Unable to Parse '{item}'"); //special message written out if 
                }
            }

            Console.WriteLine();
            Console.WriteLine("Numbers in my list: ");
            Console.WriteLine();
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
