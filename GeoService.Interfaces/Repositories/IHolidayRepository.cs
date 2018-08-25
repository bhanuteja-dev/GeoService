using System;
using System.Collections.Generic;
using GeoService.Entities.Queries.HolidayQueries;

namespace GeoService.Interfaces.Repositories
{
    public interface IHolidayRepository
    {
        IEnumerable<DateTime> GetHolidaysUpToSpecifiedDate(GetHolidaysUpToSpecifiedDateQuery query);
    }
}