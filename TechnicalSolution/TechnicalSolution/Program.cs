using System;
using System.Security.Cryptography.X509Certificates;

namespace TechnicalSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> unsorted = new List<string>();
            string lines = File.ReadAllText(@"names.txt").ToString(); //read the text file into the program as a string
            var results = lines.Split(","); //splits into an array, divided by the commas

            //convert the lines into an array to manipulate and read.
            for (int i = 0; i < results.Length; i++)
            {
                unsorted.Add(results[i].Replace("\"", "")); //this removes the unneeded speech marks
            }

            //test one, to make sure that the array is read correctly. 
            Console.WriteLine(unsorted[0]);

            List<string> sorted = unsorted.OrderBy(x => x).ToList(); //sorts the list into alphabetical order.


            //test two, to see if the array has been sorted. 
            Console.WriteLine(sorted[0]);


            for (int i = 0; i < sorted[0].Length; i++)
            {

            }
        }
    }
}