using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using GeoService.Entities.Queries;
using GeoService.Interfaces;

namespace GeoService.Handlers
{
    public class ValidationQueryHandlerDecorator<TQuery, TResult> : IQueryHandler<TQuery, TResult>
                                                                    where TQuery : IQuery<TResult>
    {
        private readonly IQueryHandler<TQuery, TResult> _decorator;
        private readonly IValidator<TQuery> _validator;

        public ValidationQueryHandlerDecorator(IQueryHandler<TQuery, TResult> decorator, IValidator<TQuery> validator)
        {
            _decorator = decorator;
            _validator = validator;
        }
        
        public TResult Handle(TQuery query)
        {
            var errors = _validator.Validate(query).ToList();

            if (errors.Any())
            {
                throw new AggregateException($"{query.GetType().Name} entity is not valid", new List<ValidationException>(errors));
            }

            return _decorator.Handle(query);
        }
    }
}