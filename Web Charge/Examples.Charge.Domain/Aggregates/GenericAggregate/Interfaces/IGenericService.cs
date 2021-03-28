using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.GenericAggregate.Interfaces
{
    public interface IGenericService<T> where T:class
    {
        void Insert(T entity);
        void Insert(T[] entitys);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> Filter(Func<T, bool> predicate);
        void SaveChanges();
        Task<IEnumerable<T>> FindAllAsync();
    }
}
