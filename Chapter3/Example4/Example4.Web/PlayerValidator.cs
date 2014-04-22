using ServiceStack.FluentValidation;

namespace Example4.Web
{
    public class PlayerValidator : AbstractValidator<Player>
    {
        public PlayerValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
        }
    }
}