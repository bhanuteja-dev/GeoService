using GeoService.Entities.CustomAttributes;

namespace GeoService.Entities.Queries.ZipCodeQueries
{
    public abstract class GetCityDetailsQuery : IQuery<GetCityDetailsResult>
    {
        [ValidAlphaNumeric(MinLength = 1, MaxLength = 5, ErrorMessage = "ZipCode is Invalid")]
        public string ZipCode { get; set; }
    }
}