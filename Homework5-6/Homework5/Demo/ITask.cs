using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Repository;

namespace Homework5.Demo
{
    public interface ITask
    {
        public void Demo(IOrdersRepository ordersRepository);
    }
}
