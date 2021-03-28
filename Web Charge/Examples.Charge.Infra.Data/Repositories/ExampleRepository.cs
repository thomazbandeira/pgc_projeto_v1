﻿using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Examples.Charge.Infra.Data.Repositories
{
    public class ExampleRepository : GenericRepository<Example>, IExampleRepository
    {
        private readonly ExampleContext _context;

        public ExampleRepository(ExampleContext context):base(context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
    }
}
