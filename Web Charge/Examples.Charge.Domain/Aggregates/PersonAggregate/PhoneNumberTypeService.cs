﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.PersonAggregate.Interfaces;
using Examples.Charge.Domain.Aggregates.GenericAggregate;

namespace Examples.Charge.Domain.Aggregates.PersonAggregate
{
    public class PhoneNumberTypeService : GenericService<PhoneNumberType>, IPhoneNumberTypeService
    {
        private readonly IPhoneNumberTypeRepository _phoneNumberTypeRepository;
        public PhoneNumberTypeService(IPhoneNumberTypeRepository phoneNumberTypeRepository) : base(phoneNumberTypeRepository)
        {
            _phoneNumberTypeRepository = phoneNumberTypeRepository;

        }
    }
}
