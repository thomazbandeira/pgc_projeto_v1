using AutoMapper;
using Examples.Charge.Application.Dtos;
using Examples.Charge.Application.Interfaces;
using Examples.Charge.Application.Messages.Request;
using Examples.Charge.Application.Messages.Response;
using Examples.Charge.Domain.Aggregates.ExampleAggregate;
using Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examples.Charge.Application.Facade
{
    public class ExampleFacade : IExampleFacade
    {
        private IExampleService _exampleService;
        private IMapper _mapper;

        public ExampleFacade(IExampleService exampleService, IMapper mapper)
        {
            _exampleService = exampleService;
            _mapper = mapper;
        }
        //aaa

        public void Delete(ExampleRequest entity)
        {
            _exampleService.Delete(_mapper.Map<Example>(entity));
        }

        public void Insert(ExampleRequest entity)
        {
            _exampleService.Insert(_mapper.Map<Example>(entity));
        }
        public void Update(ExampleRequest entity)
        {
            _exampleService.Update(_mapper.Map<Example>(entity));
        }

        public async Task<ExampleListResponse> FindAllAsync()
        {
            var result = await _exampleService.FindAllAsync();
            var response = new ExampleListResponse();
            response.ExampleObjects = new List<ExampleDto>();
            response.ExampleObjects.AddRange(result.Select(x => _mapper.Map<ExampleDto>(x)));
            return response;
        }
    }
}
