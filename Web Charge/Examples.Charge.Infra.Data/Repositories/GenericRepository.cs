using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces.Repository;
using Examples.Charge.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class GenericRepository<T>: IGenericRepository<T> where T : class
    {
        private readonly ExampleContext _context;
        
        public GenericRepository(ExampleContext context)
        {
            _context = context;
        }
        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);

        }
        public void Insert(T[] entitys)
        {
            _context.Set<T>().AddRange(entitys);

        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);

        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);


        }
        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _context.Set<T>().Where(predicate);
        }

        public void SaveChanges() => _context.SaveChanges();

        public async Task<IEnumerable<Person>> FindAllAsync() => (IEnumerable<Person>)await Task.Run(() => _context.Set<T>().ToListAsync());
    }
}
