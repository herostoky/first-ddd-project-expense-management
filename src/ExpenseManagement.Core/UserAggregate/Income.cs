namespace ExpenseManagement.Core.UserAggregate;

public class Income
{
    private readonly Guid _userId;
    private readonly Guid _walletId;
    private readonly decimal _amount;
    private readonly DateTime _date;
    private readonly string _description;

    public Income(Guid userId, Guid walletId, decimal amount, DateTime date, string description)
    {
      _userId = userId;
      _walletId = walletId;
      _amount = amount;
      _date = date;
      _description = description;
    }
}
