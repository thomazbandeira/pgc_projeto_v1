﻿using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.GenericAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate
{
    public class ExampleService : GenericService<Example>, IExampleService
    {
        private IExampleRepository _exampleService;
        public ExampleService(IExampleRepository exampleService):base(exampleService)
        {
            _exampleService = exampleService;
        }
    }
}
