using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework6.DB;

namespace Homework6.Demo
{
    public interface ITask
    {
        public void Demo(OrdersDbContext ordersDbContext);
    }
}
