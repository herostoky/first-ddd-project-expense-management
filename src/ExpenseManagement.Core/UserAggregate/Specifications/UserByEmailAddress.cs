namespace ExpenseManagement.Core.UserAggregate.Specifications;

public sealed class UserByEmailAddress : Specification<User>
{
  public UserByEmailAddress(string emailAddress) : base()
  {
    Query.Where(user => user.EmailAddress.Equals(emailAddress, StringComparison.InvariantCultureIgnoreCase));
  }
}
