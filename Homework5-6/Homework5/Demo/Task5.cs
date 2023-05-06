using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Models;
using Homework5.Repository;

namespace Homework5.Demo
{
    public class Task5 : ITask
    {
        public void Demo(IOrdersRepository ordersRepository)
        {
            var divider = new string('-', 64);

            Console.WriteLine("Task 5");
            Console.WriteLine("Before update:");

            var order = ordersRepository.GetById(65, ADOMethod.DataReader);
            order.Print();
            order.OrdAn.AnId = 8;

            var count = ordersRepository.Update(order);

            if (count != 0) Console.WriteLine("Update is successful");
            else Console.WriteLine("Update is unsuccessful");

            Console.WriteLine("After update:");

            order = ordersRepository.GetById(order.OrdId, ADOMethod.DataReader);
            order.Print();

            Console.WriteLine(divider);
        }
    }
}
