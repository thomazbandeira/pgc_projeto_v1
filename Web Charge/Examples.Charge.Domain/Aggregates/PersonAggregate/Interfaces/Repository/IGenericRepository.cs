using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repository
{
    public interface IGenericRepository<T> where T: class
    {
        Task<IEnumerable<PersonAggregate.Person>> FindAllAsync();
        void Insert(T entity);
        void Insert(T[] entitys);
        void Delete(T entity);
        void Update(T entity);
        IEnumerable<T> Filter(Func<T, bool> predicate);

        void SaveChanges();
    }
}
