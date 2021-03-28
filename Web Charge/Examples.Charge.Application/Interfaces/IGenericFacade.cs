using Examples.Charge.Application.Common.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IGenericFacade<T, T2> where T: BaseResponse
        where T2:class
    {
        Task<T> FindAllAsync();
        void Insert(T2 entity);
        void Delete(T2 entity);
        void Update(T2 entity);
    }
}
