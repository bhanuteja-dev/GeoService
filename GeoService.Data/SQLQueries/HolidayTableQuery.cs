namespace GeoService.Data.SQLQueries
{
    public class HolidayTableQuery
    {
        public string GetHolidaysUpToSpecifiedDate()
        {
            var sqlQuery = "SELECT [Holiday] FROM [GeoService].[dbo].[Holidays]";
            sqlQuery += "where Holiday between GetDate() and @InputDate";

            return sqlQuery;
        }
    }
}