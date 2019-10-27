using Backomm.Contracts.V1.Requests;
using FluentValidation;

namespace Backomm.Contracts.V1.Validations
{
    public class CreateEventValidator : AbstractValidator<CreateEventRequest>
    {
        public CreateEventValidator()
        {
            RuleFor(x => x.About)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(255);
        }
    }

    public class JoinEventValidator : AbstractValidator<JoinEventRequest>
    {
        public JoinEventValidator()
        {
            RuleFor(x => x.EventId)
                .NotNull();
        }
    }
}