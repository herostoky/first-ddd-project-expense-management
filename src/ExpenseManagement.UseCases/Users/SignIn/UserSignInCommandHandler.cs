using MediatR;

namespace ExpenseManagement.UseCases.Users.SignIn;

public class UserSignInCommandHandler : IRequestHandler<UserSignInCommand, int>
{
  public Task<int> Handle(UserSignInCommand request, CancellationToken cancellationToken)
  {
    throw new NotImplementedException();
  }
}
