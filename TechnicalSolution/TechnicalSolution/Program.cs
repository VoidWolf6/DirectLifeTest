namespace TechnicalSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string[]> unsorted = new List<string[]>();
            var lines = File.ReadAllLines("names.txt"); //read the text file into the program

            for (int i = 0; i < lines.Length; i++) //convert the lines into an array to manipulate and read. 
            {
                unsorted[i] = lines[i].Split(' ');
            }

            //test one, to make sure that the array is read correctly. 
            Console.WriteLine(unsorted[0]);

            //test two, to see if the array has been sorted. 

        }
    }
}