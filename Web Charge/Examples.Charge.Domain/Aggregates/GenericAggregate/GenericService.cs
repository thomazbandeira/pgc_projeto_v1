using Examples.Charge.Domain.Aggregates.GenericAggregate.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.GenericAggregate
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _genericRepository;
        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }
        public void Delete(T entity)
        {
            _genericRepository.Delete(entity);
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return _genericRepository.Filter(predicate);
        }

        public Task<IEnumerable<T>> FindAllAsync()
        {
            return _genericRepository.FindAllAsync();
        }

        public void Insert(T entity)
        {
            _genericRepository.Insert(entity);
        }

        public void Insert(T[] entitys)
        {
            _genericRepository.Insert(entitys);
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            _genericRepository.Update(entity);
        }
    }
}
