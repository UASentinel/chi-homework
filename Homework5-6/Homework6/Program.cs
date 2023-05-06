using System.Data.Common;
using Homework6.DB;
using Homework6.Models;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework6
{
    public class Program
    {
        //private const string ConnectionString = "Data Source=LAPTOP-R9DA3P1V\\SQLEXPRESS;Initial Catalog = CHI_HW56; Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
        private const string ConnectionString = "Data Source=LAPTOP-R9DA3P1V\\SQLEXPRESS;Initial Catalog = Chi-HW3; Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;";
        static void Main(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OrdersDbContext>();
            builder.UseSqlServer(ConnectionString, s => s.EnableRetryOnFailure(5));
            using var context = new OrdersDbContext(builder.Options);

            //context.Add(
            //    new Group()
            //    {
            //        GrName = "group1",
            //        GrTemp = 10.2m
            //    }
            //);
            //context.SaveChanges();
            //var year = 2020;
            //var orders = context.Orders.Where(or => or.OrdDateTime.Year == year).ToList();
        }
    }
}