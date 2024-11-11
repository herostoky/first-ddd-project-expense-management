using ExpenseManagement.Domain.Tests.TestConstants;

namespace ExpenseManagement.Domain.Tests.TestUtils;

public class WalletFactory
{
    public static Wallet CreateWallet(Guid? id)
    {
        return new Wallet(id: id ?? Constants.Wallet.Id);
    }
}
