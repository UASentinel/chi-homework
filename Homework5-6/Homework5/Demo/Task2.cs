using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Models;
using Homework5.Repository;

namespace Homework5.Demo
{
    public class Task2 : ITask
    {
        public void Demo(IOrdersRepository ordersRepository)
        {
            var divider = new string('-', 64);

            Console.WriteLine("Task 2, variant 1");

            var orders = ordersRepository.GetByYear(2022, ADOMethod.DataSet);
            foreach (var ord in orders) ord.Print();

            Console.WriteLine(divider);
            Console.WriteLine("Task 2, variant 2");

            orders = ordersRepository.GetByLastYear(ADOMethod.DataSet);
            foreach (var ord in orders) ord.Print();

            Console.WriteLine(divider);
        }
    }
}
