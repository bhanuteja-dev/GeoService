using GeoService.Entities.Queries;

namespace GeoService.Interfaces
{
    public interface IQueryHandler<in TQuery, out TResult> where TQuery : IQuery<TResult>
    {
        TResult Handle(TQuery query);
    }
}