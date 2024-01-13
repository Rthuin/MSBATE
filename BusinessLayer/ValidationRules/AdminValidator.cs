using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AdminValidator : AbstractValidator<Admin>
	{
		public AdminValidator()
		{
			RuleFor(x => x.AdminUsername).NotEmpty().WithMessage("Username cannot be null");
			RuleFor(x => x.AdminUsername).MinimumLength(3).WithMessage("Username must  be longer than 3");
			RuleFor(x => x.AdminPasword).NotEmpty().WithMessage("Password cannot be null");
			RuleFor(x => x.AdminPasword).MinimumLength(8).WithMessage("Password must  be longer than 8");

		}
	}
}
