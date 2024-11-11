using ExpenseManagement.Domain.Tests.TestConstants;

namespace ExpenseManagement.Domain.Tests.TestUtils.Wallets;

public static class WalletFactory
{
    public static Wallet CreateWallet(Guid? id)
    {
        return new Wallet(id: id ?? Constants.Wallet.Id);
    }
}
