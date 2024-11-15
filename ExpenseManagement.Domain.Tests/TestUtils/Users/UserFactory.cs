using ExpenseManagement.Domain.Tests.TestConstants;

namespace ExpenseManagement.Domain.Tests.TestUtils.Users;

public static class UserFactory
{
    public static User CreateUser(Guid? id, List<Wallet>? wallets)
    {
        return new User(
            id: id ?? Constants.User.Id,
            wallets: wallets ?? [Constants.Wallet.DefaultWallet]);
    }
}
