namespace Homework3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orders = GenerateOrders(100);
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
        public static List<string> GenerateOrders(int amount)
        {
            var result = new List<string>();
            var random = new Random();
            for(int i = 0; i < amount; i++)
            {
                var date = new DateTime(2021, random.Next(1, 13), random.Next(1, 29));
                var analysis = random.Next(1, 8);
                if(i != amount - 1)
                {
                    result.Add($"('{date.Year}-{date.Month}-{date.Day}', {analysis}),");
                }
                else
                {
                    result.Add($"('{date.Year}-{date.Month}-{date.Day}', {analysis})");
                }
            }
            return result;
        }
    }
}