using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework5.Models;

namespace Homework5.Repository
{
    public interface IRepository<T>
    {
        public List<T> Get(ADOMethod method);
        public T GetById(int id, ADOMethod method);
        public int Add(T entity);
        public int Update(T entity);
        public int Delete(int id);
        //public List<T> GetDataReader();
        //public List<T> GetDataSet();
        //protected T GetByIdDataReader(int id);
        //protected T GetByIdDataSet(int id);
    }
}
