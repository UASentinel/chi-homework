using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Models;
using Homework5.Repository;

namespace Homework5.Demo
{
    public class Task4 : ITask
    {
        public void Demo(IOrdersRepository ordersRepository)
        {
            var divider = new string('-', 64);

            Console.WriteLine("Task 4");
            Console.WriteLine("Before adding:");

            var order = new Order()
            {
                OrdDateTime = DateTime.Now,
                OrdAn = new Analysis()
                {
                    AnId = 4
                }
            };
            order.Print();

            var ordId = ordersRepository.Add(order);

            if (ordId != 0) Console.WriteLine("Adding is successful");
            else Console.WriteLine("Adding is unsuccessful");

            Console.WriteLine("After adding:");

            order = ordersRepository.GetById(ordId, ADOMethod.DataReader);
            order.Print();

            Console.WriteLine(divider);
        }
    }
}
