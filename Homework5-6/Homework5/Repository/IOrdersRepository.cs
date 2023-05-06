﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Models;

namespace Homework5.Repository
{
    public interface IOrdersRepository : IRepository<Order>
    {
        public List<Order> GetByYear(int year, ADOMethod method);
        public List<Order> GetByLastYear(ADOMethod method);
    }
}
