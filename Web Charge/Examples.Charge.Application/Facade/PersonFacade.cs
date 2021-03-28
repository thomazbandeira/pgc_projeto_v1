using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class PersonFacade : IPersonFacade
    {
        private readonly IPersonService _personService;
        private readonly IMapper _mapper;

        public PersonFacade(IPersonService personPhoneService, IMapper mapper)
        {
            _personService = personPhoneService;
            _mapper = mapper;
        }

        public void Delete(PersonRequest entity)
        {
            _personService.Delete(_mapper.Map<Person>(entity));
        }

        public void Insert(PersonRequest entity)
        {
            _personService.Insert(_mapper.Map<Person>(entity));
        }
        public void Update(PersonRequest entity)
        {
            _personService.Update(_mapper.Map<Person>(entity));
        }

        public async Task<PersonResponse> FindAllAsync()
        {
            var result = await _personService.FindAllAsync();
            var response = new PersonResponse();
            response.PersonObjects = new List<PersonDto>();
            response.PersonObjects.AddRange(result.Select(x => _mapper.Map<PersonDto>(x)));
            return response;
        }
    }
}
