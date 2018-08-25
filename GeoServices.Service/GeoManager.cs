using System;
using System.Collections.Generic;
using GeoService.Contracts;
using GeoService.Data;
using GeoService.Data.Repositories;
using GeoService.Data.SQLQueries;
using GeoService.Entities.Queries.HolidayQueries;
using GeoService.Handlers;
using GeoService.Handlers.Handlers;

namespace GeoServices.Service
{
    public class GeoManager : IGeoService
    {
        public IEnumerable<DateTime> GetHolidaysUpToSpecifiedDate(GetHolidaysUpToSpecifiedDateQuery query)
        {
            var handler = new ValidationQueryHandlerDecorator<GetHolidaysUpToSpecifiedDateQuery, IEnumerable<DateTime>>(
                new GetHolidaysUpToSpecifiedDateQueryHandler(new HolidayRepository(new CustomSqlConnection(),
                    new HolidayTableQuery())), new CustomValidator<GetHolidaysUpToSpecifiedDateQuery>());

            return handler.Handle(query);
        }
    }
}