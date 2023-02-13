using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını boş geçemezsin.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Kategori açıklaması boş geçemezsin.");
            RuleFor(x => x.CategoryDescription).MaximumLength(50).WithMessage("Kategori açıklaması en fazla 50 karakter içermelidir.");
            RuleFor(x => x.CategoryDescription).MinimumLength(2).WithMessage("Kategori açıklaması  en az 2 karakter içermelidir.");
        }
    }
}
