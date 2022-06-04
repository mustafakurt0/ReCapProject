using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarStatusValidator : AbstractValidator<CarStatus>
    {
        public CarStatusValidator()
        {
            RuleFor(p => p.Status).NotEmpty();
            RuleFor(p => p.Status).MinimumLength(0);
            RuleFor(p => p.Status).MaximumLength(50);
        }
    }
}
