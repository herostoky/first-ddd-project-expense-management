using ExpenseManagement.Core.UserAggregate;
using Constants = ExpenseManagement.UnitTests.Core.UserAggregate.TestConstants.Constants;

namespace ExpenseManagement.UnitTests.Core.UserAggregate.TestUtils.Users;

public static class UserFactory
{
    public static User CreateUser(Guid? id, List<Wallet>? wallets)
    {
        return new User(
            id: id ?? Constants.User.Id,
            wallets: wallets ?? [Constants.Wallet.DefaultWallet]);
    }
}
