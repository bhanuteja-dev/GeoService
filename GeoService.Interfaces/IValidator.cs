using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GeoService.Interfaces
{
    public interface IValidator<in TQuery>
    {
        IEnumerable<ValidationException> Validate(TQuery query);
    }
}