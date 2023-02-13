using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı Boş Geçilemez.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("İçerik Boş Geçilemez.");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Bir Görsel Ekleyiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Başlık en fazla 150 karakter olmalıdır.");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Başlık en az 4 karakter olmalıdır.");
        }
    }
}
