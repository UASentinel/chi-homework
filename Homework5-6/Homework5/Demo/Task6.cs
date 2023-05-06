using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Models;
using Homework5.Repository;

namespace Homework5.Demo
{
    public class Task6 : ITask
    {
        public void Demo(IOrdersRepository ordersRepository)
        {
            var divider = new string('-', 64);

            Console.WriteLine("Task 6");
            Console.WriteLine("Before delete:");

            var order = ordersRepository.GetById(65, ADOMethod.DataReader);
            order.Print();

            var count = ordersRepository.Delete(order.OrdId);

            if (count != 0) Console.WriteLine("Delete is successful");
            else Console.WriteLine("Delete is unsuccessful");

            Console.WriteLine(divider);
        }
    }
}
