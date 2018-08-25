using System;
using System.Collections.Generic;
using GeoService.Entities.Queries.HolidayQueries;
using GeoService.Interfaces;
using GeoService.Interfaces.Repositories;

namespace GeoService.Handlers.Handlers
{
    public class GetHolidaysUpToSpecifiedDateQueryHandler : IQueryHandler<GetHolidaysUpToSpecifiedDateQuery, IEnumerable<DateTime>>
    {
        private readonly IHolidayRepository _repository;

        public GetHolidaysUpToSpecifiedDateQueryHandler(IHolidayRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<DateTime> Handle(GetHolidaysUpToSpecifiedDateQuery query)
        {
            return _repository.GetHolidaysUpToSpecifiedDate(query);
        }
    }
}