using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using System.Threading.Tasks;

namespace Examples.Charge.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonPhoneController : BaseController
    {
        private IPersonPhoneFacade _facade;

        public PersonPhoneController(IPersonPhoneFacade facade, IMapper mapper)
        {
            _facade = facade;
        }

        [HttpGet]
        public async Task<ActionResult<PersonPhoneResponse>> Get() => Response(await _facade.FindAllAsync());
       
        [HttpPost]
        public IActionResult Update([FromBody] PersonPhoneRequest request)
        {
            _facade.Update(request);
            return Response(0, null);
        }
        [HttpPost]
        public IActionResult Delete([FromBody] PersonPhoneRequest request)
        {
            _facade.Delete(request);
            return Response(0, null);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] PersonPhoneRequest request)
        {
            _facade.Insert(request);
            return Response(0, null);
        }
    }
}
