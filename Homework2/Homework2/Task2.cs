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
            // Check for possible null value
            if (input == null)
            {
                return -1;
            }

            // Find position of a first non space character
            int startIndex = 0;
            for (int i = 0; i < input.Length; i++, startIndex++)
            {
                if (input[i] != ' ')
                {
                    break;
                }
            }

            // Extract all digits from string
            var digits = input.Where(i => char.IsDigit(i))
                .Select(i => (int)char.GetNumericValue(i))
                .ToList();

            // Find index of first max digit
            if (digits != null && digits.Count() != 0)
            {
                int maxDigit = digits.Max();
                maxDigit += (int)'0';
                int index = input.IndexOf((char)maxDigit);
                index -= startIndex;
                return index;
            }

            return -1;
        }
    }
}