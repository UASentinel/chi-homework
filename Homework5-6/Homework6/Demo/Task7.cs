using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.DB;
using Homework6.Models;
using Microsoft.EntityFrameworkCore;

namespace Homework6.Demo
{
    public class Task7 : ITask
    {
        public void Demo(OrdersDbContext ordersDbContext)
        {
            var divider = new string('-', 64);

            Console.WriteLine("Task 4");
            Console.WriteLine("Before adding:");

            var order = new Order()
            {
                OrdDateTime = DateTime.Now,
                OrdAnId = 4
            };
            order.Print();

            ordersDbContext.Add(order);
            ordersDbContext.SaveChanges();
            var ordId = order.OrdId;

            if (ordId != 0) Console.WriteLine("Adding is successful");
            else Console.WriteLine("Adding is unsuccessful");

            Console.WriteLine("After adding:");
            order.Print();
            Console.WriteLine(divider);

            Console.WriteLine("Task 5");
            Console.WriteLine("Before update:");

            order.Print();

            order.OrdAnId = 8;
            ordersDbContext.SaveChanges();

            if (order.OrdAn.AnId == 8) Console.WriteLine("Update is successful");
            else Console.WriteLine("Update is unsuccessful");

            Console.WriteLine("After update:");
            order.Print();
            Console.WriteLine(divider);

            Console.WriteLine("Task 6");
            Console.WriteLine("Before delete:");

            order.Print();

            ordersDbContext.Remove(order);
            ordersDbContext.SaveChanges();
            order = ordersDbContext.Orders.Include(or => or.OrdAn).Where(or => or.OrdId == ordId).FirstOrDefault();

            if (order == null) Console.WriteLine("Delete is successful");
            else Console.WriteLine("Delete is unsuccessful");

            Console.WriteLine(divider);
        }
    }
}
