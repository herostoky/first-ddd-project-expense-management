using MediatR;

namespace ExpenseManagement.UseCases.Users.SignIn;

public record UserSignInCommand(string emailAddress, string clearTextPassword) : IRequest<int>;
