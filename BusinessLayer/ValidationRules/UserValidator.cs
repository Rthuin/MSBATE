using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class UserValidator : AbstractValidator<User>
	{
		public UserValidator()
		{
			RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be null");
			RuleFor(x => x.UserName).NotEmpty().WithMessage("Username cannot be null");
			RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Username must  be longer than 3");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be null");
			RuleFor(x => x.Password).MinimumLength(8).WithMessage("Password must  be longer than 8");

		}
	}
}
