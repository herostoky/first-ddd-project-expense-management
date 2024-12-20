using MediatR;

namespace ExpenseManagement.UseCases.Users.SignIn;

public record UserSignInCommand() : IRequest<int>;
