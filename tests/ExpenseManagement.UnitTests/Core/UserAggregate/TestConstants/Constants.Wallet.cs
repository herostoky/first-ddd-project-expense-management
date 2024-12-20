namespace ExpenseManagement.UnitTests.Core.UserAggregate.TestConstants;

public static partial class Constants
{
    public static class Wallet
    {
        public static readonly Guid Id = Guid.NewGuid();
        public static readonly ExpenseManagement.Core.UserAggregate.Wallet DefaultWallet = new(Id);
    }
}
