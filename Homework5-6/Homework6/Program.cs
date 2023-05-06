using System.Data.Common;
using Homework6.DB;
using Homework6.Demo;
using Homework6.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework6
{
    public class Program
    {
        private const string ConnectionString = "Data Source=LAPTOP-R9DA3P1V\\SQLEXPRESS;Initial Catalog = CHI_HW56; Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
        public static void Main(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OrdersDbContext>();
            builder.UseSqlServer(ConnectionString, s => s.EnableRetryOnFailure(5));
            using var ordersDbContext = new OrdersDbContext(builder.Options);

            ITask task = new Task3();
            task.Demo(ordersDbContext);

            task = new Task7();
            task.Demo(ordersDbContext);
        }
    }
}