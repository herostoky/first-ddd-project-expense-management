namespace ExpenseManagement.Domain;

public class Wallet
{
    public readonly Guid Id;
    // private readonly string _name;
    public Wallet(Guid? id)
    {
        Id = id ?? Guid.NewGuid();
    }
}
