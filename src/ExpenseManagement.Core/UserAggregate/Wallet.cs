namespace ExpenseManagement.Core.UserAggregate;

public class Wallet
{
    public readonly Guid Id;
    // private readonly string _name;
    public Wallet(Guid? id)
    {
        Id = id ?? Guid.NewGuid();
    }

    public static Wallet CreateWallet(Guid? id)
    {
        return new Wallet(id);
    }
}
