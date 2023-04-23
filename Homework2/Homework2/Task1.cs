using System.Net;

namespace Homework2
{
    public class Task1 : ITask
    {
        public void Demo()
        {
            // Generate input data
            Console.WriteLine("Task1 Demonstration");
            var input = new List<string>
            {
                null,
                "",
                "Hello, world!",
                "C# language first appeared in 2000, which was 23 years ago."
            };

            int sum = 0;
            int maxDigit = 0;
            foreach (var item in input)
            {
                // Print input data
                if (item == null)
                {
                    Console.WriteLine("Input: null");
                }
                else
                {
                    Console.WriteLine($"Input: '{item}'");
                }

                // Run algorithm
                SumAndMaxDigit(item, ref sum, ref maxDigit);

                // Print output data
                Console.WriteLine($"Output: sum - {sum}, max digit - {maxDigit}");
            }
            Console.WriteLine();
        }
        private void SumAndMaxDigit(string input, ref int sum, ref int maxDigit)
        {
            sum = 0;
            maxDigit = 0;

            // Check for possible null value
            if (input == null)
            {
                return;
            }

            // Extract all digits from string
            var digits = input.Where(i => char.IsDigit(i))
                .Select(i => (int)char.GetNumericValue(i));

            // Count sum and max value
            if (digits != null && digits.Count() != 0)
            {
                sum = digits.Sum();
                maxDigit = digits.Max();
            }
        }
    }
}