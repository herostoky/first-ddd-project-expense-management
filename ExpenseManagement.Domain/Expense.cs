namespace ExpenseManagement.Domain;

public class Expense
{
    public Guid _id;
    private Guid _userId;
    private Guid _walletId;
    private double _amount;
    
    public const int AmountDecimalPrecision = 2;


    // private readonly DateTime _date;
    // private readonly string _description;
    public static Expense CreateExpense(
        Guid? id,
        Guid userId,
        Guid walletId,
        double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                amount,
                "amount.must.be.greater.than.zero");
        }
        
        if (Math.Abs(amount - Math.Round(amount, AmountDecimalPrecision)) > 0)
        {
            throw new ArgumentException(
                $"amount.must.have.only.{AmountDecimalPrecision}.decimals");
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
