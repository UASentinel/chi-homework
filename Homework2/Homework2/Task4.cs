using System.Net;
using System.Runtime.ExceptionServices;

namespace Homework2
{
    public class Task4 : ITask
    {
        public void Demo()
        {
            // Generate input data
            Console.WriteLine("Task4 Demonstration");
            int[] input = new int[40];
            var random = new Random();

            // Print input data
            Console.Write("Input: ");
            for (int i = 0; i < 40; i++)
            {
                input[i] = random.Next(200, 450);
                Console.Write($"{input[i]} ");
            }

            // Run algorithm
            Console.WriteLine();
            int firstIndex = -1;
            int lastIndex = -1;
            MaxSpeedIndex(input, ref firstIndex, ref lastIndex);

            // Print output
            Console.WriteLine($"Output: first index - {firstIndex}, last index - {lastIndex}");

            // Generate alternative input data
            input[random.Next(0, 40)] = 451;
            input[random.Next(0, 40)] = 451;

            // Print input data
            Console.Write("Input: ");
            for (int i = 0; i < 40; i++)
            {
                Console.Write($"{input[i]} ");
            }

            // Run algorithm
            Console.WriteLine();
            firstIndex = -1;
            lastIndex = -1;
            MaxSpeedIndex(input, ref firstIndex, ref lastIndex);

            // Print output
            Console.WriteLine($"Output: first index - {firstIndex}, last index - {lastIndex}");
            Console.WriteLine();
        }
        private void MaxSpeedIndex(int[] input, ref int firstIndex, ref int lastIndex)
        {
            firstIndex = -1;
            lastIndex = -1;

            // Check for possible null value
            if (input == null)
            {
                return;
            }

            // Find max speed value
            int maxSpeed = input.Max(i => i);
            var inputList = input.ToList();

            // Find indexes of first and last max speed values
            firstIndex = inputList.IndexOf(maxSpeed);
            lastIndex = inputList.LastIndexOf(maxSpeed);

            // Check if these indexes refer to the same item
            if(firstIndex == lastIndex)
            {
                lastIndex = -1;
            }
        }
    }
}