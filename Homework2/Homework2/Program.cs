namespace Homework2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Task1
            ITask task = new Task1();
            task.Demo();

            // Task2
            task = new Task2();
            task.Demo();

            // Task3
            task = new Task3();
            task.Demo();

            // Task4
            task = new Task4();
            task.Demo();
        }
    }
}