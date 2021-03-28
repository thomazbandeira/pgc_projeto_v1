using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;

namespace Examples.Charge.Application.Interfaces
{
    public interface IPersonFacade : IGenericFacade<PersonResponse, PersonRequest>
    {
    }
}