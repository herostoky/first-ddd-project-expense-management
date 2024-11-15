namespace ExpenseManagement.Domain;

public class User
{
    private readonly Guid _id;
    private readonly List<Guid> _walletIds;
    private readonly List<Guid> _expenseIds  = [];
    public const int MaxWalletNumber = 3;
    public User(Guid? id, List<Guid>? walletIds)
    {
        if (walletIds is not null && walletIds.Count > MaxWalletNumber)
        {
            throw new InvalidOperationException(
                $"user.must.have.only.{MaxWalletNumber}.max");
        }
        _id = id ?? Guid.NewGuid();
        _walletIds = walletIds ?? [];
    }

    public void CreateWallet(Wallet? wallet)
    {
        if (_walletIds.Count == MaxWalletNumber)
        {
            throw new InvalidOperationException(
                $"user.must.have.only.{MaxWalletNumber}.max");
        }

        if (wallet is not null && _walletIds.Contains(wallet.Id))
        {
            throw new InvalidOperationException("user.wallet.already.exits");
        }
        wallet ??= Wallet.CreateWallet(id: null);
        _walletIds.Add(wallet.Id);
    }

    public void LogExpense(double amount, Guid walletId)
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
