using ExpenseManagement.Domain.Tests.TestConstants;

namespace ExpenseManagement.Domain.Tests.TestUtils.Users;

public class UserFactory
{
    public static User CreateUser(Guid? id, List<Guid>? walletIds)
    {
        return new User(
            id: id ?? Constants.User.Id,
            walletIds: walletIds ?? [Constants.Wallet.Id]);
    }
}
