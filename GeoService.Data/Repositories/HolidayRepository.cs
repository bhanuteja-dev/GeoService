using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using GeoService.Data.SQLQueries;
using GeoService.Entities.Queries.HolidayQueries;
using GeoService.Interfaces.Repositories;

namespace GeoService.Data.Repositories
{
    public class HolidayRepository : IHolidayRepository
    {
        private readonly CustomSqlConnection _connection;
        private readonly HolidayTableQuery _query;

        public HolidayRepository(CustomSqlConnection connection, HolidayTableQuery query)
        {
            _connection = connection;
            _query = query;
        }
        
        public IEnumerable<DateTime> GetHolidaysUpToSpecifiedDate(GetHolidaysUpToSpecifiedDateQuery query)
        {
            SqlConnection connection = _connection.GetConnection();
            try
            {
                var getHolidayQuery = _query.GetHolidaysUpToSpecifiedDate();

                var holidays = connection.Query<DateTime>(getHolidayQuery, new {query.InputDate});

                return holidays;
            }
            finally
            {
                connection.Dispose();
            }
        }
    }
}