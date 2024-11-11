namespace ExpenseManagement.Domain;

public class Expense
{
    public Guid _id;
    private Guid _userId;
    private Guid _walletId;
    private decimal _amount;


    // private readonly DateTime _date;
    // private readonly string _description;
    public static Expense CreateExpense(
        Guid? id,
        Guid userId,
        Guid walletId,
        decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                amount,
                "amount.must.be.greater.than.zero");
        }
        
        return new Expense
        {
            _id = id ?? Guid.NewGuid(),
            _userId = userId,
            _walletId = walletId,
            _amount = amount
        };
    }
}
