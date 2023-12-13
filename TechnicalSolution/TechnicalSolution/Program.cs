namespace TechnicalSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("names.txt"); //read the text file into the program

            for (int i = 0; i < lines.Length; i++) //convert the lines into an array to manipulate and read. 
            {
                var unsorted = lines[i].Split(' ');
            }

            //test one, to make sure that the array is read correctly. 
            Console.WriteLine(lines[0]);

            //test two, to see if the array has been sorted. 

        }
    }
}