namespace ExpenseManagement.Domain;

public class User
{
    private readonly Guid _id;
    private readonly List<Guid> _walletIds = [];
    private readonly List<Guid> _expenseIds  = [];
    public User(Guid? id, List<Guid>? walletIds)
    {
        _id = id ?? Guid.NewGuid();
        _walletIds = walletIds ?? [];
    }

    public void LogExpense(int amount, Guid walletId)
    {
        var expense = Expense.CreateExpense(
            id: null,
            userId: _id,
            amount: amount,
            walletId: walletId);
        
        // Log expense here
        _expenseIds.Add(expense._id);
    }
}
