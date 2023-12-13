namespace TechnicalSolution
{
    internal class Program
    {      
        static void Main(string[] args)
        {
            //65 is the offset for capital A
            List<string> unsorted = new List<string>();
            string lines = File.ReadAllText("names.txt").ToString(); //read the text file into the program as a string
            var results = lines.Split(","); //splits into an array, divided by the commas

            //convert the lines into an array to manipulate and read.
            for (int i = 0; i < results.Length; i++)
            {
                unsorted.Add(results[i].Replace("\"", "")); //this removes the unneeded speech marks
            }

            //test one, to make sure that the array is read correctly. 
            Console.WriteLine(unsorted[0]);

            List<string> sorted = unsorted.OrderBy(x => x).ToList(); //sorts the list into alphabetical order

            //test two, to see if the array has been sorted. 
            Console.WriteLine(sorted[0]);

            int testTotal = 0, subTotal = 0, finalTotal = 0;
            foreach (char each in sorted[0]) //gathers the alphabetical value of the first item in the sorted array
            {
                testTotal += each - 64; //offset is decreased by 1, to make sure the values are correct e.g. that 'A' returns 1
            }

            //test three, to make sure the alphabetical total functions work
            Console.WriteLine(testTotal);

            for (int i = 0; i < sorted.Count; i++)
            {
                foreach (char letter in sorted[i])
                {
                    subTotal += letter - 64; //gets the value for each letter in each word, 
                }
                //test four, to see if the function is working by testing the given example
                if (i == 937)
                {
                    Console.Write(sorted[i] + " ");
                    Console.WriteLine(subTotal);
                }

                finalTotal += subTotal * (i + 1); //multiplies the subtotal of each word by its position, with 1 added as i is initialised to 0
                subTotal = 0; //sets a new subtotal after each loop
            
            }

            //delivers the final total of the array
            Console.WriteLine(finalTotal);
        }
    }
}