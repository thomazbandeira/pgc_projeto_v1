using Examples.Charge.Domain.Aggregates.GenericAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PersonPhoneService : GenericService<PersonPhone>, IPersonPhoneService
    {
        private readonly IPersonPhoneRepository _personPhoneRepository;
        public PersonPhoneService(IPersonPhoneRepository personPhoneRepository):base(personPhoneRepository)
        {
            _personPhoneRepository = personPhoneRepository;
        }
    }
}
