using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using GeoService.Interfaces;

namespace GeoService.Handlers
{
    public class CustomValidator<TQuery> : IValidator<TQuery>
    {
        public IEnumerable<ValidationException> Validate(TQuery query)
        {
            ValidationContext context = new ValidationContext(query, null, null);
            ICollection<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(query, context, results, true);
            List<ValidationException> errors = new List<ValidationException>();

            if (!isValid)
            {
                errors.AddRange(results.Select(result => new ValidationException(result.ErrorMessage)));
            }

            return errors;
        }
    }
}