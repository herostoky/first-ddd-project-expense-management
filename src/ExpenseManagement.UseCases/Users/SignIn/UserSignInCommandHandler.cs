using ExpenseManagement.Core.UserAggregate;
using ExpenseManagement.Core.UserAggregate.Specifications;
using MediatR;

namespace ExpenseManagement.UseCases.Users.SignIn;

public class UserSignInCommandHandler(IReadRepository<User> userReadRepository) : IRequestHandler<UserSignInCommand, int>
{


  public async Task<int> Handle(UserSignInCommand request, CancellationToken cancellationToken)
  {
    User user = await userReadRepository
      .FirstOrDefaultAsync(new UserByEmailAddress(request.emailAddress), cancellationToken)
      ?? throw new InvalidOperationException("user.not.found");


    throw new NotImplementedException();
  }
}
