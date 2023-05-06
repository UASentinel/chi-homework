using System.Configuration;
using Homework5.Demo;
using Homework5.Models;
using Homework5.Repository;

namespace Homework5
{
    public class Program
    {
        private const string ConnectionString = "Data Source=LAPTOP-R9DA3P1V\\SQLEXPRESS;Initial Catalog = CHI_HW56; Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
        public static void Main(string[] args)
        {
            var ordersRepository = new OrdersRepository(ConnectionString);

            ITask task = new Task1();
            task.Demo(ordersRepository);

            task = new Task2();
            task.Demo(ordersRepository);

            task = new Task4();
            task.Demo(ordersRepository);

            task = new Task5();
            task.Demo(ordersRepository);

            task = new Task6();
            task.Demo(ordersRepository);
        }
    }
}