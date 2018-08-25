using System;
using System.Collections.Generic;
using System.ServiceModel;
using GeoService.Entities.Queries.HolidayQueries;

namespace GeoService.Contracts
{
    [ServiceContract]
    public interface IGeoService
    {
        [OperationContract]
        IEnumerable<DateTime> GetHolidaysUpToSpecifiedDate(GetHolidaysUpToSpecifiedDateQuery query);
    }
}