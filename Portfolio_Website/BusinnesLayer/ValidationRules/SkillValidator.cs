using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Value).NotEmpty().WithMessage("Boş geçilemez");
            RuleFor(x => x.Value).MaximumLength(2).WithMessage("maximum 2 basamaklı sayı girin");
        }
    }
}
