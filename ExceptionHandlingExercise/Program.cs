using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // DONE - First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // DONE - Create a list called numbers that will hold integers
            // DONE - Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------
            var arr = new char[]{ '1', '2', '3', '4', '5', '6', 'a', 'b', 'c'};
            var numbers = new List<int>();
            string str;



            //TODO START HERE:
            
            // Make a foreach loop to iterate through your character array
            foreach (var character in arr)
            {
                try
                {
                    str = char.ToString(character);
                    int numHolder = int.Parse(str);
                    numbers.Add(numHolder);
                }
                catch (Exception)
                {

                    Console.WriteLine($"Unable to Parse '{character}'");
                }
            }
            // Now create a try catch


            // Inside your try block
            // DONE - set your string variable to each array element in your char[] to .ToString()
            // DONE - Now, using int.Parse, parse your string variable and store in an int variable
            // DONE - Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }
    }
}
