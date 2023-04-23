using System.Net;

namespace Homework2
{
    public class Task2 : ITask
    {
        public void Demo()
        {
            // Generate input data
            Console.WriteLine("Task2 Demonstration");
            var input = new List<string>
            {
                null,
                "",
                "         ",
                "         23 years ago, C# language first appeared. The current year is 2023."
            };

            foreach (var item in input)
            {
                // Print input data
                if(item == null)
                {
                    Console.WriteLine("Input: null");
                }
                else
                {
                    Console.WriteLine($"Input: '{item}'");
                }

                // Run algorithm
                int index = MaxDigitIndex(item);

                // Print output
                Console.WriteLine($"Output: {index}");
            }
            Console.WriteLine();
        }
        private int MaxDigitIndex(string input)
        {
            int maxDigit = -1;
            int index = -1;

            // Check for possible null value
            if (input == null)
            {
                return -1;
            }

            // Find position of a first non space character
            int startIndex = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    break;
                }
                startIndex++;
            }

            // Start searching from that position
            for (int i = startIndex; i < input.Length; i++)
            {
                // If max digit is already 9 we can quit
                if(maxDigit == 9)
                {
                    return index;
                }
                // Find index of a max digit
                if (char.IsDigit(input[i]))
                {
                    int currentDigit = (int)char.GetNumericValue(input[i]);
                    if (currentDigit > maxDigit)
                    {
                        maxDigit = currentDigit;
                        index = i - startIndex;
                    }
                }
            }
            return index;
        }
    }
}