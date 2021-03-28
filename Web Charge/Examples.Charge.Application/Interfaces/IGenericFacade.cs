using Examples.Charge.Application.Common.Messages;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Interfaces
{
    public interface IGenericFacade<T> where T: BaseResponse
    {
        Task<T> FindAllAsync();
    }
}
