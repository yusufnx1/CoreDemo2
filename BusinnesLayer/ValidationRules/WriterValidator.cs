using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilmez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez."); ;
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.WriterPassword).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(p => p.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en az bir büyük harf içermelidir.");
            RuleFor(p => p.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en az bir küçük harf içermelidir.");
            RuleFor(p => p.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en az bir rakamdan içermelidir.");
        }
    }
}
