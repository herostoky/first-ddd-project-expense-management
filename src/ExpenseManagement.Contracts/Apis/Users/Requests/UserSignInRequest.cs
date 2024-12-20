namespace ExpenseManagement.Contracts.Apis.Users.Requests;

public record UserSignInRequest(string emailAddress, string clearTextPassword);
