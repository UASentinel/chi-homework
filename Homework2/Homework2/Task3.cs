using System.Net;

namespace Homework2
{
    public class Task3 : ITask
    {
        public void Demo()
        {
            // Generate input data
            Console.WriteLine("Task3 Demonstration");
            int[] input = new int[100];
            var random = new Random();

            // Print input data
            Console.Write("Input: ");
            for (int i = 0; i < 100; i++)
            {
                input[i] = random.Next(1, 1000);
                Console.Write($"{input[i]} ");
            }
            Console.WriteLine();

            // Run algorithm
            int maxPageCount = MaxPageCount(input);

            // Print output
            Console.WriteLine($"Output: {maxPageCount}");
            Console.WriteLine();
        }
        private int MaxPageCount(int[] input)
        {
            int maxPageCount = -1;
            for(int i = 0; i < input.Count(); i++)
            {
                // Check if pageCount is greater then maxPageCount
                if (input[i] > maxPageCount)
                {
                    maxPageCount = input[i];
                }
            }
            return maxPageCount;
        }
    }
}