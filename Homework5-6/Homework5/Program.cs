using System.Configuration;
using Homework5.Models;
using Homework5.Repository;

namespace Homework5
{
    public class Program
    {
        static void Main(string[] args)
        {
            IOrdersRepository ordersRepository = new OrdersRepository();
        }
    }
}