using ExpenseManagement.Core.UserAggregate;
using Constants = ExpenseManagement.UnitTests.Core.UserAggregate.TestConstants.Constants;

namespace ExpenseManagement.UnitTests.Core.UserAggregate.TestUtils.Wallets;

public static class WalletFactory
{
    public static Wallet CreateWallet(Guid? id)
    {
        return new Wallet(id: id ?? Constants.Wallet.Id);
    }
}
