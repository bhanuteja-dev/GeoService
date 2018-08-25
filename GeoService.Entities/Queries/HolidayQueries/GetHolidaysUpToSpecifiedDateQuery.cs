using System;
using System.Collections.Generic;
using GeoService.Entities.CustomAttributes;

namespace GeoService.Entities.Queries.HolidayQueries
{
    public abstract class GetHolidaysUpToSpecifiedDateQuery : IQuery<IEnumerable<DateTime>>
    {
        [ValidAlphaNumeric(MinLength = 1, MaxLength = 22, ErrorMessage = "Input Date is Invalid")]
        public DateTime InputDate { get; set; }
    }
}