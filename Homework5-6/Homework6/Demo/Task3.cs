using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.DB;
using Microsoft.EntityFrameworkCore;

namespace Homework6.Demo
{
    public class Task3 : ITask
    {
        public void Demo(OrdersDbContext ordersDbContext)
        {
            var divider = new string('-', 64);

            Console.WriteLine("Task 3, variant 1");

            var orders = ordersDbContext.Orders.Include(or => or.OrdAn).Where(or => or.OrdDateTime.Year == 2022);

            foreach (var ord in orders) ord.Print();

            Console.WriteLine(divider);
            Console.WriteLine("Task 3, variant 2");

            var datetime1 = DateTime.Now.AddYears(-1);
            var datetime2 = DateTime.Now;
            orders = ordersDbContext.Orders.Include(or => or.OrdAn).Where(or => or.OrdDateTime >= datetime1 && or.OrdDateTime <= datetime2);

            foreach (var ord in orders) ord.Print();

            Console.WriteLine(divider);
        }
    }
}
