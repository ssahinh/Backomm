using Backomm.Contracts.V1.Requests;
using FluentValidation;

namespace Backomm.Contracts.V1.Validations
{
    public class GroupValidator : AbstractValidator<UserJoinGroupRequest>
    {
        public GroupValidator()
        {
            RuleFor(x => x.GroupId)
                .NotNull();
        }
    }
}